using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (DialogResult.No == MessageBox.Show("텍스트 박스에 내용이 있습니다. 종료하시겠습니까", "알림", MessageBoxButtons.YesNo))
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
