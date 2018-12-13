using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba9._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string res = "";
            int key = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < str.Length; i++)
                res += Convert.ToChar(str[i] ^ key);
            textBox3.Text = res;
        }
    }
}
