﻿using System.Windows.Forms;

namespace Taper
{
    partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            labelVersion.Text = "Версия " + Program.Version;
			richTextBoxHostory.Text =
				"Версия 3.0 Beta (27.05.2020)\n\n" +
				"• Ещё в разработке\n\n" +
				"Версия 2.1 (09.06.2015)\n\n" +
				"• Отображение в виде шрифта с возможностью сохранения в виде изображения\n" +
				"• Drag'n'Drop: теперь файлы можно открывать перекинув их в окно программы\n" +
				"• Ещё TAP-файлы теперь можно \"открывать с помощью\"(принимаются параметры командной строки)\n" +
				"• Доработан просмотр бейсика и добавил возможность включить отступы для удобочитаемости\n" +
				"• Доработан дизассемблер, теперь воспринимаются команды с IX и IY\n" +
				"• Исправлено сохранение чёрно - белых скриншотов\n" +
				"• Исправлен вопрос о сохранении безымянного файла, когда имя было известно\n" +
				"• Исправлено добавление блоков из WAV(действие не отменялось и не сохранялось при закрытии)\n" +
				"• Исправлены некоторые ошибки при загрузке с WAV - файлов\n" +
				"• Исправлено сохранение в WAV нестандартных блоков\n" +
				"• Исправлено переименование файлов(оставались артефакты от старого имени)\n" +
				"• Прочие мелкие исправления\n\n" +
				"Версия 2.0 (16.07.2011) года\n\n" +
				"• Программа полностью переписана с ноля для платформы.NET\n" +
				"• Добавлены привычные удобства типа отмены, возврата, копирования, вырезания и вставки\n" +
				"• Выделять теперь можно сразу несколько блоков и делать с ними вышеуказанные операции\n" +
				"• Перемещать можно тоже группы файлов\n" +
				"• Заголовок и блок данных группируются в файлы.А также можно видеть о них подробную информацию\n" +
				"• Заголовки, блоки данных и нестандартные блоки теперь различаются правильно\n" +
				"• Доработан алгоритм распознавания аудиозаписей, сейчас он показывает лучший результат чем ранее. Настройка чувствительности немного\n" +
				"• упростилась, а детальный лог позволяет реставрировать аудиозаписи\n" +
				"• «Распознаватель» теперь понимает WAV - файлы любой частоты и количества каналов, 8 или 16 бит\n" +
				"• Сохранение в WAV - файлы тоже улучшено\n" +
				"• Улучшенный просмотр рисунков с возможностью растягивать картинку и сохранять её в файл. А возможность смещения байт позволяет смотреть изображение в файле, начинающимся с других данных\n" +
				"• По просьбе трудящихся: инструмент для поиска дубликатов\n" +
				"• Импорт и экспорт в TZX.Импорт особо не тестировал, если у кого-то возникнут проблемы – можете мне сообщить\n" +
				"• Возможность переименовывать заголовки блоков\n" +
				"• Дизассемблер(начальный вариант)\n\n" +
				"Версия 1.2 (2007)\n\n" + //Узнать точную дату
				"• Уточнение пользователем неясных сигналов при загрузке из WAV-файлов\n" +
				"• Изменён анализ спектра\n" +
				"• Исправлена ошибка при добавлении загруженных блоков в проект(не добавлялась контрольная сумма)\n" +
				"• Добавлен инструмент для проверки и исправления контрольных сумм\n" +
				"• Отмена долгих процессов\n\n" +
				"Версия 1.1 (2007)\n\n" + //Узнать точную дату
				"• Загрузка из WAV - файлов\n" +
				"• Анализатор спектра WAV - файлов\n" +
				"• Сохранение в WAV - файл\n" +
				"• Исправлены недочёты в диалоговых окнах\n" +
				"• Просмотрщик картинок не стирает картинку при наложении других окон, хотя по-прежнему очень медленный\n" +
				"• Немного поправлено отображение BASIC-программ\n" +
				"• Новая панель управления\n" +
				"• Строка состояния с выводом количества блоков, файлов и общего размера данных\n" +
				"• Индикация прогресса при загрузке/ сохранении файлов\n" +
				"• Справка\n\n" +
				"Версия 1.0 (2004)\n\n" + //Узнать точную дату
				"• Исправлено множество ошибок, среди которых неправильное сохранение файла\n" +
				"• Доделан просмотр в виде скриншота\n" +
				"• Просмотр в виде текста\n" +
				"• Просмотр 10 - ричного кода\n" +
				"• Панель управления(пока только с основными кнопками)\n" +
				"• Возможность изменять размер основного окна\n\n" +
				"Версия Beta (2004)\n\n" + //Узнать точную дату
				"• Появилась на свет с основными функциями, некоторые из которых не работали, или делали совсем не то";
		}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sg-software.ru");
        }

        private void linkLabelSite_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.sg-software.ru");
        }
    }
}
