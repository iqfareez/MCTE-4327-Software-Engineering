using System;
using System.Windows.Forms;

namespace ConsoleApp1_GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            form1.Text = "Hellllo";

            Button button1 = new Button();
            button1.Text = "Click me";
            button1.Click += (a, e) => MessageBox.Show("hi");

            form1.Controls.Add(button1);

            //form1.Show();
            Application.Run(form1);
        }
    }
}
