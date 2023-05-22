using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Parallel_Processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Example value to check: 999999937
            long number = long.Parse(textBox1.Text); //Without input validity check
            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            bool is_prime = Prime_Paralel_Class(number);
            sw.Stop();
            if (is_prime)
            {
                MessageBox.Show("It is a prime number.\n\nTime taken (ms) = " + sw.ElapsedMilliseconds.ToString());
            }
            else
            {
                MessageBox.Show("It is not prime number.\n\nTime taken (ms) = " + sw.ElapsedMilliseconds.ToString());
            }
        }

        private bool Prime(long number)
        {
            //Not the most efficient algorithm
            for (long i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private bool PrimeParallel(long number)
        {
            Task<bool> Task1 = Task.Run(() =>
            {
                for (long i = 2; i < number / 8; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            });
            Task<bool> Task2 = Task.Run(() =>
            {
                for (long i = number / 8; i < number / 4; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            });
            Task<bool> Task3 = Task.Run(() =>
            {
                for (long i = number / 4; i < 3 * number / 8; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            });
            Task<bool> Task4 = Task.Run(() =>
            {
                for (long i = 3 * number / 8; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            });
            return Task1.Result && Task2.Result && Task3.Result && Task4.Result;
        }

        private bool Prime_Paralel_Class(long number)
        {
            bool prime = true;
            Parallel.For(2, number / 2 + 1, i =>
            {
                if (number % i == 0)
                {
                    prime = false; //The loop can be exited as well
                }
            });
            return prime;
        }

    }
}
