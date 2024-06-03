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

namespace Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread th;
        Thread th1;
        Thread th2;
        Thread th3;
        Thread th4;
        Thread th5;
        Random rdm;

        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(threadb);
            th.Start();
        }

        public void thread()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(10);
            }

            MessageBox.Show("completed blue");
        }

        public void threadb()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 20, 20));
                Thread.Sleep(10);
            }

            MessageBox.Show("completed red");
        }

        public void threadc()
        {
            for (int i = 0; i < 100; i++)
            {
                Graphics g = this.CreateGraphics();
                Color triColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                Pen triPen = new Pen(triColor, 4);
                int sideLenght = rdm.Next(10, 350);
                Point startPoint = new Point(rdm.Next(0, this.Width), rdm.Next(0, this.Height));
                Point point1 = startPoint;
                Point point2 = new Point(startPoint.X + sideLenght, startPoint.Y);
                Point point3 = new Point(startPoint.X + (int)(sideLenght / 2.0), startPoint.Y + (int)(sideLenght * Math.Sqrt(3) / 2.0));
                Point[] trianglePoints = { point1, point2, point3 };
            }
            Thread.Sleep(2000);
            
            MessageBox.Show("completed red");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            th1 = new Thread(thread);
            th1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdm = new Random();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            th3 = new Thread(threadc);
            th3.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
