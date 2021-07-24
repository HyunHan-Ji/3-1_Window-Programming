using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point5
{
    public partial class Form1 : Form
    {
        Coloralbe3DPoint point;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)  //x변경
        {
            point.setX(int.Parse(textBox1.Text));
            textBox5.Text = point.getX().ToString();
        }

        private void button2_Click(object sender, EventArgs e)  //y변경
        {
            point.setY(int.Parse(textBox2.Text));
            textBox6.Text = point.getY().ToString();
        }

        private void button3_Click(object sender, EventArgs e)  //z변경
        {
            point.setZ(int.Parse(textBox3.Text));
            textBox7.Text = point.getZ().ToString();
        }

        private void button4_Click(object sender, EventArgs e)  //color변경
        {
            point.setColor(textBox4.Text);
            textBox8.Text = point.getColor();
        }
        private void update()   //현재 좌표 정보 수정
        {
            textBox5.Text = point.getX().ToString();
            textBox6.Text = point.getY().ToString();
            textBox7.Text = point.getZ().ToString();
        }
        private void button5_Click(object sender, EventArgs e)  //객체 생성
        {
            point = new Coloralbe3DPoint(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), textBox4.Text);

            update();
            textBox8.Text = point.getColor();
        }
        private void button6_Click(object sender, EventArgs e)  //변경
        {
            point.MoveTo(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));

            update();
        }
        private void button7_Click(object sender, EventArgs e)  //이동
        {
            point.MoveBy(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));

            update();
        }

    }
    public class Point
    {
        int x;
        int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public int getY()
        {
            return y;
        }
        public void setY(int y)
        {
            this.y = y;
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
    }
    public class Coloralbe3DPoint : Point
    {
        int z;
        string color;
        public Coloralbe3DPoint(int x, int y, int z, string color) : base(x, y)
        {
            this.z = z;
            this.color = color;
        }
        public int getZ()
        {
            return z;
        }
        public void setZ(int z)
        {
            this.z = z;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public void MoveTo(int x, int y, int z)
        {
            base.MoveTo(x, y);
            this.z = z;
        }
        public void MoveBy(int moveX, int moveY, int moveZ)
        {
            base.MoveBy(moveX, moveY);
            z += moveZ;
        }
        public override string ToString()
        {
            return base.ToString() + ", z: " + z + ", Color: " + color;
        }
    }

}
