using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double max = Convert.ToDouble(listBox1.Items[0]),sum=0,avg;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sum += Convert.ToDouble(listBox1.Items[i]);
                if (max < Convert.ToDouble(listBox1.Items[i]))
                {
                    max = Convert.ToDouble(listBox1.Items[i]);
                }
            }
            textBox1.Text = max.ToString();
            avg = sum / listBox1.Items.Count;
            textBox2.Text = avg.ToString();

        }
    }
}
