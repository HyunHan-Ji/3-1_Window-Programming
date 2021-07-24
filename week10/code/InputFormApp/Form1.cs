using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string gender;
        string favorite = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string age = textBox2.Text;
            string birthY = textBox3.Text;
            string birthM = textBox4.Text;
            string birthD = textBox5.Text;

            Form2 f2 = new Form2(name, age, gender, birthY, birthM, birthD, favorite);
            f2.Show();

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "man";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "woman";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            favorite += "fishing\r\n";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            favorite += "gaming\r\n";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            favorite += "singing\r\n";
        }


    }
}
