using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadEx
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart ti = new ThreadStart(print_increase);
            Thread t1 = new Thread(ti);
            t1.Start();

            ThreadStart tj = new ThreadStart(print_decrease);
            Thread t2 = new Thread(tj);
            t2.Start();
        }
        private void print_increase()
        {
            int i = 0;
            while (true)
            {
                textBox1.Text += i + Environment.NewLine;
                i++;
                Thread.Sleep(1000);
            }
        }
        private void print_decrease()
        {
            int i = 1000000000;
            while (true)
            {
                textBox2.Text += i + Environment.NewLine;
                i--;
                Thread.Sleep(1000);
            }
        }


    }
}
