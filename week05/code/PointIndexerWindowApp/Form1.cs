using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointIndexerWindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Point
        {
            int x, y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public Point()
            {
                x = 0;
                y = 0;
            }
            public int X
            {
                get { return x; }
                set { x = value; }
            }
            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            public void MoveTo(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void MoveBy(int moveX, int moveY)
            {
                x += moveX;
                y += moveY;
            }
            public override string ToString()
            {
                return "x: " + x + ", y: " + y;
            }
            public static Point operator +(Point p1, Point p2)
            {
                Point p = new Point();
                p.X = (p1.X + p2.X);
                return p;
            }
            public static Point operator -(Point p1, Point p2)
            {
                Point p = new Point();
                p.X = (p1.X - p2.X);
                return p;
            }
        }
 
        public class PointArray
        {
            Point[] p = new Point[10];
            public static int count = 0;

            public Point this[int index]
            {
                get { return p[index]; }
                set { p[index] = value; }
            }

        }

        PointArray PA = new PointArray();
        private void button1_Click(object sender, EventArgs e)
        {
            PA[PointArray.count++] = new Point(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";

            for (int i = 0; i < 10; i++)
            {
                if (PA[i] == null)
                    break;

                result += PA[i].ToString() + "\r\n";
            }

            textBox3.Text = result;
        }

        delegate void DmoveBy(int moveX, int moveY);     
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (PA[i] == null)
                    break;

                DmoveBy dmoveBy = new DmoveBy(PA[i].MoveBy);
                dmoveBy(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            }
        }

        delegate void DmoveTo(int x, int y);
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (PA[i] == null)
                    break;

                DmoveTo dmoveTo = new DmoveTo(PA[i].MoveTo);
                dmoveTo(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            }
        }
    }
}
