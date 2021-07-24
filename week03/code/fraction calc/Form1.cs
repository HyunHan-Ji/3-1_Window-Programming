using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fraction_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bunja1 = int.Parse(textBox1.Text);
            int bunmo1 = int.Parse(textBox2.Text);
            int bunja2 = int.Parse(textBox3.Text);
            int bunmo2 = int.Parse(textBox4.Text);

            //통분하여 덧셈
            int sumbunmo = bunmo1 * bunmo2;
            int sumbunja = bunja1 * bunmo2 + bunja2 * bunmo1;

            int GCD = GetGCD(sumbunja, sumbunmo);//최대공약수

            //약분
            int resultbunja = sumbunja / GCD;
            int resultbunmo = sumbunmo / GCD;

            textBox5.Text = resultbunja.ToString();
            textBox6.Text = resultbunmo.ToString();
        }
        int GetGCD(int a, int b) //최대공약수 찾는 코드
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
    }
}
