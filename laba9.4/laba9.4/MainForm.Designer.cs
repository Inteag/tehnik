/*
 * Создано в SharpDevelop.
 * Пользователь: Студент
 * Дата: 28.11.2018
 * Время: 19:05
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace laba9._
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(179, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "сигнал";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(12, 38);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(179, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "5";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(12, 84);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(179, 20);
			this.textBox3.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(197, 36);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(197, 113);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(12, 115);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(179, 20);
			this.textBox4.TabIndex = 6;
			this.textBox4.Text = "4321";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(12, 163);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(179, 20);
			this.textBox5.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "laba9.4";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
