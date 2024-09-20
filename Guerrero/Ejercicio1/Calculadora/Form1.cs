using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora.models;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private Calculator calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            PerformOperation("+");
        }


        private void PerformOperation(string operation)
        {
            try
            {
                double num1 = Convert.ToDouble(tbNum1.Text);
                double num2 = Convert.ToDouble(tbNum2.Text);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = calculator.Sum(num1, num2);
                        break;
                    case "-":
                        result = calculator.Subtract(num1, num2);
                        break;
                    case "x":
                        result = calculator.Multiply(num1, num2);
                        break;
                    case "/":
                        result = calculator.Divide(num1, num2);
                        break;
                    default:
                        MessageBox.Show("Invalid operation.");
                        return;
                }

                lblResult.Text = "Result: " + result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            PerformOperation("-");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            PerformOperation("x");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformOperation("/");
        }
    }
}
