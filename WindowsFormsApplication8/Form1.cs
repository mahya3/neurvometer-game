using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        bool start = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            start = true;
            label25.Text = "0";
            timer1.Enabled = true;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (start == true)
            {
                start = false;
                Console.Beep(1500, 500);
                timer1.Enabled = false;
                MessageBox.Show("شما بازنده شدید");
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (start == true)
            {
                start = false;
                timer1.Enabled = false;
                MessageBox.Show("شما برنده شدید");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label25.Text = (int.Parse(label25.Text) + 1).ToString();
        }
    }
}
