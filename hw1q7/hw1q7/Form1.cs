using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1q7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string context = listBox1.Items[i].ToString();
                string[] nameandmeaning = context.Split(':');
                string name = nameandmeaning[0];

                if (textBox1.Text == name || textBox1.Text == name.ToLower())
                {
                    textBox2.Text = listBox1.Items[i].ToString();
                    break;
                }
                else
                {
                    textBox2.Text = "This name is not so popular in Turkish.";
                }
            }

        }
    }
}
