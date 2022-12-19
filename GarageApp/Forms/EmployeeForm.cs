using GarageApp.Contracts;
using GarageApp.Users;
using System.Data;

namespace GarageApp.Forms
{
    public partial class EmployeeForm : Form
    {
        Employees Entry;
        Action Callback;

        public EmployeeForm(Action? callback = null)
        {
            Entry = Employees.GetInstance();

            Callback = callback;

            InitializeComponent();
        }

        private void ShowWarningMessageBox(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == string.Empty)
            {
                ShowWarningMessageBox("The username can not be empty.", "Error");
                return;
            }
            if (usernameTextBox.Text.ToLower() == "admin")
            {
                ShowWarningMessageBox("The username can not be 'Admin'.", "Error");
                return;
            }

            // Check if username is unique
            bool unique = true;
            for (int i = 0; i < Entry.Mechanics.Count; i++)
            {
                if (Entry.Mechanics[i].Username == usernameTextBox.Text.ToLower())
                {
                    unique = false;
                    break;
                }
            }
            if (unique)
            {
                for (int i = 0; i < Entry.Managers.Count; i++)
                {
                    if (Entry.Managers[i].Username == usernameTextBox.Text.ToLower())
                    {
                        unique = false;
                        break;
                    }
                }
            }
            if (!unique)
            {
                ShowWarningMessageBox("This username is already taken.", "Error");
                return;
            }

            if (passwordTextBox.Text == string.Empty)
            {
                ShowWarningMessageBox("The password can not be empty.", "Error");
                return;
            }
            if (repeatPasswordTextBox.Text == string.Empty)
            {
                ShowWarningMessageBox("You have to repeat the password.", "Error");
                return;
            }
            if (passwordTextBox.Text != repeatPasswordTextBox.Text)
            {
                ShowWarningMessageBox("The provided passwords are not the same.", "Error");
                return;
            }
            if (nameTextBox.Text == string.Empty)
            {
                ShowWarningMessageBox("The name can not be empty.", "Error");
                return;
            }
            if (addressTextBox.Text == string.Empty)
            {
                ShowWarningMessageBox("The address can not be empty.", "Error");
                return;
            }
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

            Contract contract = new MonthlyContract(Convert.ToInt32(salaryNumericUpDown.Value), Convert.ToInt32(hoursNumericUpDown.Value));

            if (mechanicRadioButton.Checked)
            {
                Entry.CurrentUser.Mechanics.Add(
                    new Mechanic(usernameTextBox.Text, passwordTextBox.Text, nameTextBox.Text, addressTextBox.Text, contract)
                );
            }
            else
            {
                Entry.CurrentUser.Managers.Add(
                    new Manager(usernameTextBox.Text, passwordTextBox.Text, nameTextBox.Text, addressTextBox.Text, contract, Entry.Mechanics)
                );
            }

            if (Callback != null) Callback();

            this.Hide();
            this.Close();
        }
    }
}
