using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadWindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                if(DialogResult.Yes == MessageBox.Show("텍스트 박스에 내용이 있습니다. 새로 만드시겠습니까?", "알림", MessageBoxButtons.YesNo))
                {
                    textBox1.Text = "";
                }
            }
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            textBox1.Text = openFileDialog.FileName;
        }

        SaveFileDialog saveFileDialog = new SaveFileDialog();
        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            textBox1.Text = saveFileDialog.FileName;
        }

        PrintDialog printDialog = new PrintDialog();
        private void 인쇄PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog.ShowDialog();
            textBox1.Text = printDialog.PrinterSettings.PrinterName;
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        FontDialog fontDialog = new FontDialog();
        private void 글꼴FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            textBox1.Font = fontDialog.Font;
        }
    }
}
