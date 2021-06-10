using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuvHensu
{
    public partial class Form1 : Form
    {
        int vx = 0, vy = 0;
        string kao = "(゜o゜)";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("幅" + ClientSize.Width);
            MessageBox.Show("高さ" + ClientSize.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //int textBox1 = label1.Left + 10;
            //int textBox2 = label1.Top + 10;
            //int textBox1 = vx;
            //int textBox2 = vy;

            label1.Left += vx;
            label1.Top += vy;

            if(label1.Left<0)
            {
                vx = 10;
            }
            if(label1.Right>ClientSize.Width)
            {
                vx = -10;
            }
            if (label1.Top < 0)
            {
                vy = 10;
            }
            if(label1.Bottom>ClientSize.Height)
            {
                vy = -10;
            }

            string t = label1.Text;
            label1.Text = kao;
            kao = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top - 20;
            //label1.Text = "( ゜o ゜)";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 20;
            //label1.Text = "(_ _)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 20;
            //label1.Text = "((( ・ω・)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left = label1.Left  - 20;
            //label1.Text = "(・ω・)))";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = 0;
        }     
    }
}
