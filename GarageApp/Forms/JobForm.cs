namespace GarageApp.Forms
{
    public partial class JobForm : Form
    {
        private Action Callback;

        public JobForm(Action? callback = null)
        {
            Callback = callback;

            InitializeComponent();

            foreach (CarColor color in Enum.GetValues(typeof(CarColor)))
            {
                colorsComboBox.Items.Add(color);
            }
        }

        private void SubmitForm()
        {
            Employees employees = Employees.GetInstance();

            CarColor carColor = (CarColor) Enum.Parse(typeof(CarColor), colorsComboBox.Text.Replace(" ", ""));

            employees.CurrentUser.Garage.Jobs.Add(new Job(
                descriptionTextBox.Text,
                dateTimePicker.Value.ToShortDateString(),
                Convert.ToInt32(priceNumericUpDown.Value),
                new Car(plateTextBox.Text, modelTextBox.Text, brandTextBox.Text, carColor),
                new Customer(nameTextBox.Text, addressTextBox.Text, emailTextBox.Text, phoneTextBox.Text)
            ));

            if (Callback != null) Callback();
        }

        private void ShowWarningMessageBox(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text.Trim() == string.Empty)
            {
                ShowWarningMessageBox("The job's description can not be empty.", "Error");
                return;
            }
            if (priceNumericUpDown.Value == 0)
            {
                ShowWarningMessageBox("The job's price must be greater than zero.", "Error");
                return;
            }

            if (plateTextBox.Text == "")
            {
                ShowWarningMessageBox("The car's plate can not be empty.", "Error");
                return;
            }
            if (brandTextBox.Text == "")
            {
                ShowWarningMessageBox("The car's brand can not be empty.", "Error");
                return;
            }
            if (modelTextBox.Text == "")
            {
                ShowWarningMessageBox("The car's model can not be empty.", "Error");
                return;
            }
            if (colorsComboBox.Text == "")
            {
                ShowWarningMessageBox("The car's color can not be empty.", "Error");
                return;
            }

            if (nameTextBox.Text == "")
            {
                ShowWarningMessageBox("The customers's name can not be empty.", "Error");
                return;
            }
            if (nameTextBox.Text.ToLower() == "admin")
            {
                ShowWarningMessageBox("The customers's name can not be 'Admin'.", "Error");
                return;
            }
            if (addressTextBox.Text == "")
            {
                ShowWarningMessageBox("The customers's address can not be empty.", "Error");
                return;
            }
            if (emailTextBox.Text == "")
            {
                ShowWarningMessageBox("The customers's e-mail can not be empty.", "Error");
                return;
            }
            if (phoneTextBox.Text == "")
            {
                ShowWarningMessageBox("The customers's phone number can not be empty.", "Error");
                return;
            }

            SubmitForm();           

            this.Hide();
            this.Close();
        }
    }
}
