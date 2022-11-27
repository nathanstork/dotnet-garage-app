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
    public partial class RemoveJobForm : Form
    {
        private Job SelectedJob;
        private Action Callback;

        internal RemoveJobForm(Job selectedJob, Action? callback = null)
        {
            SelectedJob = selectedJob;
            Callback = callback;

            InitializeComponent();
        }

        private void close()
        {
            this.Hide();
            this.Close();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Employees employees = Employees.GetInstance();
            employees.CurrentUser.Garage.Jobs.Remove(SelectedJob);

            Console.WriteLine(employees.CurrentUser.Garage.Jobs.Count);

            if (Callback != null)
            {
                Callback();
            }

            Console.WriteLine(employees.CurrentUser.Garage.Jobs.Count);

            close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            close();
        }

        
    }
}
