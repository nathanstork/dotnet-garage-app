using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageApp.Forms
{
    public partial class JobCompletionForm : Form
    {
        private Job Job;
        private string MechanicName;
        private Action SuccessCallback;
        private Action CancelCallback;

        internal JobCompletionForm(Job job, string mechanicName, Action successCallback, Action cancelCallback)
        {
            Job = job;
            MechanicName = mechanicName;
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
                Job.CompletedBy = MechanicName;

                Job.Hours = Convert.ToInt32(hoursNumericUpDown.Value);
                Job.Costs = Convert.ToInt32(costsNumericUpDown.Value);

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
