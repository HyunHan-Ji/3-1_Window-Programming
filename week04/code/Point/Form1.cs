using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point
{
    public partial class Form1 : Form
    {
        Point point;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            point = new Point(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = point.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            point.MoveTo(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = point.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            point.Moveby(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = point.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Point
    {
        int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void MoveTo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Moveby(int moveX, int moveY)
        {
            this.x += moveX;
            this.y += moveY;
        }

        public override string ToString()
        {
            return "x: " + x + ", y: " + y;
        }
    }
}
