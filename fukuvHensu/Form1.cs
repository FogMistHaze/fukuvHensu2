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
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int textBox1 = label1.Left + 10;
            int textBox2 = label1.Top + 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Top = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Top = +1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Left = +1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left = -1;
        }
    }
}
