using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_Login_system
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var username = usernameTextbox.Text;
            var password = passwordTextbox.Text;

            var adminUsername = "admin";
            var adminPassword = "1234";

            if (username != adminUsername || password != adminPassword)
            {
                MessageBox.Show("Incorrect credentials");
                return;
            }

            // open new dialog
            var myForm = new Form2();
            myForm.Show();
        }
    }
}
