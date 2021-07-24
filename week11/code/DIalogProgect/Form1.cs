using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIalogProgect
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("정보를 확인시켜주기 위한 대화상자", "기본 대화상자", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = MessageBox.Show("사용자로 부터 OK Cancle을 확인하기 위한 대화상자", "OK_Cancle 대화상자", MessageBoxButtons.OKCancel, MessageBoxIcon.Information).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = MessageBox.Show("사용자로 부터 Yes, No, Cancle을 확인하기 위한 대화상자", "Yes, No, Cancel 대화상자", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = MessageBox.Show("사용자로 부터 Aboart, Retry, ignore를 확인하기 위한 대화상자", "Aboart, Retry, ignore 대화상자", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error).ToString();
        }

        ColorDialog colorDialog1 = new ColorDialog();
        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        FontDialog fontDialog1 = new FontDialog();
        private void button5_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private void button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
        private void button10_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        PrintDialog printDialog1 = new PrintDialog();
        private void button3_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            textBox1.Text = printDialog1.PrinterSettings.PrinterName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBox2.Text);
            form2.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(textBox2.Text);
            form3.ShowDialog();
            textBox1.Text = form3.Str;
        }
    }
}
