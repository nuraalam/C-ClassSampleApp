using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account
{
    public partial class AccountUI : Form
    {
        public AccountUI()
        {
            InitializeComponent();
        }
       CustomerAcount anAccount = new CustomerAcount();
        private void createButton_Click(object sender, EventArgs e)
        {
            if ((nameTextBox.Text != "") || (accountNumberTextBox.Text != ""))
            {
                string name = nameTextBox.Text;
                string accountNumber = accountNumberTextBox.Text;
                anAccount.SetName(name);
                anAccount.SetAccountNumber(accountNumber);
                nameTextBox.Text = "";
                accountNumberTextBox.Text = "";
                MessageBox.Show(anAccount.GetAccountNumber()+ ",Your Account is created. Your account Number is   " +
                                anAccount.GetAccountNumber());
            }
            else
            {
                MessageBox.Show("Entry is missing");
            }

        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            if (amounTextBox.Text != "")
            {
                double amount = Convert.ToDouble(amounTextBox.Text);
                anAccount.Deposit(amount);
                amounTextBox.Text = "";
                MessageBox.Show(amount + "Tk has been deposited in your account");
            }
            else
            {
                MessageBox.Show("No money has been deposited");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (amounTextBox.Text != "")
            {
                double amount = Convert.ToDouble(amounTextBox.Text);
                anAccount.Withdraw(amount);
                amounTextBox.Text = "";
                MessageBox.Show(amount + "Tk has been withdrawn in your account");
            }
            else
            {
                MessageBox.Show("No money has been withdrawn");
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            string msg = anAccount.GetName() + ", your current account balance is    " + anAccount.GetBalane();
            MessageBox.Show(msg);
        }
    }
}
