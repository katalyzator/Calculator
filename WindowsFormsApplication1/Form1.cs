using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private double firstNum = 0;
        private double secondNum = 0;
        private double result = 0;
        private int operatorType = (int)MathOperations.NoOperator;

        public enum MathOperations
        {
            NoOperator = 0,
            Add = 1,
            Minus = 2, 
            Divide = 3,
            Multiply = 4,
            Percentage = 5,
            Radikal = 6,
            Sin = 7,
            Cos = 8,
            Tan = 9,
            Degree = 10,   
            Factorial = 11,
            Log = 12,
            Exp = 13,
            Mod = 14
        }


        private void OneButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "1"; 
        }

        private void DigitBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }
            DisplayTextBox.Text += btn.Text;
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (!DisplayTextBox.Text.Contains('.'))
            {
                DisplayTextBox.Text += ".";
            }
           
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            if (!DisplayTextBox.Text.Contains('-'))
            {
                DisplayTextBox.Text = "-" + DisplayTextBox.Text;
            }
            else
            {
                DisplayTextBox.Text = DisplayTextBox.Text.Trim('-');
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Divide);
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Add);
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Minus);
        }
        
        private void SaveValueAndOperatorType(int operation)
        {
            operatorType = operation;
            firstNum = Convert.ToDouble(DisplayTextBox.Text);
            DisplayTextBox.Text = "0";

        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Multiply);
        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Percentage);
        }

        private void FacButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Factorial);
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            secondNum = Convert.ToDouble(DisplayTextBox.Text);

            switch (operatorType)
            {
                case (int)MathOperations.Add:
                    result = firstNum + secondNum;
                    break;
                case (int)MathOperations.Minus:
                    result = firstNum - secondNum;
                    break;
                case (int)MathOperations.Divide:
                    result = firstNum / secondNum;
                    break;
                case (int)MathOperations.Multiply:
                    result = firstNum * secondNum;
                    break;
                case (int)MathOperations.Percentage:
                    result = (firstNum / secondNum) * 100;
                    break;
                case (int)MathOperations.Factorial:
                    result = 1;
                    for (int i=1; i<=firstNum; i++)
                    {
                        result = result * i;
                    }
                    break;
                case (int)MathOperations.Sin:
                    result = Math.Sin(firstNum);
                    break;
                case (int)MathOperations.Radikal:
                    result = Math.Sqrt(firstNum);
                    break;
                case (int)MathOperations.Cos:
                    result = Math.Cos(firstNum);
                    break;
                case (int)MathOperations.Tan:
                    result = Math.Tan(firstNum);
                    break;
                case (int)MathOperations.Degree:
                    result = Math.Pow(firstNum, 2);
                    break;
                case (int)MathOperations.Log:
                    result = Math.Log10(firstNum);
                    break;
                case (int)MathOperations.Exp:
                    result = Math.Exp(firstNum);
                    break;
                case (int)MathOperations.Mod:
                    result = firstNum % secondNum;
                    break;
                }

            DisplayTextBox.Text = result.ToString();
        }

        private void ClearEntryButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
            firstNum = 0;
            secondNum = 0;
            result = 0;
            operatorType = (int)MathOperations.NoOperator;
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Sin);
        }

                private void RadikalButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Radikal);
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Cos);
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Tan);
        }

        private void CotButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Degree);
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Log);
        }

        private void ExpButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Exp);
        }

        private void ModButton_Click(object sender, EventArgs e)
        {
            SaveValueAndOperatorType((int)MathOperations.Mod);
        }
    }
}
