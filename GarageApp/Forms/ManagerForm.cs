using GarageApp.Users;
using System.Data;
using System.Text.RegularExpressions;

namespace GarageApp.Forms
{
    public partial class ManagerForm : Form
    {
        readonly Employees Entry;

        Job SelectedJob;
        Mechanic SelectedMechanic;
        User SelectedUser;

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

        private void SetEmployees()
        {
            List<Mechanic> mechanics = Entry.CurrentUser.Mechanics;
            List<Manager> managers = Entry.Managers;

            List<User> employees = mechanics.Cast<User>().Concat(managers).ToList();

            // Remove admin user from employees list
            employees.Remove(employees.Find(item => item.Name == "Admin"));

            BindingSource mechanicsBinding = new BindingSource();
            mechanicsBinding.DataSource = employees;

            employeesListBox.DataSource = mechanicsBinding;

            SelectedUser = employeesListBox.SelectedItem as User;
        }

        private void SetupForm()
        {
            SetEmployees();

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

            if (job.Status == JobStatus.Completed || job.Status == JobStatus.UnableToComplete)
            {
                receiptButton.Enabled = true;
            }
            else
            {
                receiptButton.Enabled = false;
            }

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

            customerNameTextBox.Text = job.Customer.Name;
            customerAddressTextBox.Text = job.Customer.Address;
            customerEmailTextBox.Text = job.Customer.Email;
            customerPhoneTextBox.Text = job.Customer.Phone;

            carPlateTextBox.Text = job.Car.Plate;
            carBrandTextBox.Text = job.Car.Brand;
            carModelTextBox.Text = job.Car.Model;
            carColorTextBox.Text = job.Car.Color.ToString();
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

            customerNameTextBox.Text = string.Empty;
            customerAddressTextBox.Text = string.Empty;
            customerEmailTextBox.Text = string.Empty;
            customerPhoneTextBox.Text = string.Empty;

            carPlateTextBox.Text = string.Empty;
            carBrandTextBox.Text = string.Empty;
            carModelTextBox.Text = string.Empty;
            carColorTextBox.Text = string.Empty;

            removeJobButton.Enabled = false;
            assignJobButton.Enabled = false;

            jobStatusComboBox.SelectedIndex = -1;

            //jobStatusComboBox.Enabled = false;
            jobDescriptionTextBox.Enabled = false;
            jobNotesTextBox.Enabled= false;

            carPlateTextBox.Enabled = false;
            carBrandTextBox.Enabled = false;
            carModelTextBox.Enabled = false;
            carColorTextBox.Enabled = false;
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

            employeeTypeLabel.Text = "";
        }

        private void jobsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (jobsListBox.Items.Count == 0)
            {
                ResetJobFields();
                return;
            }

            //jobStatusComboBox.Enabled = true;
            jobDescriptionTextBox.Enabled = true;
            jobNotesTextBox.Enabled = true;
            removeJobButton.Enabled = true;
            assignJobButton.Enabled = true;
            carPlateTextBox.Enabled = true;
            carBrandTextBox.Enabled = true;
            carModelTextBox.Enabled = true;
            carColorTextBox.Enabled = true;

            SelectedJob = jobsListBox.SelectedItem as Job;
            if (SelectedJob != null) UpdateJobDetails(SelectedJob);
        }

