using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class CustomerAcount
    {
        private string name;
        private string accountNumber;
        private double balance;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
        public void SetAccountNumber(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public string GetAccountNumber()
        {
            return this.accountNumber;
        }
        public double GetBalane()
        {
            return this.balance;
        }



        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            balance -= amount;
        }
    }
}
