using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {
        Stopwatch st = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }
        public Bitmap Invert (Bitmap bitmap)
        {
            int x;
            int y;
            for (x = 0; x <= bitmap.Width - 1; x++)
            {
                for (y = 0; y <= bitmap.Height - 1; y += 1)
                {
                    Color oldColor = bitmap.GetPixel(x, y);
                    Color newColor;
                    newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
                    bitmap.SetPixel(x, y, newColor);
                }
            }
            return bitmap;
        }
        public void MakeGray(Bitmap bmp)
        {
            PixelFormat pxf = PixelFormat.Format24bppRgb;
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, pxf);
            IntPtr ptr = bmpData.Scan0;
            int numBytes = bmpData.Stride * bmp.Height;
            int widthBytes = bmpData.Stride;
            byte[] rgbValues = new byte[numBytes];
            Marshal.Copy(ptr, rgbValues, 0, numBytes);
            for(int counter =0;counter< rgbValues.Length;counter += 3)
            {
                int value = rgbValues[counter] + rgbValues[counter + 1] + rgbValues[counter + 2];
                byte color_b = 0;
                color_b = Convert.ToByte(value / 3);
                rgbValues[counter] = color_b;
                rgbValues[counter + 1] = color_b;
                rgbValues[counter + 2] = color_b;
            }
            Marshal.Copy(rgbValues,0,ptr,numBytes);
            bmp.UnlockBits(bmpData);
        }
        public void TwoColor(Bitmap bmp)
        {
            PixelFormat pxf = PixelFormat.Format24bppRgb;
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, pxf);
            IntPtr ptr = bmpData.Scan0;
            int numBytes = bmpData.Stride * bmp.Height;
            int widthBytes = bmpData.Stride;
            byte[] rgbValues = new byte[numBytes];
            Marshal.Copy(ptr, rgbValues, 0, numBytes);
            for (int counter = 0; counter < rgbValues.Length; counter += 3)
            {
                int value = rgbValues[counter] + rgbValues[counter + 1] + rgbValues[counter + 2];
                byte color_b = 0;
                color_b = Convert.ToByte(value / 3);
                if (color_b <= 85)
                {
                    rgbValues[counter] = 255;
                    rgbValues[counter + 1] = 255;
                    rgbValues[counter + 2] = 255;
                }
                else
                {
                    rgbValues[counter] = 0;
                    rgbValues[counter + 1] = 0;
                    rgbValues[counter + 2] = 0;
                }

            }
            Marshal.Copy(rgbValues, 0, ptr, numBytes);
            bmp.UnlockBits(bmpData);
        }

        private void Soh_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pb1.Load(openFileDialog1.FileName);
                Pb2.Image = Pb1.Image;
                Pb3.Image = Pb1.Image;
                Pb4.Image = Pb1.Image;
                Pb5.Image = Pb1.Image;
                Pb6.Image = Pb1.Image;
            }
        }

        private void Pov_Click(object sender, EventArgs e)
        {
            st.Reset();
            st.Start();
            Pb2.Image = Pb1.Image;
            Pb2.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            Pb1.Load(openFileDialog1.FileName);
            st.Stop();
            label1.Text = Convert.ToString(st.Elapsed.Milliseconds+ " мс");
        }

        private void Inv_Click(object sender, EventArgs e)
        {
            st.Reset();
            st.Start();
            Bitmap btm = new Bitmap(Pb1.Image);
            Pb3.Image = Invert(btm);
            st.Stop();
            label2.Text = Convert.ToString(st.Elapsed.Milliseconds+ " мс");
        }

        private void Ser_Click(object sender, EventArgs e)
        {
            st.Reset();
            st.Start();
            Bitmap btm = new Bitmap(Pb1.Image);
            MakeGray(btm);
            Pb4.Image = btm;
            st.Stop();
            label3.Text = Convert.ToString(st.Elapsed.Milliseconds+ " мс");
        }
        private void Vse_Click_1(object sender, EventArgs e)
        {
            st.Reset();
            st.Start();
            Bitmap btm = new Bitmap(Pb1.Image);
            Pb5.Image = Invert(btm);
            MakeGray(btm);
            Pb5.Image = btm;
            Pb5.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            st.Stop();
            label4.Text = Convert.ToString(st.Elapsed.Milliseconds+" мс");
        }

        private void Two_Click(object sender, EventArgs e)
        {
            st.Reset();
            st.Start();
            Bitmap btm = new Bitmap(Pb1.Image);
            TwoColor(btm);
            Pb6.Image = btm;
            st.Stop();
            label5.Text = Convert.ToString(st.Elapsed.Milliseconds + " мс");
        }
        private void Ochis_Click(object sender, EventArgs e)
        {
            Pb2.Image = Pb1.Image;
            Pb3.Image = Pb1.Image;
            Pb4.Image = Pb1.Image;
            Pb5.Image = Pb1.Image;
            Pb6.Image = Pb1.Image;
        }
    }
}
