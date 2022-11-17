namespace GarageApp
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void ResetTextBoxes()
        {
            userTextBox.Text = "";
            passTextBox.Text = "";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Employees employees = Employees.GetInstance();
            
            try
            {
                employees.Login(userTextBox.Text, passTextBox.Text);
                // Close current window and open new UI.
            }
            catch(Exception ex)
            {
                errorLabel.Text= ex.Message;
            }
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void AuthenticationForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
