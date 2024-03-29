﻿using System.Text.RegularExpressions;

namespace GarageApp.Forms
{
    public partial class MechanicForm : Form
    {
        readonly Employees Entry;

        Job SelectedJob;

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
            List<Job> jobs = Entry.CurrentUser.Jobs;

            BindingSource jobsBinding = new BindingSource();
            jobsBinding.DataSource = jobs;

            jobsListBox.DataSource = jobsBinding;
        }

        private void SetupForm()
        {
            foreach (JobStatus status in Enum.GetValues(typeof(JobStatus)))
            {
                if (status != JobStatus.Unassigned)
                {
                    statusComboBox.Items.Add(Regex.Replace(status.ToString(), "([a-z])([A-Z])", "$1 $2"));
                }
            }

            SetJobs();

            SelectedJob = jobsListBox.SelectedValue as Job;
        }

        // Save employees data before window closes
        private void MechanicForm_FormClosing(object sender, FormClosingEventArgs e)
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
            string jobStatus = Regex.Replace(job.Status.ToString(), "([a-z])([A-Z])", "$1 $2");

            statusComboBox.SelectedIndex = statusComboBox.FindString(jobStatus);
            jobDateLabel.Text = job.Date;
            priceTextBox.Text = job.Price.ToString();
            descriptionTextBox.Text = job.Description;
            notesTextBox.Text = job.Notes;

            carPlateTextBox.Text = job.Car.Plate;
            carBrandTextBox.Text = job.Car.Brand;
            carModelTextBox.Text = job.Car.Model;
            carColorTextBox.Text = job.Car.Color.ToString();

            customerNameTextBox.Text = job.Customer.Name;
            customerAddressTextBox.Text = job.Customer.Address;
            customerEmailTextBox.Text = job.Customer.Email;
            customerPhoneTextBox.Text = job.Customer.Phone;
        }

        private void ResetJobFields()
        {
            jobDateLabel.Text = string.Empty;
            priceTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            notesTextBox.Text = string.Empty;

            carPlateTextBox.Text = string.Empty;
            carBrandTextBox.Text = string.Empty;
            carModelTextBox.Text = string.Empty;
            carColorTextBox.Text = string.Empty;

            customerNameTextBox.Text = string.Empty;
            customerAddressTextBox.Text = string.Empty;
            customerEmailTextBox.Text = string.Empty;
            customerPhoneTextBox.Text = string.Empty;

            statusComboBox.SelectedIndex = -1;

            statusComboBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            notesTextBox.Enabled = false;
        }

        private void jobsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (jobsListBox.SelectedIndex == -1)
            {
                ResetJobFields();
                return;
            }

            statusComboBox.Enabled = true;
            descriptionTextBox.Enabled = true;
            notesTextBox.Enabled = true;

            SelectedJob = jobsListBox.SelectedItem as Job;
            if (SelectedJob != null) UpdateJobDetails(SelectedJob);
        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            JobForm jobForm = new JobForm(SetJobs);
            jobForm.ShowDialog();
        }

        private void statusComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Enum.TryParse(statusComboBox.Text.Replace(" ", ""), out JobStatus status);
                
            if (status == JobStatus.Completed || status == JobStatus.UnableToComplete)
            {
                JobCompletionForm completionForm = new JobCompletionForm(
                    SelectedJob,
                    Entry.CurrentUser,
                    new Action(() =>
                    {
                        SelectedJob.Status = status;

                        Entry.CurrentUser.Jobs.Remove(SelectedJob);

                        SetJobs();

                        if (jobsListBox.Items.Count > 0)
                        {
                            UpdateJobDetails(SelectedJob);
                        }
                        else
                        {
                            ResetJobFields();
                        }
                    }),
                    new Action(() =>
                    {
                        // Reset job status to it's current value
                        string jobStatus = Regex.Replace(SelectedJob.Status.ToString(), "([a-z])([A-Z])", "$1 $2");

                        statusComboBox.SelectedIndex = statusComboBox.FindString(jobStatus);
                    })
                );

                completionForm.ShowDialog();                
            }
            else
            {
                if (SelectedJob != null) SelectedJob.Status = status;
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedJob != null) SelectedJob.Description = descriptionTextBox.Text;
        }

        private void notesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedJob != null) SelectedJob.Notes = notesTextBox.Text;
        }
    }
}
