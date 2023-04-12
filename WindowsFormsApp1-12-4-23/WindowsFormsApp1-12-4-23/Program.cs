using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_12_4_23
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form1 = new Form();
            form1.Text = "Form 1";
            form1.Width = 400;
            form1.Height = 300;
            
            Label label1 = new Label();
            label1.Text = "Welcome to this application";
            label1.Font = new System.Drawing.Font("Arial", 15);
            label1.Width = 300;
            label1.Height = 70;
            label1.Left = 40;
            label1.Top = 20;

            Button button1 = new Button();
            button1.Text = "Click me!";
            button1.Width = 100;
            button1.Height = 50;
            button1.Left = 150;
            button1.Top = 100;
            button1.Click += (a ,e) => MessageBox.Show("I've been clicked!", "My Dialog");
            
            form1.Controls.Add(label1);
            form1.Controls.Add(button1);
            
            Application.Run(form1);
        }
    }
}