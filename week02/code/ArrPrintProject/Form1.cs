using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrPrintProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 3, 4, 5, 6, 7, 9, 8, 2, 0 };

            string str = "";
            for(int i = 0; i < arr.Length; i++)
            {
                str += arr[i];
                if (i != arr.Length - 1)
                {
                    str += ",";
                }
            }

            textBox1.Text = str;
        }
    }
}
