using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = double.Parse(textBox1.Text);    //키
            double weight = double.Parse(textBox2.Text);    //몸무게
            double standard = (height - 100) * 0.9;         //표준체중
            double BMI = (weight - standard) / standard * 100;  //비만지수
            String obesity;   //비만도

            if (BMI < 20)
            {
                obesity = "정상";
            }
            else if (BMI <= 30)
            {
                obesity = "경도비만";
            }
            else if (BMI <= 50)
            {
                obesity = "중도비만";
            }
            else
            {
                obesity = "고도 비만";
            }

            textBox3.Text = standard.ToString();
            textBox4.Text = BMI.ToString();
            textBox5.Text = obesity;
        }
    }
}
