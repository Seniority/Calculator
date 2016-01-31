using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculator
{
    /// <summary>
    /// Calculator app by Anthony Senior.
    /// Created 12.8.2015
    /// </summary>
    
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed) || (Convert.ToDouble(result.Text) == value))
            {
                result.Clear();
            }            

            operation_pressed = false;

            Button b = (Button)sender;

            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                {
                    result.Text += b.Text;
                }                
            }
            else
            {
                result.Text += b.Text;
            }

            equation.Focus();

        }

        private void button5_Click(object sender, EventArgs e) // "CE" Button
        {
            result.Text = "0";
            equation.Focus();
        }

        private void operator_Click(object sender, EventArgs e) //Clicking Operators
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                if (b.Text == "√")
                {
                    result.Text = Math.Sqrt(Double.Parse(result.Text)).ToString();
                }
                else if (b.Text == "x²")
                {
                    result.Text = (Double.Parse(result.Text) * Double.Parse(result.Text)).ToString();
                }
                equal.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else if (b.Text == "√")
            {
                result.Text = Math.Sqrt(Double.Parse(result.Text)).ToString();
                value = Math.Sqrt(Double.Parse(result.Text));
            }
            else if (b.Text == "x²")
            {
                result.Text = (Double.Parse(result.Text) * Double.Parse(result.Text)).ToString();
                value = (Double.Parse(result.Text) * Double.Parse(result.Text));
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }

            equation.Focus();
        }

        private void equalButton_Click(object sender, EventArgs e) //Pressing the "=" button executes certain action depending on the operator
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "×":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "÷":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
            }

            value = Double.Parse(result.Text);
            operation = "";

            equation.Focus();         
        }

        private void button6_Click(object sender, EventArgs e) //"C" button
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
            equation.Focus();
        }

        private void button7_Click(object sender, EventArgs e) // "<-" button to clear the last digit typed
        {
            string str = result.Text;
            int len = str.Length;
            result.Text = "";
            for (int i = 0; i < len - 1; i++)
            {
                result.Text = result.Text + Convert.ToString(str[i]);
            }

            if ((result.Text == "") || (result.Text == "-"))
            {
                result.Text = "0";
            }

            equation.Focus();
        }

        private void button_MouseEnter(object sender, EventArgs e) // Changes button colors as mouse enters/leaves button area
        {
            Button b = (Button)sender;
            b.BackColor = SystemColors.AppWorkspace;
        }

        private void button_MouseLeave(object sender, EventArgs e) // Changes button colors as mouse enters/leaves button area
        {
            Button b = (Button)sender;
            if (b == equal)
            {
                b.BackColor = Color.Tan;
            }
            else
            {
                b.BackColor = Color.White;
            }
        }

        private void button_MouseDown(object sender, MouseEventArgs e) // Changes color when button is pressed
        {
            Button b = (Button)sender;
            b.BackColor = SystemColors.ControlDarkDark;
        }

        private void button_MouseUp(object sender, MouseEventArgs e) // Changes color when button is pressed
        {
            Button b = (Button)sender;
            b.BackColor = SystemColors.AppWorkspace;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) // Converting key presses into button "presses"
        {
            switch (e.KeyChar)
            {
                case '0':
                    zero.PerformClick();
                    break;
                case '1':
                    one.PerformClick();
                    break;
                case '2':
                    two.PerformClick();
                    break;
                case '3':
                    three.PerformClick();
                    break;
                case '4':
                    four.PerformClick();
                    break;
                case '5':
                    five.PerformClick();
                    break;
                case '6':
                    six.PerformClick();
                    break;
                case '7':
                    seven.PerformClick();
                    break;
                case '8':
                    eight.PerformClick();
                    break;
                case '9':
                    nine.PerformClick();
                    break;
                case '+':
                    add.PerformClick();
                    break;
                case '-':
                    sub.PerformClick();
                    break;
                case '*':
                    mult.PerformClick();
                    break;
                case '/':
                    div.PerformClick();
                    break;
                case ((char)Keys.Enter):
                    equal.PerformClick();
                    break;
                case ((char)Keys.Delete):
                    button6.PerformClick();
                    break;
                case ((char)Keys.Back):
                    button7.PerformClick();
                    break;
                default:
                    MessageBox.Show("Invalid Input");
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string about_message = "";
            about_message += "Welcome to the Calculator application by Seniority Labs™\n\n";
            about_message += "This application allows the user to make simple calculations\n";
            about_message += "using the numbers and operators for division, multiplication,\n";
            about_message += "addition, and subtraction. There are also additional functions\n";
            about_message += "which allow the user to do things like find the square root of\n";
            about_message += "a number, square a number, and easily calculate percentages.\n\n";
            about_message += "NOTE: This application is still in development and not all features\n";
            about_message += "may be available for use.\n\n";
            about_message += "Calculator\n";
            about_message += "Version 1.1.1.0\n";
            about_message += "Seniority Labs™";

            MessageBox.Show(about_message, "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
