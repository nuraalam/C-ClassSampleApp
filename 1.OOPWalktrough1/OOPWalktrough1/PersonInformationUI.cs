using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPWalktrough1
{
    public partial class PersonInformationUI : Form
    {
        public PersonInformationUI()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Person personObject = new Person();
            personObject.firstName = textBoxFirstName.Text;
            personObject.middleName = textBoxMiddleName.Text;
            personObject.lastName = textBoxLastName.Text;

            textBoxFullName.Text = personObject.GetMyFullName();
            textBoxReverseName.Text = personObject.GetMyReverseName();

        }
    }
}
