﻿using GarageApp.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageApp.Forms
{
    public partial class ManagerForm : Form
    {
        readonly Employees Entry;

        public ManagerForm(string? label)
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
            List<Job> jobs = Entry.CurrentUser.Garage.Jobs;

            BindingSource jobsBinding = new BindingSource();
            jobsBinding.DataSource = jobs;

            jobsListBox.DataSource = jobsBinding;
        }

        private void SetupForm()
        {
            List<Mechanic> mechanics = Entry.CurrentUser.Mechanics;

            BindingSource mechanicsBinding = new BindingSource();
            mechanicsBinding.DataSource = mechanics;

            mechanicsListBox.DataSource = mechanicsBinding;

            foreach (JobStatus status in Enum.GetValues(typeof(JobStatus)))
            {
                jobStatusComboBox.Items.Add(Regex.Replace(status.ToString(), "([a-z])([A-Z])", "$1 $2"));
            }

            SetJobs();
        }

        // Save employees data before window closes
        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
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
            Console.WriteLine("Update job details!");

            jobDateLabel.Text = job.Date;
            jobDescriptionTextBox.Text = job.Description;
            jobPriceTextBox.Text = job.Price.ToString();

            // TODO: If job status is unassigned, enable assign button
            // TODO: If job status is assigned, enable unasign button
            string jobStatus = Regex.Replace(job.Status.ToString(), "([a-z])([A-Z])", "$1 $2");
            jobStatusComboBox.SelectedIndex = jobStatusComboBox.FindString(jobStatus);

            if (jobStatusComboBox.SelectedText.Replace(" ", "") == JobStatus.Unassigned.ToString())
            {
                assignJobButton.Enabled = true;
            }
            else
            {
                assignJobButton.Enabled = false;
            }

            BindingSource notesBinding = new BindingSource();
            notesBinding.DataSource = job.Notes;

            notesListBox.DataSource = notesBinding;
        }

        private void UpdateMechanicDetails(Mechanic mechanic)
        {
            Console.WriteLine("Update mechanic details!");

            mechanicNameTextBox.Text = mechanic.Name;
            mechanicAddressTextBox.Text = mechanic.Address;
            salaryTextBox.Text = mechanic.Contract.Salary.ToString();
            hoursTextBox.Text = mechanic.Contract.Hours.ToString();

            BindingSource mechanicJobsBinding = new BindingSource();
            mechanicJobsBinding.DataSource = mechanic.Jobs;

            mechanicJobsListBox.DataSource = mechanicJobsBinding;
        }

        private void ResetJobFields()
        {
            jobDateLabel.Text = string.Empty;
            jobPriceTextBox.Text = string.Empty;
            jobDescriptionTextBox.Text = string.Empty;

            jobStatusComboBox.SelectedIndex = -1;
            notesListBox.DataSource = null;

            jobStatusComboBox.Enabled = false;
            jobDescriptionTextBox.Enabled = false;
            removeJobButton.Enabled = false;
            addNoteButton.Enabled = false;
            assignJobButton.Enabled = false;
        }

        private void ResetMechanicFields()
        {
            mechanicNameTextBox.Text = string.Empty;
            mechanicAddressTextBox.Text = string.Empty;
            salaryTextBox.Text = string.Empty;
            hoursTextBox.Text = string.Empty;

            mechanicJobsListBox.DataSource = null;

            mechanicNameTextBox.Enabled = false;
            mechanicAddressTextBox.Enabled = false;
            changeContractButton.Enabled = false;
        }

        private void jobsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (jobsListBox.SelectedIndex == -1)
            {
                ResetJobFields();
                return;
            }

            jobStatusComboBox.Enabled = true;
            jobDescriptionTextBox.Enabled = true;
            removeJobButton.Enabled = true;
            addNoteButton.Enabled = true;
            assignJobButton.Enabled = true;

            Job selectedJob = jobsListBox.SelectedItem as Job;
            if (selectedJob != null) UpdateJobDetails(selectedJob);

            Mechanic selectedMechanic = mechanicsListBox.SelectedItem as Mechanic;
            if (selectedMechanic == null) return;


        }

        private void mechanicsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (mechanicsListBox.SelectedIndex == -1)
            {
                ResetMechanicFields();
                return;
            }

            mechanicNameTextBox.Enabled = true;
            mechanicAddressTextBox.Enabled = true;
            changeContractButton.Enabled = true;

            Mechanic selectedMechanic = mechanicsListBox.SelectedItem as Mechanic;
            if (selectedMechanic != null) UpdateMechanicDetails(selectedMechanic);
        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            JobForm jobForm = new JobForm(SetJobs);
            jobForm.ShowDialog();
        }

        private void removeJobButton_Click(object sender, EventArgs e)
        {
            Job selectedJob = jobsListBox.SelectedItem as Job;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this job?\nThis action can not be reversed.",
                "Job deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                Entry.CurrentUser.Garage.Jobs.Remove(selectedJob);
                SetJobs();
                if (jobsListBox.Items.Count == 0)
                {
                    ResetJobFields();
                }
                else
                {
                    UpdateJobDetails(jobsListBox.SelectedValue as Job);
                }
            }
        }

        private void changeContractButton_Click(object sender, EventArgs e)
        {
            ContractForm contractForm = new ContractForm();
            contractForm.ShowDialog();
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            List<Job> jobs = Entry.CurrentUser.Garage.Jobs;
            Job selectedJob = jobs.Find(job => job.Description == jobsListBox.SelectedItem);

            NoteForm noteForm = new NoteForm(selectedJob);
            noteForm.ShowDialog();
        }

        private void removeNoteButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(notesListBox.SelectedItem);
            //String selectedNote = notesListBox.SelectedItem

            /*if (selectedMechanic != null)
            {
                Console.WriteLine(selectedMechanic.Name);
                Console.WriteLine(selectedMechanic.Address);
                Console.WriteLine(selectedMechanic.Contract);
                Console.WriteLine("----------");
            }
            else
            {
                // Set empty values?
            }*/
        }

        private void notesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = notesListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                NoteForm noteForm = new NoteForm(null, notesListBox.Items[index].ToString());
                noteForm.ShowDialog();
            }
        }

        private void UpdateMechanicJobs(Mechanic selectedMechanic)
        {
            BindingSource mechanicJobsBinding = new BindingSource();
            mechanicJobsBinding.DataSource = selectedMechanic.Jobs;

            mechanicJobsListBox.DataSource = mechanicJobsBinding;

            if (mechanicJobsListBox.Items.Count == 0)
            {
                unassignJobButton.Enabled = false;
                mechanicJobsListBox.DataSource = null;
                return;
            }

            unassignJobButton.Enabled = true;
        }

        private void assignJobButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Assign job!");

            Job selectedJob = jobsListBox.SelectedItem as Job;
            Mechanic selectedMechanic = mechanicsListBox.SelectedItem as Mechanic;

            if (selectedJob == null || selectedMechanic == null) return;
            
            if (!selectedMechanic.Jobs.Contains(selectedJob)) selectedMechanic.Jobs.Add(selectedJob);

            UpdateMechanicJobs(selectedMechanic);
        }

        private void unassignJobButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Unassign job!");

            Job selectedJob = mechanicJobsListBox.SelectedItem as Job;
            Mechanic selectedMechanic = mechanicsListBox.SelectedItem as Mechanic;

            if (selectedJob != null && selectedMechanic != null) selectedMechanic.Jobs.Remove(selectedJob);

            if (selectedMechanic != null) UpdateMechanicJobs(selectedMechanic);
        }

        private void mechanicNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Mechanic selectedMechanic = mechanicsListBox.SelectedItem as Mechanic;

            selectedMechanic.Name = mechanicNameTextBox.Text;
        }

        private void mechanicAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            Mechanic selectedMechanic = mechanicsListBox.SelectedItem as Mechanic;

            selectedMechanic.Address = mechanicAddressTextBox.Text;
        }

        private void jobStatusComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Enum.TryParse(jobStatusComboBox.Text.Replace(" ", ""), out JobStatus status);

            Job selectedJob = jobsListBox.SelectedItem as Job;

            if (selectedJob != null) selectedJob.Status = status;
        }
    }
}
