using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ii.PersonApp
{
    class Person
    {
        public string firstName;
        public string lastName;
        public string middleName;

        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }

        public string GetReverseName()
        {
            string input = GetFullName();
            string output = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
            output += input[i];
            }
            return output;
        }

    }
}
