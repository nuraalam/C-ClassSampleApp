using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refrigerator_Management_App
{
    public partial class RefrigeratorManagementAppUI : Form
    {
        public RefrigeratorManagementAppUI()
        {
            InitializeComponent();
        }
        RefrigeratorManager aRefrigeratorManager = new RefrigeratorManager();
        private void saveButton_Click(object sender, EventArgs e)
        {

            aRefrigeratorManager.RefrigeratorMaximumWeightHolder = Convert.ToDouble(maximumWeightTextBox.Text);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            aRefrigeratorManager.NumberOfUnit = Convert.ToInt32(numberOfUnitTextBox.Text);
            aRefrigeratorManager.WeightPerUnit = Convert.ToDouble(weightPerUnitTextBox.Text);
            if (aRefrigeratorManager.RemainingWeight >= 0)
            {
                currentWeightTextBox.Text = aRefrigeratorManager.CurrentWeight.ToString();
                remainingWeightTextBox.Text = aRefrigeratorManager.RemainingWeight.ToString();
            }
            else
            {
                MessageBox.Show("Your given amount can’t be entered because it will be over flown.");
            }
        }

    }
}
