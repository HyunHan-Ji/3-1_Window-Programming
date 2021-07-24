using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact
{
    public partial class Form1 : Form
    {
        Contact contact;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox7.Text = contact.ToString();
        }

        private void button2_Click(object sender, EventArgs e)  //객체생성
        {
            contact = new Contact(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
        }
    }

    public class Contact
    {
        string name;
        int age;
        string company;
        string cellPhone;
        string tel;
        String mail;

        public Contact(string name, int age, string company, string cellPhone, string tel, string mail)
        {
            this.name = name;
            this.age = age;
            this.company = company;
            this.cellPhone = cellPhone;
            this.tel = tel;
            this.mail = mail;
        }
        public override string ToString()
        {
            return "이름: " + name + ", 나이: " + age + ", 직장: " + company + ", 휴대폰: " + cellPhone + ", 전화: " + tel + ", 메일: " + mail;
        }
    }
}
