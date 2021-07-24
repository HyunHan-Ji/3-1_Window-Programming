using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIalogProgect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string str) : this()
        {
            textBox1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
