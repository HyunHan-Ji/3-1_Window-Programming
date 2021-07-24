using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            int result=0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+')
                {
                    result = int.Parse(str.Substring(0, i)) + int.Parse(str.Substring(i + 1));
                    break;
                }
                else if (str[i] == '-')
                {
                    result = int.Parse(str.Substring(0, i)) - int.Parse(str.Substring(i + 1));
                    break;
                }
                else if (str[i] == '*')
                {
                    result = int.Parse(str.Substring(0, i)) * int.Parse(str.Substring(i + 1));
                    break;
                }
                else if (str[i] == '/')
                {
                    result = int.Parse(str.Substring(0, i)) / int.Parse(str.Substring(i + 1));
                    break;
                }
            }

            textBox1.Text = result.ToString();
        }
    }
}
