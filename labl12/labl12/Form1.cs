using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace labl12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox7.Text = File.ReadAllText(@"D:\\text.txt");
        }
        string text = "";
        string text2 = "";

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"D:\\text.txt", textBox7.Text);
            textBox7.Text = File.ReadAllText(@"D:\\text.txt");

            text = textBox1.Text;
            while (text.IndexOf("  ") > -1)
            {
                int pos = text.IndexOf("  ");
                text = text.Remove(pos, 1);
            }
            textBox2.Text = text;
            textBox7.Text += "Новое задание " + DateTime.Now + ' ' + text;
            File.WriteAllText(@"D:\\text.txt", textBox7.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            text = textBox3.Text;
            text2 = textBox4.Text;
            string stress = text + ' ' + text2;
            string stress2 = "";
            string[] words = stress.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        words[j] = "";
                    }
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                stress2 += words[i] + ' ';
            }
            stress2 = stress2.Remove(stress2.Length - 1);
            textBox5.Text = stress2;
            textBox7.Text += "Новое задание " + DateTime.Now + ' ' + text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = textBox11.Text;
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
                if (Char.IsDigit(text[i]))
                {
                    sum += Convert.ToInt32(Char.GetNumericValue(text[i]));

                    text = text.Remove(i, 1);
                    i--;
                }
            textBox10.Text=text;
            textBox6.Text=sum.ToString();
            textBox7.Text += "Новое задание " + DateTime.Now + ' ' + text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox7.Text = "";
        }
        void addLineInTextBox(string s)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    


        
    }
}
