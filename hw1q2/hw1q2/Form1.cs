using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R, Ang, X, Y;
            double.TryParse(textBox1.Text, out R);
            double.TryParse(textBox2.Text, out Ang);
            X = R * Math.Cos((Ang / 180) * Math.PI);
            Y = R * Math.Sin((Ang / 180) * Math.PI);
            textBox3.Text = X.ToString();
            textBox4.Text = Y.ToString();
        }
    }
}
