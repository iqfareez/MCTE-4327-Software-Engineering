using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_GUI_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "Hii car";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
            {
                pictureBox1.Visible = false;
                button2.Text = "Show car";
            } else
            {
                pictureBox1.Visible = true;
                button2.Text = "Hide car";
            }
            
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "Mouse detected";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}
