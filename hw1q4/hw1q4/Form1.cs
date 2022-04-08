using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0, avg;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sum += Convert.ToDouble(listBox1.Items[i]);
            }

            avg = (double)sum / Convert.ToDouble(listBox1.Items.Count);
            textBox1.Text = avg.ToString();
        }

    }
}
