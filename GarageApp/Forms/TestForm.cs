using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageApp.Forms
{
    public partial class TestForm : Form
    {
        public TestForm(string? label)
        {
            InitializeComponent();

            if (label != null)
            {
                label1.Text = label;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
