using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCalcWindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Complex
        {
            double real;
            double imaginary;

            public Complex(double real, double imaginary)
            {
                this.real = real;
                this.imaginary = imaginary;
            }
            public double Real
            {
                get { return real; }
            }
            public double Imaginary
            {
                get { return imaginary; }
            }
            public static Complex operator +(Complex c1, Complex c2)
            {
                Complex c = new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
                return c;
            }
            public static Complex operator *(Complex c1, Complex c2)
            {
                double a = c1.real;
                double b = c1.imaginary;
                double c = c2.real;
                double d = c2.imaginary;

                Complex co = new Complex(a * c - b * d, b * c + a * d);
                return co;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            Complex c2 = new Complex(double.Parse(textBox3.Text), double.Parse(textBox4.Text));

            Complex c = c1 + c2;

            textBox5.Text = c.Real.ToString();
            textBox6.Text = c.Imaginary.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            Complex c2 = new Complex(double.Parse(textBox3.Text), double.Parse(textBox4.Text));

            Complex c = c1 * c2;

            textBox5.Text = c.Real.ToString();
            textBox6.Text = c.Imaginary.ToString();
        }
    }
}
