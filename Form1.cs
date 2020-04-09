using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testProj
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private int counter = 0;

        void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 1)
            {
                pictureBox1.Show();
                timer1.Stop();
                counter = 0;
            }
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(timer_Tick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            pictureBox1.Location = new Point(x + 385, y);

            if (x > this.Width)
                timer1.Stop();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
                pictureBox1.Show();
                timer1.Start();
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
