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
    public partial class NoteForm : Form
    {
        internal NoteForm(Job job, string? note = null)
        {
            InitializeComponent();

            if (note != null)
            {
                // Setup form for existing note
                noteTextBox.Text = note;
            }
            else
            {
                // Setup form for new note
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //noteTextBox.Text
            //Garage garage = Employees.GetInstance().CurrentUser.Garage.GetInstance();
            //garage.J

            this.Hide();
            this.Close();
        }
    }
}
