using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pan7.Height = woya1.Height;
            pan7.Top = woya1.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pan7.Height = woya3.Height;
            pan7.Top = woya3.Top;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void woya1_Click(object sender, EventArgs e)
        {
            pan7.Height = woya1.Height;
            pan7.Top = woya1.Top;

        }

        private void woya2_Click(object sender, EventArgs e)
        {
            pan7.Height = woya2.Height;
            pan7.Top = woya2.Top;
        }

        private void woya4_Click(object sender, EventArgs e)
        {
            pan7.Height = woya4.Height;
            pan7.Top = woya4.Top;
        }
    }
}
