namespace GarageApp.Forms
{
    partial class MechanicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MechanicForm));
            this.userLabel = new System.Windows.Forms.Label();
            this.jobsListBox = new System.Windows.Forms.ListBox();
            this.jobsLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.addJobButton = new System.Windows.Forms.Button();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.jobStatusLabel = new System.Windows.Forms.Label();
            this.jobPriceLabel = new System.Windows.Forms.Label();
            this.jobDateLabel = new System.Windows.Forms.Label();
            this.jobDescriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.jobDateTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.jobDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(22, 19);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 20);
            this.userLabel.TabIndex = 0;
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jobsListBox
            // 
            this.jobsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.jobsListBox.FormattingEnabled = true;
            this.jobsListBox.ItemHeight = 20;
            this.jobsListBox.Location = new System.Drawing.Point(22, 104);
            this.jobsListBox.Name = "jobsListBox";
            this.jobsListBox.Size = new System.Drawing.Size(224, 404);
            this.jobsListBox.TabIndex = 2;
            this.jobsListBox.SelectedValueChanged += new System.EventHandler(this.jobsListBox_SelectedValueChanged);
            // 
            // jobsLabel
            // 
            this.jobsLabel.AutoSize = true;
            this.jobsLabel.Location = new System.Drawing.Point(22, 81);
            this.jobsLabel.Name = "jobsLabel";
            this.jobsLabel.Size = new System.Drawing.Size(38, 20);
            this.jobsLabel.TabIndex = 3;
            this.jobsLabel.Text = "Jobs";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(22, 42);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(82, 29);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // addJobButton
            // 
            this.addJobButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addJobButton.Location = new System.Drawing.Point(22, 511);
            this.addJobButton.Name = "addJobButton";
            this.addJobButton.Size = new System.Drawing.Size(224, 29);
            this.addJobButton.TabIndex = 7;
            this.addJobButton.Text = "Add job";
            this.addJobButton.UseVisualStyleBackColor = true;
            this.addJobButton.Click += new System.EventHandler(this.addJobButton_Click);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(GarageApp.Employees);
            // 
            // jobDetailsGroupBox
            // 
            this.jobDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDetailsGroupBox.Controls.Add(this.notesTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.notesLabel);
            this.jobDetailsGroupBox.Controls.Add(this.statusComboBox);
            this.jobDetailsGroupBox.Controls.Add(this.priceTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.jobStatusLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobPriceLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobDateLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobDescriptionLabel);
            this.jobDetailsGroupBox.Controls.Add(this.descriptionTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.jobDateTextLabel);
            this.jobDetailsGroupBox.Location = new System.Drawing.Point(266, 19);
            this.jobDetailsGroupBox.Name = "jobDetailsGroupBox";
            this.jobDetailsGroupBox.Size = new System.Drawing.Size(703, 521);
            this.jobDetailsGroupBox.TabIndex = 0;
            this.jobDetailsGroupBox.TabStop = false;
            this.jobDetailsGroupBox.Text = "Job";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.Enabled = false;
            this.notesTextBox.Location = new System.Drawing.Point(100, 299);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTextBox.Size = new System.Drawing.Size(585, 203);
            this.notesTextBox.TabIndex = 18;
            this.notesTextBox.TextChanged += new System.EventHandler(this.notesTextBox_TextChanged);
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(5, 299);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(51, 20);
            this.notesLabel.TabIndex = 17;
            this.notesLabel.Text = "Notes:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Enabled = false;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(100, 20);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(176, 28);
            this.statusComboBox.TabIndex = 2;
            this.statusComboBox.SelectedValueChanged += new System.EventHandler(this.statusComboBox_SelectedValueChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTextBox.Location = new System.Drawing.Point(100, 54);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(176, 27);
            this.priceTextBox.TabIndex = 15;
            // 
            // jobStatusLabel
            // 
            this.jobStatusLabel.AutoSize = true;
            this.jobStatusLabel.Location = new System.Drawing.Point(6, 23);
            this.jobStatusLabel.Name = "jobStatusLabel";
            this.jobStatusLabel.Size = new System.Drawing.Size(52, 20);
            this.jobStatusLabel.TabIndex = 13;
            this.jobStatusLabel.Text = "Status:";
            // 
            // jobPriceLabel
            // 
            this.jobPriceLabel.AutoSize = true;
            this.jobPriceLabel.Location = new System.Drawing.Point(6, 57);
            this.jobPriceLabel.Name = "jobPriceLabel";
            this.jobPriceLabel.Size = new System.Drawing.Size(44, 20);
            this.jobPriceLabel.TabIndex = 11;
            this.jobPriceLabel.Text = "Price:";
            // 
            // jobDateLabel
            // 
            this.jobDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDateLabel.AutoSize = true;
            this.jobDateLabel.Location = new System.Drawing.Point(685, 23);
            this.jobDateLabel.Name = "jobDateLabel";
            this.jobDateLabel.Size = new System.Drawing.Size(0, 20);
            this.jobDateLabel.TabIndex = 10;
            // 
            // jobDescriptionLabel
            // 
            this.jobDescriptionLabel.AutoSize = true;
            this.jobDescriptionLabel.Location = new System.Drawing.Point(6, 90);
            this.jobDescriptionLabel.Name = "jobDescriptionLabel";
            this.jobDescriptionLabel.Size = new System.Drawing.Size(88, 20);
            this.jobDescriptionLabel.TabIndex = 2;
            this.jobDescriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(100, 87);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(585, 203);
            this.descriptionTextBox.TabIndex = 1;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // jobDateTextLabel
            // 
            this.jobDateTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDateTextLabel.AutoSize = true;
            this.jobDateTextLabel.Location = new System.Drawing.Point(551, 23);
            this.jobDateTextLabel.Name = "jobDateTextLabel";
            this.jobDateTextLabel.Size = new System.Drawing.Size(44, 20);
            this.jobDateTextLabel.TabIndex = 0;
            this.jobDateTextLabel.Text = "Date:";
            // 
            // MechanicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.jobDetailsGroupBox);
            this.Controls.Add(this.addJobButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.jobsLabel);
            this.Controls.Add(this.jobsListBox);
            this.Controls.Add(this.userLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MechanicForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garage App v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MechanicForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.jobDetailsGroupBox.ResumeLayout(false);
            this.jobDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userLabel;
        private ListBox jobsListBox;
        private Label jobsLabel;
        private Button logoutButton;
        private Button addJobButton;
        private BindingSource employeesBindingSource;
        private GroupBox jobDetailsGroupBox;
        private TextBox notesTextBox;
        private Label notesLabel;
        private ComboBox statusComboBox;
        private TextBox priceTextBox;
        private Label jobStatusLabel;
        private Label jobPriceLabel;
        private Label jobDateLabel;
        private Label jobDescriptionLabel;
        private TextBox descriptionTextBox;
        private Label jobDateTextLabel;
    }
}