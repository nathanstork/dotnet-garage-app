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
        private Action Callback;

        public ContractForm(Action? callback = null)
        {
            Callback = callback;

            InitializeComponent();
        }

        private void SubmitForm()
        {
            Employees employees = Employees.GetInstance();

            if (Callback != null)
            {
                Callback();
            }
        }

        private void ShowWarningMessageBox(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            /*if (descriptionTextBox.Text.Trim() == string.Empty)
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
            }*/

            SubmitForm();

            this.Hide();
            this.Close();
        }
    }
}

