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
    public enum OperationType
    {
        Division,
        Product,
        Substraction,
        Sum,
        None
    }

    public partial class Form1 : Form
    {
        //private List<decimal> _numbersToAdd = new List<decimal>();
        //private List<decimal> _numbersToSub = new List<decimal>();
        //private List<decimal> _numbersToDivide = new List<decimal>();
        //private List<decimal> _numbersToMultiply = new List<decimal>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
        }

        private void number1_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text == "0" ? "1" : string.Concat(resultTextBox.Text, "1");
        }

        private void number2_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text == "0" ? "2" : string.Concat(resultTextBox.Text, "2");
        }

        private void number3_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text == "0" ? "3" : string.Concat(resultTextBox.Text, "3");
        }

        private void number4_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text == "0" ? "4" : string.Concat(resultTextBox.Text, "4");
        }

        private void number5_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text == "0" ? "5" : string.Concat(resultTextBox.Text, "5");
        }

        private void number6_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text == "0" ? "6" : string.Concat(resultTextBox.Text, "6");
        }

        private void number7_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text == "0" ? "7" : string.Concat(resultTextBox.Text, "7");
        }

        private void number8_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text == "0" ? "8" : string.Concat(resultTextBox.Text, "8");
        }

        private void number9_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text == "0" ? "9" : string.Concat(resultTextBox.Text, "9");
        }

        private void zero_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text == "0" ? "0" : string.Concat(resultTextBox.Text, "0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = 
                resultTextBox.Text.Length == 1 ? "0" : resultTextBox.Text.Remove(resultTextBox.Text.Length - 1);
        }

        private decimal _resultNumber = 0m;
        private decimal _prevNumber = 0m;
        private OperationType _prevOperationType = OperationType.Sum;

        private void exectOperation()
        {
            if (_prevOperationType == OperationType.Sum)
            {
                _resultNumber += _prevNumber;
            }
            else if(_prevOperationType == OperationType.Substraction)
            {
                _resultNumber -= _prevNumber;
            }
            else if (_prevOperationType == OperationType.Product)
            {
                _resultNumber += _prevNumber * decimal.Parse(resultTextBox.Text); ;
            }
            else if (_prevOperationType == OperationType.Division)
            {
                _resultNumber += _prevNumber / decimal.Parse(resultTextBox.Text);
            }
        }

        private void addOperation_Click(object sender, EventArgs e)
        {
            _prevNumber = decimal.Parse(resultTextBox.Text);
            exectOperation();

            calculationParts.Text = string.Concat(calculationParts.Text, resultTextBox.Text, " +");
            resultTextBox.Text = _resultNumber.ToString();
            _prevOperationType = OperationType.Sum;
        }

        private void subOperation_Click(object sender, EventArgs e)
        {
            _prevNumber = decimal.Parse(resultTextBox.Text);
            if (_prevOperationType != OperationType.None)
            {
                exectOperation();
            }

            calculationParts.Text = string.Concat(calculationParts.Text, resultTextBox.Text, " -");
            resultTextBox.Text = _resultNumber.ToString();
            _prevOperationType = OperationType.Substraction;
        }

        private void multiplyOperation_Click(object sender, EventArgs e)
        {
            _prevNumber = decimal.Parse(resultTextBox.Text);
            if (_prevOperationType != OperationType.None)
            {
                exectOperation();
            }

            calculationParts.Text = string.Concat(calculationParts.Text, resultTextBox.Text, " *");
            resultTextBox.Text = _resultNumber.ToString();
            _prevOperationType = OperationType.Product;
        }

        private void devideOperation_Click(object sender, EventArgs e)
        {
            if (_prevOperationType != OperationType.None)
            {
                exectOperation();
            }

            _prevNumber = decimal.Parse(resultTextBox.Text);
            calculationParts.Text = string.Concat(calculationParts.Text, resultTextBox.Text, " /");
            resultTextBox.Text = _resultNumber.ToString();
            _prevOperationType = OperationType.Division;
        }
    }
}
