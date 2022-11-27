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
            Entry = Employees.GetInstance();

            InitializeComponent();

            if (label != null)
            {
                userLabel.Text = label;
            }

            SetupForm();
        }

        private void SetJobs()
        {
            jobsListBox.Items.Clear();

            List<Job> jobs = Entry.CurrentUser.Garage.Jobs;
            jobs.ForEach(job =>
            {
                Console.WriteLine(job.Description);
                jobsListBox.Items.Add(job.Description);
            });

            removeJobButton.Enabled = false;
        }

        private void SetupForm()
        {
            SetJobs();

            if (Entry.CurrentUser.Garage.Jobs.Count == 0) removeJobButton.Enabled = false;

            if (Entry.CurrentUser.GetType().Name == "Manager")
            {
                List<Mechanic> mechanics = Entry.CurrentUser.GetMechanics();
                mechanics.ForEach(mechanic =>
                {
                    mechanicsListBox.Items.Add(mechanic.Name);
                });
            }

            foreach (JobStatus status in Enum.GetValues(typeof(JobStatus)))
            {
                jobStatusComboBox.Items.Add(status.ToString());
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

        private void UpdateJobDetails(Job job)
        {
            jobDetailsDateLabel.Text = job.Date;
            jobDescriptionTextBox.Text = job.Description;
            jobPriceTextBox.Text = job.Price.ToString();
            jobStatusComboBox.SelectedIndex = jobStatusComboBox.FindString(job.Status.ToString());
        }

        private void jobsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            removeJobButton.Enabled = true;

            List<Job> jobs = Entry.CurrentUser.Garage.Jobs;
            Job selectedJob = jobs.Find(job => job.Description == jobsListBox.SelectedItem);

            if (selectedJob != null)
            {
                UpdateJobDetails(selectedJob);
            }
            else
            {
                jobDetailsDateLabel.Text = "";
                jobDescriptionTextBox.Text = "";
                jobPriceTextBox.Text = "";
                jobStatusComboBox.SelectedIndex = 0;
            }
        }

        private void mechanicsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Mechanic selectedMechanic = Entry.Mechanics.Find(mechanic => mechanic.Name == mechanicsListBox.SelectedItem);

            if (selectedMechanic != null)
            {
                Console.WriteLine(selectedMechanic.Name);
                Console.WriteLine(selectedMechanic.Address);
                Console.WriteLine(selectedMechanic.Contract);
                Console.WriteLine("----------");
            }
            else
            {
                // Set empty values
            }
        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            JobForm jobForm = new JobForm(SetJobs);
            jobForm.ShowDialog();
        }

        private void removeJobButton_Click(object sender, EventArgs e)
        {
            List<Job> jobs = Entry.CurrentUser.Garage.Jobs;
            Job selectedJob = jobs.Find(job => job.Description == jobsListBox.SelectedItem);

            RemoveJobForm removeJobForm = new RemoveJobForm(selectedJob, SetJobs);
            removeJobForm.ShowDialog();
        }
    }
}
