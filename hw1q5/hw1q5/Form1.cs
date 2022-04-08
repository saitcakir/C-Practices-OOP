using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temp;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                for (int j = 1; j < listBox1.Items.Count-i; j++)
                {
                    if ( Convert.ToDouble(listBox1.Items[j-1])> Convert.ToDouble(listBox1.Items[j]))
                    {
                        temp = Convert.ToDouble(listBox1.Items[j - 1]);
                        listBox1.Items[j-1] = listBox1.Items[j];
                        listBox1.Items[j] = temp.ToString();
                    }

                }
            }

            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                listBox2.Items.Add(listBox1.Items[i]);


            }

        }
    }
}
