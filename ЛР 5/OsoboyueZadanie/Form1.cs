using System;
using System.Windows.Forms;

namespace Особое_задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 qwe;

        private void button1_Click(object sender, EventArgs e)
        {
            // объект
            qwe = new Class1(textBox1, label2, label4, listBox1);
            // выполнение функций
            qwe.Creating(textBox1, label2, label4, listBox1);
        }

        private void условиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Яковлев Андрей");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}