using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBF_CHANGE_CODEPAGE
{
    public partial class Form1 : Form
    {
        private bool firstBoot = true;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 5;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) comboBox1.SelectedIndex = 1;
            if (comboBox1.SelectedIndex == 6) comboBox1.SelectedIndex = 7;
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (firstBoot)
            {
                firstBoot = false;
                listBox1.Items.Clear();
            };

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                if (System.IO.Path.GetExtension(file).ToLower() == ".dbf")
                {
                    System.IO.FileStream fs = new System.IO.FileStream(file, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    fs.Position = 29; // 0x1D
                    int fc = fs.ReadByte();
                    fs.Close();
                    listBox1.Items.Add(file + " \t\t\t*cp 0x" + fc.ToString("X")+"*");
                };
                if (System.IO.Path.GetExtension(file).ToLower() == ".txt")
                {
                    textBox1.Text = "Импорт файлов DBF из файла " + file +"\r\n";
                    int fa = 0;

                    System.IO.FileStream fs = new System.IO.FileStream(file, System.IO.FileMode.Open);
                    System.IO.StreamReader sr = new System.IO.StreamReader(fs);
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine().Trim();
                        if (System.IO.File.Exists(line) && (System.IO.Path.GetExtension(line).ToLower() == ".dbf"))
                        {
                            System.IO.FileStream fd = new System.IO.FileStream(line, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                            fd.Position = 29; // 0x1D
                            int fc = fd.ReadByte();
                            fd.Close();
                            listBox1.Items.Add(line + " \t\t\t*cp 0x" + fc.ToString("X") + "*");

                            textBox1.Text += "Добавлен " + line + " \r\n";
                            fa++;
                        };
                    };
                    sr.Close();
                    fs.Close();
                    textBox1.Text += "Добавлено "+fa.ToString()+" файлов\r\n";
                };
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            firstBoot = true;
            listBox1.Items.Add("-- перетащите сюда файлы DBF или файл(ы) TXT со списком всех dbf-файлов ---");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0) return;
            if (firstBoot) return;

            string codepage = comboBox1.Text.Substring(2, 2);
            byte cp = (byte)int.Parse(codepage, System.Globalization.NumberStyles.HexNumber);

            textBox1.Text = "";
            textBox1.Text += String.Format("{0}: {1}\r\n\r\n", DateTime.Now.ToString(), "Начало обработки " + listBox1.Items.Count.ToString() + " файлов");
            textBox1.Text += String.Format("Кодовая страница: [{1}] - {0}\r\n\r\n", comboBox1.Text, cp);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string f = ((string)listBox1.Items[i]).Split(new string[]{"*cp"},StringSplitOptions.None)[0].Trim();
                //
                if (System.IO.File.Exists(f))
                {
                    try
                    {
                        System.IO.FileStream fs = new System.IO.FileStream(f, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite);
                        fs.Position = 29; // 0x1D
                        int fc = fs.ReadByte();
                        fs.Position = 29; // 0x1D
                        fs.WriteByte(cp);
                        fs.Flush();
                        fs.Close();
                        textBox1.Text += String.Format("{0} \t... 0x{1}->0x{2} - OK\r\n", f, fc.ToString("X"), cp.ToString("X"));
                    }
                    catch (Exception ex)
                    {
                        textBox1.Text += String.Format("{0} \t... ERROR: {1}\r\n", f, ex.Message);
                    };
                }
                else
                {
                    textBox1.Text += String.Format("{0} \t... ERROR: Файл не найден!\r\n", f);
                };
                //Application.DoEvents();
            };
            textBox1.Text += String.Format("\r\n{0}: {1}\r\n", DateTime.Now.ToString(), "Обработка завершена, обработано " + listBox1.Items.Count.ToString() + " файлов");
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) && (listBox1.SelectedItems.Count > 0))
            {
                int si = listBox1.SelectedIndex;
                listBox1.Items.Remove(listBox1.SelectedItem);
                if ((si >= 0) && (si < listBox1.Items.Count))
                    listBox1.SelectedIndex = si;
                if ((si >= listBox1.Items.Count) && (listBox1.Items.Count > 0))
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
            };
        }
    }
}