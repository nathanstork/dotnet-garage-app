using GarageApp.Users;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GarageApp.Forms
{
    public partial class ManagerForm : Form
    {
        readonly Employees Entry;

        Job SelectedJob;
        Mechanic SelectedMechanic;

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

            SelectedJob = jobsListBox.SelectedItem as Job;
        }

        private void SetMechanics()
        {
            List<Mechanic> mechanics = Entry.CurrentUser.Mechanics;

            BindingSource mechanicsBinding = new BindingSource();
            mechanicsBinding.DataSource = mechanics;

            mechanicsListBox.DataSource = mechanicsBinding;

            SelectedMechanic = mechanicsListBox.SelectedItem as Mechanic;
        }

        private void SetupForm()
        {
            SetMechanics();

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
            jobDateLabel.Text = job.Date;
            jobPriceTextBox.Text = job.Price.ToString();
            jobDescriptionTextBox.Text = job.Description;
            jobNotesTextBox.Text = job.Notes;

            string jobStatus = Regex.Replace(job.Status.ToString(), "([a-z])([A-Z])", "$1 $2");
            jobStatusComboBox.SelectedIndex = jobStatusComboBox.FindString(jobStatus);

            if (job.Status.ToString().Replace(" ", "") == JobStatus.Unassigned.ToString())
            {
                assignJobButton.Enabled = true;
            }
            else
            {
                assignJobButton.Enabled = false;
            }
        }

        private void UpdateMechanicDetails(Mechanic mechanic)
        {
            mechanicNameTextBox.Text = mechanic.Name;
            mechanicAddressTextBox.Text = mechanic.Address;
            salaryTextBox.Text = mechanic.Contract.Salary.ToString();
            hoursTextBox.Text = mechanic.Contract.Hours.ToString();

            if (mechanic.Contract.GetType().Name == "MonthlyContract")
            {
                contractTypeLabel.Text = "Monthly";
            }
            else
            {
                contractTypeLabel.Text = "Weekly";
            }

            if (mechanic.Jobs.Count > 0)
            {
                unassignJobButton.Enabled = true;
            }
            else
            {
                unassignJobButton.Enabled = false;
            }

            BindingSource mechanicJobsBinding = new BindingSource();
            mechanicJobsBinding.DataSource = mechanic.Jobs;

            mechanicJobsListBox.DataSource = mechanicJobsBinding;
        }

        private void ResetJobFields()
        {
            jobDateLabel.Text = string.Empty;
            jobPriceTextBox.Text = string.Empty;
            jobDescriptionTextBox.Text = string.Empty;
            jobNotesTextBox.Text = string.Empty;

            jobStatusComboBox.SelectedIndex = -1;

            jobStatusComboBox.Enabled = false;
            jobDescriptionTextBox.Enabled = false;
            jobNotesTextBox.Enabled= false;
            removeJobButton.Enabled = false;
            assignJobButton.Enabled = false;
        }

        private void ResetMechanicFields()
        {
            mechanicNameTextBox.Text = string.Empty;
            mechanicAddressTextBox.Text = string.Empty;
            salaryTextBox.Text = string.Empty;
            hoursTextBox.Text = string.Empty;
            contractTypeLabel.Text = string.Empty;

            mechanicJobsListBox.DataSource = null;

            mechanicNameTextBox.Enabled = false;
            mechanicAddressTextBox.Enabled = false;
            changeContractButton.Enabled = false;
            fireButton.Enabled = false;
        }

        private void jobsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (jobsListBox.Items.Count == 0)
            {
                ResetJobFields();
                return;
            }

            jobStatusComboBox.Enabled = true;
            jobDescriptionTextBox.Enabled = true;
            jobNotesTextBox.Enabled = true;
            removeJobButton.Enabled = true;
            assignJobButton.Enabled = true;

            SelectedJob = jobsListBox.SelectedItem as Job;
            if (SelectedJob != null) UpdateJobDetails(SelectedJob);
        }

        private void mechanicsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (mechanicsListBox.Items.Count == 0)
            {
                ResetMechanicFields();
                return;
            }

            mechanicNameTextBox.Enabled = true;
            mechanicAddressTextBox.Enabled = true;
            changeContractButton.Enabled = true;
            fireButton.Enabled = true;

            SelectedMechanic = mechanicsListBox.SelectedItem as Mechanic;
            if (SelectedMechanic != null) UpdateMechanicDetails(SelectedMechanic);
        }

        private void addJobButton_Click(object sender, EventArgs e)
        {
            JobForm jobForm = new JobForm(SetJobs);
            jobForm.ShowDialog();
        }

        private void removeJobButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove this job?\nThis action can not be reversed.",
                "Job deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                Entry.CurrentUser.Garage.Jobs.Remove(SelectedJob);
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
            if (SelectedMechanic == null) return;

            ContractForm contractForm = new ContractForm(SelectedMechanic, new Action(() =>
            {
                if (SelectedMechanic != null) UpdateMechanicDetails(SelectedMechanic);
            }));

            contractForm.ShowDialog();
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
            if (SelectedJob == null || SelectedMechanic == null) return;

            if (!SelectedMechanic.Jobs.Contains(SelectedJob))
            {
                SelectedJob.Status = JobStatus.Assigned;
                SelectedMechanic.Jobs.Add(SelectedJob);
            }

            UpdateMechanicJobs(SelectedMechanic);
        }

        private void unassignJobButton_Click(object sender, EventArgs e)
        {
            if (SelectedJob != null && SelectedMechanic != null)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to unassign this job?",
                    "Unassign job",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    SelectedMechanic.Jobs.Remove(SelectedJob);
                    SelectedJob.Status = JobStatus.Unassigned;
                }
            }

            if (SelectedMechanic != null) UpdateMechanicJobs(SelectedMechanic);
        }

        private void mechanicNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedMechanic != null) SelectedMechanic.Name = mechanicNameTextBox.Text;
        }

        private void mechanicAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedMechanic != null) SelectedMechanic.Address = mechanicAddressTextBox.Text;
        }

        private void jobStatusComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Enum.TryParse(jobStatusComboBox.Text.Replace(" ", ""), out JobStatus status);

            if (SelectedJob != null) SelectedJob.Status = status;
        }

        private void jobDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedJob != null) SelectedJob.Description = jobDescriptionTextBox.Text;
        }

        private void jobNotesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedJob != null) SelectedJob.Notes = jobNotesTextBox.Text;
        }

        private void hireButton_Click(object sender, EventArgs e)
        {
            // TODO: Hire new employee functionality
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            if (SelectedMechanic == null) return;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to let " + SelectedMechanic.Name + " go?",
                "Confirmation of release",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Entry.CurrentUser.Mechanics.Remove(SelectedMechanic);
                SetMechanics();
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            if (SelectedJob == null) return;

            int total = SelectedJob.Price + SelectedJob.Costs;

            string content = @$"{SelectedJob.ToString()}

Labour costs: {SelectedJob.Price}
Material costs: {SelectedJob.Costs}
------------------------ +
Total: {total}";

            MessageBox.Show(content, "Receipt", MessageBoxButtons.OK);
        }
    }
}
