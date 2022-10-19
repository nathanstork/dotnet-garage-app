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
            Registry registry = Registry.GetInstance();
            List<Manager> managers = registry.GetManagers();

            Manager? manager = null;
            try
            {
                manager = managers.Find(manager => manager.Username == userTextBox.Text);

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
                        ResetTextBoxes();
                        errorLabel.Text = "Incorrect password";
                    }
                }
            }
            catch (NullReferenceException)
            {
                ResetTextBoxes();
                errorLabel.Text = "Unknown username";
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
