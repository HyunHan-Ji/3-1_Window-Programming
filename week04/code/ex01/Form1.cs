using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = { int.Parse(textBox1.Text), int.Parse(textBox2.Text) };
            int[] b = { int.Parse(textBox3.Text), int.Parse(textBox4.Text) };

            int[] result = Fraction.add(a, b);

            textBox5.Text = result[0].ToString();
            textBox6.Text = result[1].ToString();
        }


    }
    public static class Fraction
    {
        public static int[] add(int[] a, int[] b)
        {
            int bunja1 = a[0];
            int bunmo1 = a[1];
            int bunja2 = b[0];
            int bunmo2 = b[1];
            
            //통분하여 덧셈
            int sumbunmo = bunmo1 * bunmo2;
            int sumbunja = bunja1 * bunmo2 + bunja2 * bunmo1;

            int GCD = GetGCD(sumbunja, sumbunmo);//최대공약수

            //약분
            int resultbunja = sumbunja / GCD;
            int resultbunmo = sumbunmo / GCD;

            int[] result = {resultbunja, resultbunmo };
            return result;
        }
        static int GetGCD(int a, int b) //최대공약수 찾는 코드
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
