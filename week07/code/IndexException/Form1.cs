using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndexException
{
    public partial class Form1 : Form
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox1.Text) >= arr.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                textBox2.Text = arr[int.Parse(textBox1.Text)].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                textBox2.Text = "배열 범위 벗어남";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i].ToString() + ", ";
            }
            textBox2.Text = str;
        }
    }
}
