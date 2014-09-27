using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWalktrough1
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string GetMyFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }

        public string GetMyReverseName()
        {
            string reverseName = "";
            string fullName = GetMyFullName();
            for (int index = fullName.Length - 1; index >= 0; index--)
            {
                reverseName += fullName[index];
            }
            return reverseName;
        }

    }
}
