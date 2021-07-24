using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdControlWindowApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown1.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = (Decimal)trackBar1.Value;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = trackBar1.Value;
            timer1.Start();
        }
    }
}
