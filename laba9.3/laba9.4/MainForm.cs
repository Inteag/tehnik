/*
 * Создано в SharpDevelop.
 * Пользователь: студент
 * Дата: 21.11.2018
 * Время: 8:05
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
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
		void Button1Click(object sender, EventArgs e)
		{
			string text = textBox1.Text;
			int key = Convert.ToInt32(textBox2.Text);
			string result = "";
			string alphabet = "абвгдеёжзийклмопрстуфхцчшщъыьэюя";	
			for(int i = 0; i < text.Length; i++)
			{
				int res = alphabet.IndexOf(text[i]) + key;
				while(res>32)
					res-=32;
				result+=alphabet[res];
			}
			label1.Text = result;
		}
    }
}
