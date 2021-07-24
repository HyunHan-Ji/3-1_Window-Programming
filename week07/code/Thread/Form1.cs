using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart ti = new ThreadStart(print_increase); // 첫 번째 델리게이트 생성
            Thread t1 = new Thread(ti);    // 델리게이트를 이용한 스레드 객체 생성
                                    // ... 두 번째 스레드 생성
            t1.Start();  // 스레드 동작
                         // ... 두 번째 스레드 동작
        }
        private void print_increase()
        {
            int i = 0;
            while (true)
            {
                textBox1.Text += i + Environment.NewLine;
                i++;
                Thread.Sleep(1000);
            }
        }
    }
}
