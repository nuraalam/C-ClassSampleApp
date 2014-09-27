using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SallarCalculatorApp
{
    public partial class SalaryCalculatorUI : Form
    {
        public SalaryCalculatorUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalaryCalculator aCalculator=new SalaryCalculator();
            aCalculator.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            aCalculator.houseRentParcentages = Convert.ToDouble(HouseRentParcentagesTextBox.Text);
            aCalculator.madicaleAllowancesParcentages = Convert.ToDouble(medicalAllowanceParcentagesTextBox.Text);

            MessageBox.Show(employeeNameTextBox.Text+", your salary is  "+aCalculator.CalculateSalary().ToString());
        }
    }
}
