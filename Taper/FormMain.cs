﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace Taper
{
    public partial class FormMain : Form
    {
        public FormMain() { InitializeComponent(); }

        #region Меню Файл (Новый, открыть, добавить, импорт)
        /// <summary>
        /// Новый файл
        /// </summary>
        void FileNew(object sender, EventArgs e)
        {
            if (!SaveQuestion()) return;
            Project.New();
            DrawProject();
        }

        /// <summary>
        /// Открыть файл
        /// </summary>
        private void FileOpen(object sender, EventArgs e)
        {
            if (!SaveQuestion()) return;
            OpenFileDialog dialog = new OpenFileDialog() { Filter = Program.FilterAll };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            Project.Open(dialog.FileName, false);
            DrawProject();
        }

        /// <summary>
        /// Добавление блоков
        /// </summary>
        void AddTAP(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog() { Title = "Добавление блоков", Filter = Program.FilterAll };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            Project.Change();
            Project.Open(dialog.FileName, true);
            DrawProject();
        }

        /// <summary>
        /// Импорт из Wav
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadFromWav(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog() { Title = "Импорт из WAV-файла блоков", Filter = Program.FilterWAV };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            FormWAVimport form = new FormWAVimport(dialog.FileName);
            form.ShowDialog();
            DrawProject();
        }
        #endregion

        #region Меню Файл (сохранить, экспортировать, выйти)
        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <param name="saveAs"></param>
        void FileSave(object sender, EventArgs e)
        {
            if (Project.name == Program.FileUnnamed | sender == menuSaveAs)
            {
                SaveFileDialog dialog = new SaveFileDialog() { Filter = Program.FilterSel };
                if (dialog.ShowDialog() == DialogResult.OK) Project.Save(dialog.FileName);
                else return;
            }
            else Project.Save(Project.name);
        }

        /// <summary>
        /// Сохранение "тапа" в "вавку"
        /// </summary>
        private void SaveToWAV(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog() { Title = "Экспорт в WAV-файл", Filter = Program.FilterWAV };
            if (dialog.ShowDialog() != DialogResult.OK) return;
            WAVmaker.Save(dialog.FileName);
        }

        #endregion

        #region Меню Вид
        private void viewListFiles(object sender, EventArgs e) { menuListFiles.Checked = true; menuListBlocks.Checked = false ; DrawProject(); }
        private void viewListBlocks(object sender, EventArgs e) { menuListFiles.Checked = false; menuListBlocks.Checked = true; DrawProject(); }
        #endregion

        #region Меню Правка
        private void Undo(object sender, EventArgs e) { Project.Undo(); DrawProject(); }
        private void Redo(object sender, EventArgs e) { Project.Redo(); DrawProject(); }
        private void Cut(object sender, EventArgs e) { Project.Cut(listViewTAP.SelectedIndices); DrawProject(); }
        private void Copy(object sender, EventArgs e) { Project.Copy(listViewTAP.SelectedIndices); }
        private void Paste(object sender, EventArgs e) { Project.Paste(listViewTAP.SelectedIndices); DrawProject(); }
        private void Delete(object sender, EventArgs e) { Project.Delete(listViewTAP.SelectedIndices); DrawProject(); }
        private void Rename(object sender, EventArgs e) { Project.Rename(listViewTAP.SelectedIndices); DrawProject(); }
        #endregion

        #region Меню Блоки
        private void MoveUp(object sender, EventArgs e) { if (Project.MoveUp(listViewTAP.SelectedIndices)) { DrawProject(); Project.RestroreSelection(listViewTAP, -1); } }
        private void MoveDown(object sender, EventArgs e) { if (Project.MoveDown(listViewTAP.SelectedIndices)) { DrawProject(); Project.RestroreSelection(listViewTAP, 1); } }
        #endregion

        #region Меню Аудио
        /// <summary>
        /// Плеер - Воспроизведение
        /// </summary>
        void Play(object sender, EventArgs e)
        {
            if (listViewTAP.Items.Count == 0) return;
            Audio.Play(listViewTAP.SelectedIndices.Count == 0 ? 0 : listViewTAP.SelectedIndices[0]);
        }

        /// <summary>
        /// Плеер - Стоп
        /// </summary>
        void Stop(object sender, EventArgs e)
        {
            Audio.Stop();
        }

        /// <summary>
        /// Загрузка со внешнего источника звука
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Record(object sender, EventArgs e)
        {
            FormRec form = new FormRec();
            form.ShowDialog();
            DrawProject();
        }
        #endregion

        #region Меню Инструменты
        /// <summary>
        /// Просмотр файла
        /// </summary>
        private void View(object sender, EventArgs e)
        {
            if (listViewTAP.SelectedIndices.Count < 1) return;
            Project.view = Project.TAP[listViewTAP.SelectedIndices[0]];
            FormViewer form = new FormViewer();
            form.ShowDialog();
        }

        private void menuFixCRCs_Click(object sender, EventArgs e)
        {
            if (Project.FixCRCs()) Program.Message("Контрольные суммы исправлены.");
            else Program.Message("Все контрольные суммы в порядке.");
        }
        private void menuFindDuplicates_Click(object sender, EventArgs e) { Project.FindDuplicates(listViewTAP); }
        #endregion

        #region Меню Справка
        private void menuPage_Click(object sender, EventArgs e) { System.Diagnostics.Process.Start("http://www.sg-software.ru/windows/programs/taper"); }
        private void menuAbout_Click(object sender, EventArgs e) { FormAbout form = new FormAbout(); form.ShowDialog(); }
        #endregion
        
        /// <summary>
        /// Обновление заголовка
        /// </summary>
        void SetFormText()
        {
            string star = ""; if (Project.changed) star = "*";
            Text = System.IO.Path.GetFileNameWithoutExtension(Project.name) + star + " - " + Program.Name;
        }
        
        /// <summary>
        /// Задание вопроса перед уничтожением файла
        /// </summary>
        bool SaveQuestion()
        {
            if (!Project.changed) return true;
            switch (MessageBox.Show("Сохранить изменения в файле \"" + System.IO.Path.GetFileNameWithoutExtension(Project.name) + "\"?", "Файл изменён", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes: FileSave(null, null); return true;
                case DialogResult.No: return true;
                case DialogResult.Cancel: return false;
            }
            return false;
        }
        
        /// <summary>
        /// Выход из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SaveQuestion()) e.Cancel = true;
            Properties.Settings.Default.Left = Left;
            Properties.Settings.Default.Top = Top;
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Вывод проекта на экран
        /// </summary>
        void DrawProject()
        {
            if (menuListFiles.Checked) Project.ListFiles(); else Project.ListBlocks();
            string NullString = "- - - - -";
            listViewTAP.Items.Clear();
            int files = 0;
            int bytes = 0;
            int fullbytes = 0;
            foreach (Block block in Project.TAP)
            {
                bool nm = block.FileTitle != null;
                bool dt = block.FileData != null;
                ListViewItem item = new ListViewItem(nm? block.FileType : "    Блок данных");
                item.SubItems.Add(nm ? block.FileName : NullString);
                item.SubItems.Add(nm ? block.Start : NullString);
                item.SubItems.Add(nm ? block.Len : NullString);
                item.SubItems.Add(dt ? (block.FileData.Length - 2).ToString() : NullString);
                item.SubItems.Add(block.CRCview());
                listViewTAP.Items.Add(item);
            }
            //Подсчёт количества блоков
            status1.Text = "Файлов в проекте: " + files;
            status2.Text = "Объём: " + bytes + " байт";
            status3.Text = "Полный объём: " + fullbytes + " байт";
            SetFormText();
        }

        private void listViewTAP_KeyDown(object sender, KeyEventArgs e) { if (e.KeyData == Keys.Enter) View(null, null); }

        private void listViewTAP_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
        }
        public void PlayerIndication(int num)
        {
            foreach (ListViewItem item in listViewTAP.Items) item.ImageIndex = -1;
            if (num >= 0)
                listViewTAP.Items[num].ImageIndex = 0;
        }

        private void listViewTAP_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string file = files[0];
            string ext = System.IO.Path.GetExtension(file).ToLower();

            if (ext == ".tap" | ext == ".tzx")
            {
                if (MessageBox.Show("Добавить файлы в проект? Нет - открыть файл.", Program.Name, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Project.Open(file, true);
                else
                {
                    SaveQuestion();
                    Project.Open(file, false);
                }
                DrawProject();
            }
            else MessageBox.Show("Файл не поддерживается", "Taper");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Left = Properties.Settings.Default.Left;
            Top = Properties.Settings.Default.Top;
            Width = Properties.Settings.Default.Width;
            Height = Properties.Settings.Default.Height;
            FileNew(null, null);
            if (Left < 0) Left = 300;
            if (Top < 0) Top = 300;

            //Загружаем файл, если он был передан через аргумент
            string[] args = Environment.GetCommandLineArgs();
            if (args.Count() == 1) return;
            string file = args[1];
            string ext = System.IO.Path.GetExtension(file).ToLower();
            if (ext == ".tap" | ext == ".tzx")
            {
                Project.Open(file, false);
                DrawProject();
            }
            else MessageBox.Show("Файл не поддерживается", "Taper");
        }
    }
}