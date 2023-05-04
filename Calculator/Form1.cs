using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string num1 = string.Empty;
        string num2 = string.Empty;
        char operation;
        double answer = 0.0;
        int numCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            input = string.Empty;
            num1 = string.Empty;
            num2 = string.Empty;
            operation = 'N';
            numCount = 0;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
                input += 1;
                richTextBox1.Text = input;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            input += 2;
            richTextBox1.Text = input;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            input += 3;
            richTextBox1.Text = input;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            input += 4;
            richTextBox1.Text = input;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            input += 5;
            richTextBox1.Text = input;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            input += 6;
            richTextBox1.Text = input;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            input += 7;
            richTextBox1.Text = input;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            input += 8;
            richTextBox1.Text = input;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            input += 9;
            richTextBox1.Text = input;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            input += 0;
            richTextBox1.Text = input;
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            bool empty = false;
            empty = (richTextBox1.Text == "0")||(richTextBox1.Text == "");
            if (empty)
            {
                richTextBox1.Text = "0";
            }
            else 
            {
                double nInput = double.Parse(richTextBox1.Text);
                double signNInput = nInput * -1;
                string sSignNInput = Convert.ToString(signNInput);
                input = sSignNInput;
                richTextBox1.Text = input;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            numCount++;
            if (numCount >= 2)
            {
                Calculate_Click(sender, e);
            }
            num1 = input;
            operation = 'x';
            input = string.Empty;
        }


        
        private void PlusButton_Click(object sender, EventArgs e)
        {
            numCount++;
            if (numCount >= 2)
            {
                Calculate_Click(sender, e);
            }
            num1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void showInput()
        {
            richTextBox1.Text = "";
            richTextBox1.Text = input;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            num2 = input;
            double first, second;
            double.TryParse(num1, out first);
            double.TryParse(num2, out second);

            if (numCount > 2)
            {
                first = answer;
            }

            if (operation == '+')
            {
                answer = first + second;
                richTextBox1.Text = answer.ToString();
            }

            if (operation == '-')
            {
                answer = first - second;
                richTextBox1.Text = answer.ToString();
            }

            if (operation == '/')
            {
                if (second != 0)
                {
                    answer = first / second;
                    richTextBox1.Text = answer.ToString();
                }
                else
                {
                    richTextBox1.Text = "Err";
                }
            }

            if (operation == 'x')
            {
                if (second == 0)
                {
                    answer = first;
                }
                if (first == 0)
                {
                    answer = second;
                }
                if (first != 0 && second != 0)
                {
                    answer = first * second;
                }
                richTextBox1.Text = answer.ToString();
            }
            operation = 'N';
            numCount++;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            numCount++;
            if (numCount >= 2)
            {
                Calculate_Click(sender, e);
            }
            num1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void DivideButton_Click_1(object sender, EventArgs e)
        {
            numCount++;
            if (numCount >= 2)
            {
                Calculate_Click(sender, e);
            }
            num1 = input;
            operation = '/';
            input = string.Empty;
        }
    }
}
