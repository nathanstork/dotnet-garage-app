using GarageApp.Forms;

namespace GarageApp
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void CloseForm()
        {
            this.Hide();
            this.Close();
        }

        private void SubmitForm()
        {
            Employees employees = Employees.GetInstance();

            try
            {
                employees.LogIn(userTextBox.Text.ToLower(), passTextBox.Text);

                this.Hide();

                if (employees.CurrentUser.GetType().Name == "Manager")
                {
                    ManagerForm managerForm = new ManagerForm("Logged in as " + employees.CurrentUser.Name);
                    managerForm.ShowDialog();
                }
                else
                {
                    MechanicForm mechanicForm = new MechanicForm("Logged in as " + employees.CurrentUser.Name);
                    mechanicForm.ShowDialog();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                errorLabel.Text = ex.Message;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }

        private void userTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitForm();

                e.SuppressKeyPress = true; // To supress "ding" sound
            }
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void passTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SubmitForm();

                e.SuppressKeyPress = true; // To supress "ding" sound
            }
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }
    }
}
