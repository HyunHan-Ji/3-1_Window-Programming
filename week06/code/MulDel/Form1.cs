using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulDel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void Calc(int value1, int value2);

        Calc cal;

        private void add(int value1, int value2)
        {
            textBox1.Text += value1 + " + " + value2 + " = " + (value1 + value2)
            + Environment.NewLine;
        }
        private void sub(int value1, int value2)
        {
            textBox1.Text += value1 + " - " + value2 + " = " + (value1 - value2)
            + Environment.NewLine;
        }
        private void mul(int value1, int value2)
        {
            textBox1.Text += value1 + " * " + value2 + " = " + (value1 * value2)
            + Environment.NewLine;
        }
        private void div(int value1, int value2)
        {
            textBox1.Text += value1 + " / " + value2 + " = " + (value1 / value2)
            + Environment.NewLine;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            cal(int.Parse(textBox2.Text),int.Parse(textBox3.Text));

        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            cal += new Calc(add);
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            cal += new Calc(sub);
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            cal += new Calc(mul);
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            cal += new Calc(div);
        }

        
    }
}
