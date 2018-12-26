using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace laba8
{
	public partial class MainForm : Form
	{
		Color CurrentColor = Color.Black; 
		Point CurrentPoint; 
		Point PrevPoint; 
		bool isPressed; 
		Graphics g;
		public MainForm()
		{
			InitializeComponent();
			g = panel1.CreateGraphics();
			comboBox1.Items.Add("Прямоугольник");
			comboBox1.Items.Add("Круг");
		}
		void Panel1MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			isPressed = true;
			CurrentPoint = e.Location;
		}
		void Button1Click(object sender, System.EventArgs e)
		{
			DialogResult D = colorDialog1.ShowDialog();
			if (D == System.Windows.Forms.DialogResult.OK)
				CurrentColor = colorDialog1.Color;
		}
		void Button2Click(object sender, System.EventArgs e)
		{
			panel1.Refresh();
		}
		void ComboBox1SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}
		void Button3Click(object sender, System.EventArgs e)
		{
			Pen p = new Pen(CurrentColor, 3);
			Point point1 = new Point(50, 60);
			Point point2 = new Point(100, 45);
		    Point point3 = new Point(200, 30);
		    Point[] curvePoints =
		             {
		                 point1,
		                 point2,
		                 point3
		             };
			if (comboBox1.SelectedIndex == 0)
				g.DrawRectangle(p, 205, 125, 100, 100);
			if (comboBox1.SelectedIndex == 1)
				g.DrawEllipse(p, 205,125, 150, 150);

		}
		void Panel1MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			isPressed = false;
		}
		void MainFormMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (isPressed)
			{
				PrevPoint = CurrentPoint;
				CurrentPoint = e.Location;
				paint_simple();
			}
		}
		private void paint_simple()
		{
			Pen p = new Pen(CurrentColor);
			g.DrawLine(p, PrevPoint, CurrentPoint);
		}
	}
}
