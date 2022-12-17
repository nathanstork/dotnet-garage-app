using GarageApp.Contracts;
using GarageApp.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageApp.Forms
{
    public partial class ContractForm : Form
    {
        private Mechanic Employee;

        private Action Callback;

        internal ContractForm(Mechanic mechanic, Action? callback = null)
        {
            Employee = mechanic;
            Callback = callback;

            InitializeComponent();

            if (mechanic.Contract.GetType().Name == "WeeklyContract")
            {
                weeklyRadioButton.Select();
            }

            hoursNumericUpDown.Value = mechanic.Contract.Hours;
            salaryNumericUpDown.Value = mechanic.Contract.Salary;
        }

        private void SubmitForm()
        {
            int salary = Convert.ToInt32(salaryNumericUpDown.Value);
            int hours = Convert.ToInt32(hoursNumericUpDown.Value);

            if (monthlyRadioButton.Checked)
            {
                Employee.Contract = new MonthlyContract(salary, hours);
            }
            else
            {
                Employee.Contract = new WeeklyContract(salary, hours);
            }
        }

        private void ShowWarningMessageBox(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (hoursNumericUpDown.Value == 0)
            {
                ShowWarningMessageBox("The contract's hours must be greater than zero.", "Error");
                return;
            }
            if (salaryNumericUpDown.Value == 0)
            {
                ShowWarningMessageBox("The contract's salary must be greater than zero.", "Error");
                return;
            }

            SubmitForm();

            if (Callback != null) Callback();

            this.Hide();
            this.Close();
        }

        private void monthlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (monthlyRadioButton.Checked)
            {
                hoursLabel.Text = "Monthly hours";
                salaryLabel.Text = "Monthly salary";
            }
        }

        private void weeklyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (weeklyRadioButton.Checked)
            {
                hoursLabel.Text = "Weekly hours";
                salaryLabel.Text = "Weekly salary";
            }
        }
    }
}

