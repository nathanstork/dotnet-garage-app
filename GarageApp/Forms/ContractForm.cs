using GarageApp.Contracts;

namespace GarageApp.Forms
{
    public partial class ContractForm : Form
    {
        private User Employee;

        private Action Callback;

        internal ContractForm(User user, Action? callback = null)
        {
            Employee = user;
            Callback = callback;

            InitializeComponent();

            if (user.Contract.GetType().Name == "WeeklyContract")
            {
                weeklyRadioButton.Select();
            }

            salaryNumericUpDown.Value = user.Contract.Salary;
            hoursNumericUpDown.Value = user.Contract.Hours;
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
            if (salaryNumericUpDown.Value == 0)
            {
                ShowWarningMessageBox("The contract's salary must be greater than zero.", "Error");
                return;
            }
            if (hoursNumericUpDown.Value == 0)
            {
                ShowWarningMessageBox("The contract's hours must be greater than zero.", "Error");
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
                salaryLabel.Text = "Monthly salary";
                hoursLabel.Text = "Monthly hours";
            }
        }

        private void weeklyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (weeklyRadioButton.Checked)
            {
                salaryLabel.Text = "Weekly salary";
                hoursLabel.Text = "Weekly hours";
            }
        }
    }
}

