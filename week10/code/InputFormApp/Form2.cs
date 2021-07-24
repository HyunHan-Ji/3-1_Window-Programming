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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string name, string age, string gender, string birthY, string birthM, string birthD, string favorite) : this()
        {
            textBox1.Text = name;
            textBox2.Text = age;
            textBox3.Text = gender;
            textBox4.Text = birthY;
            textBox5.Text = birthM;
            textBox6.Text = birthD;
            textBox7.Text = favorite;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
