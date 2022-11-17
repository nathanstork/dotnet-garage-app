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
    public partial class MainForm : Form
    {
        public MainForm(string? label)
        {
            InitializeComponent();

            if (label != null)
            {
                testLabel.Text = label;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
