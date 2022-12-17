using GarageApp.Contracts;
using GarageApp.Users;

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

        private void AddMechanic()
        {
            Contract contract = new MonthlyContract(Convert.ToInt32(salaryNumericUpDown.Value), Convert.ToInt32(hoursNumericUpDown.Value));

            Entry.CurrentUser.Mechanics.Add(
                new Mechanic(mechanicUsernameTextBox.Text, mechanicPasswordTextbox.Text, mechanicNameTextBox.Text, mechanicAddressTextBox.Text, contract)
            );

            Console.WriteLine("Added mechanic!");
        }

        private void AddManager()
        {
            Entry.CurrentUser.Managers.Add(
                new Manager(managerUsernameTextBox.Text, managerPasswordTextBox.Text, managerNameTextBox.Text, managerAddressTextBox.Text, Entry.Mechanics)
            );
        }

        private void ShowWarningMessageBox(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void HandleFinish()
        {
            if (Callback != null) Callback();

            this.Hide();
            this.Close();
        }

        private bool HandleGeneralErrors()
        {
            if (managerUsernameTextBox.Text == string.Empty)
            {
                ShowWarningMessageBox("The username can not be empty.", "Error");
                return true;
            }
            if (managerPasswordTextBox.Text == string.Empty)
            {
                ShowWarningMessageBox("The password can not be empty.", "Error");
                return true;
            }
            if (managerRepeatPasswordTextBox.Text == string.Empty)
            {
                ShowWarningMessageBox("You have to repeat the password.", "Error");
                return true;
            }
            if (managerPasswordTextBox.Text != managerRepeatPasswordTextBox.Text)
            {
                ShowWarningMessageBox("The provided passwords are not the same.", "Error");
                return true;
            }
            if (managerNameTextBox.Text == string.Empty)
            {
                ShowWarningMessageBox("The manager's name can not be empty.", "Error");
                return true;
            }
            if (managerAddressTextBox.Text == string.Empty)
            {
                ShowWarningMessageBox("The manager's address can not be empty.", "Error");
                return true;
            }

            return false;
        }

        private void HandleManagerErrors()
        {
            if (!HandleGeneralErrors())
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

                AddMechanic();

                HandleFinish();
            }
        }

        private void HandleMechanicErrors()
        {
            if (!HandleGeneralErrors())
            {
                AddManager();

                HandleFinish();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (employeeTabControl.TabIndex == 0)
            {
                HandleMechanicErrors();
            }
            else
            {
                HandleManagerErrors();
            }
        }

        private void mechanicUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            managerUsernameTextBox.Text = mechanicUsernameTextBox.Text;
        }

        private void mechanicPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            managerPasswordTextBox.Text = mechanicPasswordTextbox.Text;
        }

        private void mechanicRepeatPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            managerRepeatPasswordTextBox.Text = mechanicRepeatPasswordTextbox.Text;
        }

        private void mechanicNameTextBox_TextChanged(object sender, EventArgs e)
        {
            managerNameTextBox.Text = mechanicNameTextBox.Text;
        }

        private void mechanicAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            managerAddressTextBox.Text = mechanicAddressTextBox.Text;
        }

        private void managerUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            mechanicUsernameTextBox.Text = managerUsernameTextBox.Text;
        }

        private void managerPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            mechanicPasswordTextbox.Text = managerPasswordTextBox.Text;
        }

        private void managerRepeatPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            mechanicRepeatPasswordTextbox.Text = managerRepeatPasswordTextBox.Text;
        }

        private void managerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            mechanicNameTextBox.Text = managerNameTextBox.Text;
        }

        private void managerAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            mechanicAddressTextBox.Text = managerAddressTextBox.Text;
        }
    }
}
