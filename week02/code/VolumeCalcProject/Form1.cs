using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeCalcProject
{
    public partial class frmVolumeCalc : Form
    {
        public frmVolumeCalc()
        {
            InitializeComponent();
        }

        private void frmVolumeCalc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int width;
            int height;
            int depth;
            int volume;

            width = int.Parse(txtWidth.Text);
            height= int.Parse(txtHeight.Text);
            depth = int.Parse(txtDepth.Text);

            volume = width * height * depth;

            txtVolume.Text = volume.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
