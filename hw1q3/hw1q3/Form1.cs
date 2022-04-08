using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double X, Y, XYMod, YXMod, XYFdiv, YXFdiv;
            int XYDiv, YXDiv;
            double.TryParse(textBox1.Text, out X);
            double.TryParse(textBox2.Text, out Y);
            XYMod = X % Y;
            YXMod = Y % X;
            XYFdiv = X / Y;
            YXFdiv = Y / X;
            XYDiv = (int)(X / Y);
            YXDiv = (int)(Y / X);
            textBox3.Text = XYMod.ToString();
            textBox4.Text = XYDiv.ToString();
            textBox5.Text = XYFdiv.ToString();

            textBox6.Text = YXMod.ToString();
            textBox7.Text = YXDiv.ToString();
            textBox8.Text = YXFdiv.ToString();
        }
    }
}
