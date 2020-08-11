﻿namespace Taper
{
    partial class FormRec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBlock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCRC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonWave = new System.Windows.Forms.RadioButton();
            this.radioButtonSpectrum = new System.Windows.Forms.RadioButton();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.groupBoxIndicator = new System.Windows.Forms.GroupBox();
            this.border = new System.Windows.Forms.PictureBox();
            this.groupBoxIndicator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.border)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(297, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(216, 326);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(68, 110);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(120, 13);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Загруженные данные:";
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTime,
            this.columnHeaderBlock,
            this.columnHeaderCRC});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(68, 126);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(304, 194);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTime
            // 
            this.columnHeaderTime.Text = "Время";
            // 
            // columnHeaderBlock
            // 
            this.columnHeaderBlock.Text = "Блок";
            this.columnHeaderBlock.Width = 150;
            // 
            // columnHeaderCRC
            // 
            this.columnHeaderCRC.Text = "CRC";
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(164, 12);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(208, 21);
            this.comboBoxDevices.TabIndex = 10;
            this.comboBoxDevices.SelectedIndexChanged += new System.EventHandler(this.comboBoxDevices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Источник звука:";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.Location = new System.Drawing.Point(68, 326);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonWave
            // 
            this.radioButtonWave.AutoSize = true;
            this.radioButtonWave.Location = new System.Drawing.Point(6, 42);
            this.radioButtonWave.Name = "radioButtonWave";
            this.radioButtonWave.Size = new System.Drawing.Size(56, 17);
            this.radioButtonWave.TabIndex = 18;
            this.radioButtonWave.Text = "Волна";
            this.radioButtonWave.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpectrum
            // 
            this.radioButtonSpectrum.AutoSize = true;
            this.radioButtonSpectrum.Checked = true;
            this.radioButtonSpectrum.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSpectrum.Name = "radioButtonSpectrum";
            this.radioButtonSpectrum.Size = new System.Drawing.Size(124, 17);
            this.radioButtonSpectrum.TabIndex = 16;
            this.radioButtonSpectrum.TabStop = true;
            this.radioButtonSpectrum.Text = "Как на ZX Spectrum";
            this.radioButtonSpectrum.UseVisualStyleBackColor = true;
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Checked = true;
            this.checkBoxAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAll.Location = new System.Drawing.Point(136, 20);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(89, 17);
            this.checkBoxAll.TabIndex = 19;
            this.checkBoxAll.Text = "Все частоты";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            // 
            // groupBoxIndicator
            // 
            this.groupBoxIndicator.Controls.Add(this.checkBoxAll);
            this.groupBoxIndicator.Controls.Add(this.radioButtonSpectrum);
            this.groupBoxIndicator.Controls.Add(this.radioButtonWave);
            this.groupBoxIndicator.Location = new System.Drawing.Point(71, 39);
            this.groupBoxIndicator.Name = "groupBoxIndicator";
            this.groupBoxIndicator.Size = new System.Drawing.Size(301, 68);
            this.groupBoxIndicator.TabIndex = 19;
            this.groupBoxIndicator.TabStop = false;
            this.groupBoxIndicator.Text = "Индикатор";
            // 
            // border
            // 
            this.border.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.border.Location = new System.Drawing.Point(12, 12);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(50, 337);
            this.border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.border.TabIndex = 9;
            this.border.TabStop = false;
            // 
            // FormRec
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.groupBoxIndicator);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDevices);
            this.Controls.Add(this.border);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.listView);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "FormRec";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Запись";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTapeLoader_FormClosing);
            this.Load += new System.EventHandler(this.FormTapeLoader_Load);
            this.Shown += new System.EventHandler(this.FormRec_Shown);
            this.groupBoxIndicator.ResumeLayout(false);
            this.groupBoxIndicator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.border)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeaderTime;
        private System.Windows.Forms.ColumnHeader columnHeaderBlock;
        private System.Windows.Forms.ColumnHeader columnHeaderCRC;
        private System.Windows.Forms.PictureBox border;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonWave;
        private System.Windows.Forms.RadioButton radioButtonSpectrum;
        private System.Windows.Forms.CheckBox checkBoxAll;
        private System.Windows.Forms.GroupBox groupBoxIndicator;
    }
}