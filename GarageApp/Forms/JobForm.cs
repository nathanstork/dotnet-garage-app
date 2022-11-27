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
    public partial class JobForm : Form
    {
        private Action Callback;

        public JobForm(Action? callback = null)
        {
            Callback = callback;

            InitializeComponent();
        }

        private void SubmitForm()
        {
            Employees employees = Employees.GetInstance();
            employees.CurrentUser.Garage.Jobs.Add(new Job(
                descriptionTextBox.Text,
                dateTimePicker.Value.ToShortDateString(),
                Convert.ToInt32(priceNumericUpDown.Value),
                new Car("", "", "", CarColor.Grey),
                new Customer("", "", "", "")
            ));

            if (Callback != null)
            {
                Callback();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show(
                    "The job's description can not be empty.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else if (priceNumericUpDown.Value == 0)
            {
                MessageBox.Show(
                    "The job's price must be greater than zero.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            SubmitForm();           

            this.Hide();
            this.Close();
        }
    }
}
