namespace DBF_CHANGE_CODEPAGE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 29);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Очистить список";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "-- Основные кодировки --",
            "0x26 Codepage 866 - Russian OEM",
            "0x57 Codepage Current ANSI CP - ANSI",
            "0x65 Codepage 866 - Russian MS-DOS",
            "0x96 Codepage 10007 - Russian Macintosh",
            "0xC9 Codepage 1251 - Russian Windows",
            "-- Другие кодировки --",
            "0x01 Codepage 437 - US MS-DOS",
            "0x02 Codepage 850 - International MS-DOS",
            "0x03 Codepage 1252 - Windows ANSI Latin I",
            "0x04 Codepage 10000 - Standard Macintosh",
            "0x08 Codepage 865 - Danish OEM",
            "0x09 Codepage 437 - Dutch OEM",
            "0x0A Codepage 850 - Dutch OEM*",
            "0x0B Codepage 437 - Finnish OEM",
            "0x0D Codepage 437 - French OEM",
            "0x0E Codepage 850 - French OEM*",
            "0x0F Codepage 437 - German OEM",
            "0x10 Codepage 850 - German OEM*",
            "0x11 Codepage 437 - Italian OEM",
            "0x12 Codepage 850 - Italian OEM*",
            "0x13 Codepage 932 - Japanese Shift-JIS",
            "0x14 Codepage 850 - Spanish OEM*",
            "0x15 Codepage 437 - Swedish OEM",
            "0x16 Codepage 850 - Swedish OEM*",
            "0x17 Codepage 865 - Norwegian OEM",
            "0x18 Codepage 437 - Spanish OEM",
            "0x19 Codepage 437 - English OEM (Great Britain)",
            "0x1A Codepage 850 - English OEM (Great Britain)*",
            "0x1B Codepage 437 - English OEM (US)",
            "0x1C Codepage 863 - French OEM (Canada)",
            "0x1D Codepage 850 - French OEM*",
            "0x1F Codepage 852 - Czech OEM",
            "0x22 Codepage 852 - Hungarian OEM",
            "0x23 Codepage 852 - Polish OEM",
            "0x24 Codepage 860 - Portuguese OEM",
            "0x25 Codepage 850 - Portuguese OEM*",
            "0x37 Codepage 850 - English OEM (US)*",
            "0x40 Codepage 852 - Romanian OEM",
            "0x4D Codepage 936 - Chinese GBK (PRC)",
            "0x4E Codepage 949 - Korean (ANSI/OEM)",
            "0x4F Codepage 950 - Chinese Big5 (Taiwan)",
            "0x50 Codepage 874 - Thai (ANSI/OEM)",
            "0x58 Codepage 1252 - Western European ANSI",
            "0x59 Codepage 1252 - Spanish ANSI",
            "0x64 Codepage 852 - Eastern European MS-DOS",
            "0x66 Codepage 865 - Nordic MS-DOS",
            "0x67 Codepage 861 - Icelandic MS-DOS",
            "0x68 Codepage 895 - Kamenicky (Czech) MS-DOS",
            "0x69 Codepage 620 - Mazovia (Polish) MS-DOS",
            "0x6A Codepage 737 - Greek MS-DOS (437G)",
            "0x6B Codepage 857 - Turkish MS-DOS",
            "0x6C Codepage 863 - French-Canadian MS-DOS",
            "0x78 Codepage 950 - Taiwan Big 5",
            "0x79 Codepage 949 - Hangul (Wansung)",
            "0x7A Codepage 936 - PRC GBK",
            "0x7B Codepage 932 - Japanese Shift-JIS",
            "0x7C Codepage 874 - Thai Windows/MS–DOS",
            "0x86 Codepage 737 - Greek OEM",
            "0x87 Codepage 852 - Slovenian OEM",
            "0x88 Codepage 857 - Turkish OEM",
            "0x97 Codepage 10029 - Eastern European Macintosh",
            "0x98 Codepage 10006 - Greek Macintosh",
            "0xC8 Codepage 1250 - Eastern European Windows",
            "0xCA Codepage 1254 - Turkish Windows",
            "0xCB Codepage 1253 - Greek Windows",
            "0xCC Codepage 1257 - Baltic Windows"});
            this.comboBox1.Location = new System.Drawing.Point(231, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Изменить существующую кодировку на:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 206);
            this.panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(756, 206);
            this.textBox1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 264);
            this.panel3.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "-- перетащите сюда файлы DBF или файл(ы) TXT со списком всех dbf-файлов ---"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(756, 262);
            this.listBox1.TabIndex = 2;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBox1_KeyPress);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 499);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DBF CHANGE CODEPAGE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

