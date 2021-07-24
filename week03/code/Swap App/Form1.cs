using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void swap_Click(object sender, EventArgs e)
        {
            String value1 = textBox1.Text;
            String value2 = textBox2.Text;

            swapf(value1, value2);

            textBox1.Text = value2;
            textBox2.Text = value1;
        }

        unsafe private void swapf(String a, String b)
        {
            String temp = a;
            a = b;
            b = temp;
        }
    }
}
