using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                textBox3.Text = (a / b).ToString();
            }
            catch (DivideByZeroException)
            {
                textBox3.Text = "DIV/0";
            }
        }
    }
}
