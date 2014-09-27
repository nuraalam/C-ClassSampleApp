using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SallarCalculatorApp
{
    public class SalaryCalculator
    {
        public double basicAmount;
        public double houseRentParcentages;
        public double madicaleAllowancesParcentages;

        public double CalculateSalary()
        {
            return basicAmount + (basicAmount*houseRentParcentages/100) +
                   (basicAmount*madicaleAllowancesParcentages/100);
        }
    }
}
