/*
 * Создано в SharpDevelop.
 * Пользователь: Студент
 * Дата: 28.11.2018
 * Время: 19:05
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace laba9._
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
		string text;
		string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";	
		void Button1Click(object sender, EventArgs e)
		{
			text = textBox1.Text;
			string result = "";
			int key = Convert.ToInt32(textBox2.Text);
			for(int i = 0; i < text.Length; i++)
			{
				int res = alphabet.IndexOf(text[i]) + key;
				while(res>32)
					res-=32;
				result+=alphabet[res];
			}
			textBox3.Text = result;
			button2.PerformClick();
		}
		void Button2Click(object sender, EventArgs e)
		{
			text = textBox3.Text;
			string key = textBox4.Text;
			int ost = text.Length % key.Length;
			for (int i = 0; i < ost; i++) {
				text += ' ';
			}
			string result = "";
			int count = 0;
			int rep = 0;
			for (int i = 0; i < text.Length; i++) {
				int pos = (int)Char.GetNumericValue(key[count]);
				result += text[pos-1+rep];
				count++;
				if(count > key.Length-1)
				{
					count = 0;
					rep += key.Length;
				}
			}
			textBox5.Text = result;
		}
	}
}