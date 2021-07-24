using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocationFontEventTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void LabelSize(int n)
        {
            lblHorse.Font = new Font("굴림", lblHorse.Font.Size + n);
        }
        private void btnSizeUp_Click(object sender, EventArgs e)
        {
            LabelSize(1);
        }

        private void btnSizeDown_Click(object sender, EventArgs e)
        {
            LabelSize(-1);
        }

        void LabelMove(int x, int y)
        {
            lblHorse.Location = new Point(lblHorse.Location.X + x, lblHorse.Location.Y + y);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            LabelMove(0, -1);
        }
        private void btnDown_Click(object sender, EventArgs e)
        {
            LabelMove(0,1);
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            LabelMove(-1,0);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            LabelMove(1,0);
        }

        private void btnUpLeft_Click(object sender, EventArgs e)
        {
            LabelMove(-1,-1);
        }

        private void btnUpRight_Click(object sender, EventArgs e)
        {
            LabelMove(1,-1);
        }

        private void btnDownLeft_Click(object sender, EventArgs e)
        {
            LabelMove(-1,1);
        }

        private void btnDownRight_Click(object sender, EventArgs e)
        {
            LabelMove(1,1);
        }
    }
}
