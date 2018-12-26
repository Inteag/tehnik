/*
 * Создано в SharpDevelop.
 * Пользователь: Студент
 * Дата: 05.12.2018
 * Время: 8:05
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace laba11
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{	
            if(textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Введите значение!");
            }
            else
            {
                Random rand = new Random();
                int arraySize = Convert.ToInt32(textBox1.Text);
                int arrayNumberMin = Convert.ToInt32(textBox2.Text);
                int arrayNumberMax = Convert.ToInt32(textBox3.Text);
                string userFile = "";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    userFile = saveFileDialog1.FileName + ".txt";
                    for (int i = 0; i < arraySize; i++)
                    {
                        int a = rand.Next(arrayNumberMin, arrayNumberMax);
                        File.AppendAllText(userFile, a.ToString() + ' ');
                    }
                    for (int j = 0; j < 100; j++)
                    {
                        progressBar1.Value++;
                    }
                }
            }			
		}
		void Button2Click(object sender, EventArgs e)
		{
			if(textBox4.Text == "")
			{
				MessageBox.Show("Введите значение!");
			}
			else
			{
				int otvet = Convert.ToInt32(textBox4.Text);
				if(openFileDialog1.ShowDialog() == DialogResult.OK)
				{
                    MessageBox.Show("Тут могла бы быть ваша реклама");
					openFileDialog1.OpenFile();
				}
			}
		}
	}
}
