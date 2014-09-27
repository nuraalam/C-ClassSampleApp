using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
       
        public double Add(double firstNumber, double seccondNumber)
        {
            return firstNumber + seccondNumber;
        }

        public double Subtract(double firstNumber, double seccondNumber)
        {
            return firstNumber - seccondNumber;   
        }

        public double Multiply(double firstNumber, double seccondNumber)
        {
            return firstNumber * seccondNumber;    
        }

        public double Division(double firstNumber, double seccondNumber)
        {
            return firstNumber / seccondNumber;    
        }
    }
}
