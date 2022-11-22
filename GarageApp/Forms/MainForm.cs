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
        public MechanicForm(string? label)
        {
            InitializeComponent();

            if (label != null)
            {
                testLabel.Text = label;
            }

            SetupForm();
        }

        private void SetupForm()
        {
            Employees employees = Employees.GetInstance();

            Console.WriteLine(employees.CurrentUser.GetType().Name);

            if (employees.CurrentUser.GetType().Name == "Manager")
            {
                Console.WriteLine(employees.CurrentUser.GetMechanics());

                List<Mechanic> mechanics = employees.CurrentUser.GetMechanics();
                mechanics.ForEach(mechanic =>
                {
                    mechanicsListBox.Items.Add(mechanic.Name);
                });
            }
        }

        // Save employees data before window closes
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Employees employees = Employees.GetInstance();
            employees.SaveData();
        }
    }
}
