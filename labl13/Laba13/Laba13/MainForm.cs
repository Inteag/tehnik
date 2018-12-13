/*
 * Создано в SharpDevelop.
 * Пользователь: Студент
 * Дата: 12.12.2018
 * Время: 8:12
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DllLaba13;
namespace Laba13
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
			var m = new MyClass();
			int a = 10, b = 5;
			int s = m.summ(a,b);
			textBox1.Text = Convert.ToString(s);
		}
	}
}