        private void UpdateUserDetails(User user)
        {
            mechanicNameTextBox.Text = user.Name;
            mechanicAddressTextBox.Text = user.Address;
            salaryTextBox.Text = user.Contract.Salary.ToString();
            hoursTextBox.Text = user.Contract.Hours.ToString();

            if (user.Contract.GetType().Name == "MonthlyContract")
            {
                contractTypeLabel.Text = "Monthly";
            }
            else
            {
                contractTypeLabel.Text = "Weekly";
            }

            if (user.GetType().Name == "Mechanic")
            {
                Mechanic mechanic = user as Mechanic;

                employeeTypeLabel.Text = "Mechanic";

                // ?????
                if (Entry.CurrentUser.Garage.Jobs.Count > 0)
                {
                    assignJobButton.Enabled = true;
                }
                else
                {
                    assignJobButton.Enabled = false;
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
            else
            {
                employeeTypeLabel.Text = "Manager";

                mechanicJobsListBox.DataSource = null;
                mechanicJobsListBox.Enabled = false;

                assignJobButton.Enabled = true;
                unassignJobButton.Enabled = false;
            }
        }


        private void mechanicsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (employeesListBox.Items.Count == 0)
            {
                ResetMechanicFields();
                return;
            }

            mechanicNameTextBox.Enabled = true;
            mechanicAddressTextBox.Enabled = true;
            changeContractButton.Enabled = true;
            fireButton.Enabled = true;

            //SelectedMechanic = employeesListBox.SelectedItem as Mechanic;
            //if (SelectedMechanic != null) UpdateMechanicDetails(SelectedMechanic);

            SelectedUser = employeesListBox.SelectedItem as User;
            if (SelectedUser != null) UpdateUserDetails(SelectedUser);
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
                    UpdateJobDetails(SelectedJob);
                }
            }
        }

        private void changeContractButton_Click(object sender, EventArgs e)
        {
            //if (SelectedMechanic == null) return;
            if (SelectedUser == null) return;

            /*ContractForm contractForm = new ContractForm(SelectedMechanic, new Action(() =>
            {
                if (SelectedMechanic != null) UpdateMechanicDetails(SelectedMechanic);
            }));*/

            ContractForm contractForm = new ContractForm(SelectedUser, new Action(() =>
            {
                if (SelectedUser != null) UpdateUserDetails(SelectedUser);
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
            //if (SelectedJob == null || SelectedMechanic == null) return;
            if (SelectedJob == null || SelectedUser == null) return;

            /*if (!SelectedMechanic.Jobs.Contains(SelectedJob))
            {
                SelectedJob.Status = JobStatus.Assigned;
                SelectedMechanic.Jobs.Add(SelectedJob);
            }*/

            if (SelectedUser.GetType().Name != "Mechanic") return;

            Mechanic mechanic = SelectedUser as Mechanic;

            if (!mechanic.Jobs.Contains(SelectedJob))
            {
                SelectedJob.Status = JobStatus.Assigned;
                mechanic.Jobs.Add(SelectedJob);
            }

            UpdateJobDetails(SelectedJob);
            UpdateMechanicJobs(mechanic);
        }

        private void unassignJobButton_Click(object sender, EventArgs e)
        {
            if (SelectedJob == null || SelectedUser == null) return;
            if (SelectedUser.GetType().Name != "Mechanic") return;

            Mechanic mechanic = SelectedUser as Mechanic;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to unassign this job?",
                "Unassign job",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                mechanic.Jobs.Remove(SelectedJob);
                SelectedJob.Status = JobStatus.Unassigned;

                UpdateMechanicJobs(mechanic);
                UpdateJobDetails(SelectedJob);
            }

            /*if (SelectedJob != null && SelectedMechanic != null)
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

            if (SelectedMechanic != null) UpdateMechanicJobs(SelectedMechanic);*/
        }

        private void mechanicNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (SelectedMechanic != null) SelectedMechanic.Name = mechanicNameTextBox.Text;
            if (SelectedUser != null) SelectedUser.Name = mechanicNameTextBox.Text;
        }

        private void mechanicAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (SelectedMechanic != null) SelectedMechanic.Address = mechanicAddressTextBox.Text;
            if (SelectedUser != null) SelectedUser.Address = mechanicAddressTextBox.Text;
        }

        private void jobStatusComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Enum.TryParse(jobStatusComboBox.Text.Replace(" ", ""), out JobStatus status);

            if (SelectedJob != null) SelectedJob.Status = status;

            jobStatusTextBox.Text = jobStatusComboBox.Text;
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
            EmployeeForm employeeForm = new EmployeeForm(SetEmployees);
            employeeForm.ShowDialog();
        }

        private void fireButton_Click(object sender, EventArgs e)
        {
            //if (SelectedMechanic == null) return;
            if (SelectedUser == null) return;

            /*DialogResult result = MessageBox.Show(
                "Are you sure you want to let " + SelectedMechanic.Name + " go?",
                "Confirmation of release",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                Entry.CurrentUser.Mechanics.Remove(SelectedMechanic);
                SetMechanics();
                if (employeesListBox.Items.Count == 0)
                {
                    ResetMechanicFields();
                }
                else
                {
                    UpdateMechanicDetails(SelectedMechanic);
                }
            }*/

            DialogResult result = MessageBox.Show(
                "Are you sure you want to let " + SelectedUser.Name + " go?",
                "Confirmation of release",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                if (SelectedUser.GetType().Name == "Mechanic")
                {
                    Entry.Mechanics.Remove(SelectedUser as Mechanic);
                }
                else
                {
                    Entry.Managers.Remove(SelectedUser as Manager);
                }

                SetEmployees();

                if (employeesListBox.Items.Count == 0)
                {
                    ResetMechanicFields();
                }
                else
                {
                    //UpdateMechanicDetails(SelectedMechanic);
                    UpdateUserDetails(SelectedUser);
                }
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

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedJob != null) SelectedJob.Customer.Name = customerNameTextBox.Text;
        }

        private void customerAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedJob != null) SelectedJob.Customer.Address = customerAddressTextBox.Text;
        }

        private void customerEmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedJob != null) SelectedJob.Customer.Email = customerEmailTextBox.Text;
        }

        private void customerPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SelectedJob != null) SelectedJob.Customer.Phone = customerPhoneTextBox.Text;
        }
    }
}
