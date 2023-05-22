using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_GUI_Threading
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false; // disable button
            label2.Text = "Processing...";

            var t1 = new Thread(Process);
            t1.Start();            

            // Process2();
        }

        private void Process2()
        {
            //Task.Run(() => MessageBox.Show("Hello thread pool"));
            Task<int> task = Task.Run(() => { 
                Thread.Sleep(2300);
                return 5;
            });
            //MessageBox.Show(task.IsCompleted.ToString()); // False
            //task.Wait(); // Blocks until task is complete

            task.GetAwaiter().OnCompleted(()=>{
                var result = task.Result;
                MessageBox.Show($"Result is {result}");
            });
                
        }

        private void Process()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50); // total operation take 5s
                // very buggy progress bar
                progressBar1.BeginInvoke(new Action(() => progressBar1.Value = i));
            }
            //Thread.Sleep(5000); //Simulate heavy processing
            
            label2.BeginInvoke(new Action(() => label2.Text = "Answer = 53"));
            //label2.Text = "Answer = 53"; //Dummy answer
            button1.BeginInvoke(new Action(() => button1.Enabled = true));
        }
    }
}
