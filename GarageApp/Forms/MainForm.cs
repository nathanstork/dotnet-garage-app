using GarageApp.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageApp.Forms
{
    public partial class MechanicForm : Form
    {
        readonly Employees Entry;

        public MechanicForm(string? label)
        {
            InitializeComponent();

            Entry = Employees.GetInstance();

            if (label != null)
            {
                testLabel.Text = label;
            }

            SetupForm();
        }

        private void SetupForm()
        {
            Console.WriteLine(Entry.CurrentUser.GetType().Name);

            List<Job> jobs = Entry.CurrentUser.Garage.GetJobs();
            jobs.ForEach(job =>
            {
                jobsListBox.Items.Add(job.Description);
            });

            if (Entry.CurrentUser.GetType().Name == "Manager")
            {

                Console.WriteLine(Entry.CurrentUser.GetMechanics());

                List<Mechanic> mechanics = Entry.CurrentUser.GetMechanics();
                mechanics.ForEach(mechanic =>
                {
                    mechanicsListBox.Items.Add(mechanic.Name);
                });
            }
        }

        // Save employees data before window closes
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Entry.SaveData();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Entry.LogOut();

            AuthenticationForm authForm = new AuthenticationForm();
            this.Hide();
            authForm.ShowDialog();
            this.Close();
        }

        private void mechanicsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
