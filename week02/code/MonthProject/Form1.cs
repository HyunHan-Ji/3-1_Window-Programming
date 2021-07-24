using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBox1.Text);
            int day=0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;

                case 2:
                    day = 28;
                    break;
            }

            textBox2.Text = day.ToString();
        }
    }
}
