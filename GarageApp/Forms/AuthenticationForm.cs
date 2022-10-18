using GarageApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

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
            Console.WriteLine(userTextBox.Text);
            Console.WriteLine(passTextBox.Text);

            Registry registry = Registry.GetInstance();
            List<Manager> managers = registry.GetManagers();

            Manager manager = managers.FirstOrDefault(manager => manager.Username == userTextBox.Text);

            if (manager == null)
            {
                ResetTextBoxes();
                return;
            }

            Console.WriteLine(manager.Id);
            Console.WriteLine(manager.Username);
            Console.WriteLine(manager.Password);

            if (manager.Username == userTextBox.Text)
            {
                if (manager.Password == passTextBox.Text)
                {
                    this.Hide();
                    var testForm = new TestForm("Logged in as manager");
                    testForm.Closed += (s, args) => this.Close();
                    testForm.Show();
                }
                else
                {
                    errorLabel.Text = "Incorrect password";
                    ResetTextBoxes();
                }
            }
            else
            {
                errorLabel.Text = "Unknown username";
                ResetTextBoxes();
            }
        }

        private void mechanicButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var testForm = new TestForm("Logged in as mechanic");
            testForm.Closed += (s, args) => this.Close();
            testForm.Show();
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
    }
}
