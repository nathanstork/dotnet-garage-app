using GarageApp.Users;

namespace GarageApp.Forms
{
    public partial class JobCompletionForm : Form
    {
        private Job Job;
        private Mechanic Mechanic;
        private Action SuccessCallback;
        private Action CancelCallback;

        internal JobCompletionForm(Job job, Mechanic mechanic, Action successCallback, Action cancelCallback)
        {
            Job = job;
            Mechanic = mechanic;
            SuccessCallback = successCallback;
            CancelCallback = cancelCallback;

            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Complete and unassign this job?",
                "Job completion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Job.Hours = Convert.ToInt32(hoursNumericUpDown.Value);
                Job.Costs = Convert.ToInt32(costsNumericUpDown.Value);

                Job.LabourCosts = Convert.ToInt32(Job.Hours * Mechanic.Contract.GetHourlySalary());

                Job.CompletedBy = Mechanic.Name;

                SuccessCallback();

                this.Hide();
                this.Close();
            }
        }

        private void JobCompletionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CancelCallback();
        }
    }
}
