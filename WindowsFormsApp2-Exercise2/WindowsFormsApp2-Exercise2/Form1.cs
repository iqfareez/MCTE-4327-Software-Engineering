using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_Exercise2
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

        private void operatorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            try
            {
                double number1 = double.Parse(operandInput1.Text);
                double number2 = double.Parse(operandInput2.Text);

                double output = 0;

                switch (operatorComboBox.SelectedIndex)
                {
                    case 0:
                        output = number1 + number2;
                        break;
                    case 1:
                        output = number1 - number2;
                        break;
                    case 2:
                        output = number1 / number2;
                        break;
                    case 3:
                        output = number1 * number2;
                        break;
                    default:
                        break;
                }
                answerLabel.Text = "Answer: " + output.ToString();
            }
            catch
            {
                answerLabel.Text = "Answer: N/A";
            }
        }

        private void operandInput1_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void operandInput2_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void answerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
