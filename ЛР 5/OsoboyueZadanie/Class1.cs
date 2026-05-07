using System;
using System.Windows.Forms;

namespace Особое_задание
{
    class Class1
    {
        public string text;
        private int count = 0;
        private int temp = 0;
        private int count1 = 0;

        public Class1(TextBox t, Label l2, Label l4, ListBox lb)
        {
            text = t.Text;
        }

        public void Creating(TextBox t, Label l2, Label l4, ListBox lb)
        {
            // Определяем количество слов
            string[] str = text.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            count = str.Length;
            l2.Text = Convert.ToString(count); // вывод количества слов

            // определяем минимум и его индекс
            if (str.Length > 0)
            {
                int min = str[0].Length;
                temp = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i].Length < min)
                    {
                        min = str[i].Length;
                        temp = i;
                    }
                }
                l4.Text = Convert.ToString(str[temp] + " : под индексом " + temp); // вывод индекса
            }

            lb.Items.Clear();

            // определяем сколько раз "А" встречается в каждом слове
            int[] name = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                count1 = 0;
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (str[i][j] == 'а' || str[i][j] == 'А')
                    {
                        count1++;
                    }
                }
                name[i] = count1;
            }

            for (int i = 0; i < str.Length; i++)
            {
                string a = Convert.ToString(str[i] + " : буква 'A' встречается " + name[i] + " раз");
                lb.Items.Add(a);
            }
        }
    }
}