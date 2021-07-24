using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(textBox1.Text);
            int value2 = int.Parse(textBox2.Text);

            String result = "";
            if (value1 > value2)
            {
                result += value1.ToString() + ">" + value2.ToString();
            }
            else if (value2 > value1)
            {
                result += value1.ToString() + "<" + value2.ToString();
            }
            else
            {
                result += value1.ToString() + "=" + value2.ToString();
            }

            label3.Text = result;
        }
    }
}
