using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Dateformat string: https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
            timerLabel.Text = DateTime.Now.ToString("HH:mm:ss, dddd");
        }
    }
}