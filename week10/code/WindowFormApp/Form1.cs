using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormApp
{
    public partial class Form1 : Form
    {
        FormBorderStyle FBS;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 sub = new Form2();
            sub.Text = textBox1.Text;
            sub.Location = new Point(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            sub.Size = new Size(int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            sub.FormBorderStyle = FBS;
            sub.Opacity = double.Parse(textBox6.Text);
            sub.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            FBS = FormBorderStyle.None;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            FBS = FormBorderStyle.FixedSingle;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            FBS = FormBorderStyle.FixedToolWindow;
        }
    }

   
}
