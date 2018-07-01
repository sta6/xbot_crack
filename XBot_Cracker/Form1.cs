using System;
using System.Windows.Forms;

namespace XBot_Cracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"c:\windows\system32\drivers\etc\hosts";
            try
            {
                string str;
                using (System.IO.StreamReader reader = System.IO.File.OpenText(path))
                {
                    str = reader.ReadToEnd();
                }

                if (str.Contains("xbotapp.ru"))
                {
                    MessageBox.Show("Уже крякнут ^^");
                    return;
                }
                str = str + Environment.NewLine + "5.8.52.207 xbotapp.ru";

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, false))
                {

                    file.WriteLine(str);

                }
                MessageBox.Show("Успешно крякнули <3" + Environment.NewLine + "Изменения вступят в течении нескольких минут.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка :(");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/docs-154032675");
        }
    }
}
