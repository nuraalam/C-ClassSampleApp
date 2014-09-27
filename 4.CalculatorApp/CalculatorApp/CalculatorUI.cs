using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorUI : Form
    {
       

        public CalculatorUI()
        {
            InitializeComponent();
        }
        private Calculator aCalculator;
        private double firstNumber;
        private double seccondNumber;

        private void addButton_Click(object sender, EventArgs e)
        {
            aCalculator = new Calculator();
            if ((firstNumberTextBox.Text !="")
                || (seccondNumberTextBox.Text != ""))
            {
            
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            seccondNumber = Convert.ToDouble(seccondNumberTextBox.Text);
            resultTextBox.Text = aCalculator.Add(firstNumber, seccondNumber).ToString();
            }
            else
            {
                MessageBox.Show("Entry Missing");
            }


    }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            aCalculator = new Calculator();
            if ((firstNumberTextBox.Text != "")
                || (seccondNumberTextBox.Text != ""))
            {

                firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                seccondNumber = Convert.ToDouble(seccondNumberTextBox.Text);
                resultTextBox.Text = aCalculator.Subtract(firstNumber, seccondNumber).ToString();
            }
            else
            {
                MessageBox.Show("Entry Missing");
            }

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            aCalculator = new Calculator();
            if ((firstNumberTextBox.Text != "")
                || (seccondNumberTextBox.Text != ""))
            {

                firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                seccondNumber = Convert.ToDouble(seccondNumberTextBox.Text);
                resultTextBox.Text = aCalculator.Multiply(firstNumber, seccondNumber).ToString();
            }
            else
            {
                MessageBox.Show("Entry Missing");
            }


        }

        private void divistionButton_Click(object sender, EventArgs e)
        {
            aCalculator = new Calculator();
            if ((firstNumberTextBox.Text != "")
                || (seccondNumberTextBox.Text != ""))
            {

                firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                seccondNumber = Convert.ToDouble(seccondNumberTextBox.Text);
                resultTextBox.Text = aCalculator.Division(firstNumber, seccondNumber).ToString();
            }
            else
            {
                MessageBox.Show("Entry Missing");
            }

        }
    }
}
