using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point4
{
    public partial class Form1 : Form
    {
        Point<int> point;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            point = new Point<int>(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = point.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            point.X = int.Parse(textBox1.Text);
            point.Y = int.Parse(textBox2.Text);
            textBox3.Text = point.ToString();
        }
    }

    public class Point<T>
    {
        private T x;
        private T y;

        public Point(T x,T y)
        {
            this.x = x;
            this.y = y;
        }
        public T X
        {
            get { return x; }
            set { x = value; }
        }
        public T Y
        {
            get { return y; }
            set { y = value; }
        }
        public void MoveTo(T x,T y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "x: " + x + ", y: " + y;
        }
    }
}
