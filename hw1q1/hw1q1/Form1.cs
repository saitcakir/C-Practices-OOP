using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double X, Y, Z, W;
            double.TryParse(textBox1.Text, out X);
            double.TryParse(textBox2.Text, out Y);
            double.TryParse(textBox3.Text, out Z);

            if (X + Y != 0)
            {
                W = (X * X * X + 3 * X * Y + 2 * Z * Z) / (X + Y);

            }
            else
            {
                MessageBox.Show("Error X+Y =0");
                W = 0;
            }
            textBox4.Text = W.ToString();

        }
    }
}
