using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("파일열기메뉴선택", "ToolStripMenuItem_Click");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("파일저장메뉴선택", "ToolStripMenuItem_Click");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            foreach (ToolStripMenuItem it in item.Owner.Items)
            {
                if (it == item)
                {
                    it.Checked = true;
                }
                else
                {
                    it.Checked = false;
                }
            }
            txtOut.TextAlign = HorizontalAlignment.Left;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            foreach (ToolStripMenuItem it in item.Owner.Items)
            {
                if (it == item)
                {
                    it.Checked = true;
                }
                else
                {
                    it.Checked = false;
                }
            }
            txtOut.TextAlign = HorizontalAlignment.Center;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            foreach (ToolStripMenuItem it in item.Owner.Items)
            {
                if (it == item)
                {
                    it.Checked = true;
                }
                else
                {
                    it.Checked = false;
                }
            }
            txtOut.TextAlign = HorizontalAlignment.Right;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOut.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOut.Text += Clipboard.GetText();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            StatusStrip statusStrip1 = (StatusStrip)sender;
            MessageBox.Show(e.ClickedItem.Text, " statusStrip1_ItemClicked");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (statusStrip1.Items.Count > 0)
            {
                statusStrip1.Items[0].Text = "마우스 포인터 : " + e.X + "," + e.Y;
            }
        }
    }
}
