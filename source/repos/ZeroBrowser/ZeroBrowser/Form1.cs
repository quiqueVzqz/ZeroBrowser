using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeroBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");
        }
    }
}
