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

        private void submitButton_Click(object sender, EventArgs e)
        {
            Employees employees = Employees.GetInstance();
            employees.CurrentUser.Garage.Jobs.Add(new Job(
                descriptionTextBox.Text,
                dateTimePicker.Value.ToString(),
                Convert.ToInt32(priceNumericUpDown.Value),
                new Car("", "", "", CarColor.Grey),
                new Customer("", "", "", "")
            ));

            if (Callback != null)
            {
                Callback();
            }

            Console.WriteLine(employees.CurrentUser.Garage.Jobs.Count);

            this.Hide();
            this.Close();
        }
    }
}
