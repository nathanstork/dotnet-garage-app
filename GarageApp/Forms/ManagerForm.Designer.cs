namespace GarageApp.Forms
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.userLabel = new System.Windows.Forms.Label();
            this.jobsListBox = new System.Windows.Forms.ListBox();
            this.jobsLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mechanicsListBox = new System.Windows.Forms.ListBox();
            this.mechanicsLabel = new System.Windows.Forms.Label();
            this.addJobButton = new System.Windows.Forms.Button();
            this.removeJobButton = new System.Windows.Forms.Button();
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.mechanicDetailsGroupBox2 = new System.Windows.Forms.GroupBox();
            this.unassignJobButton = new System.Windows.Forms.Button();
            this.mechanicAddressTextBox = new System.Windows.Forms.TextBox();
            this.contractGroupBox = new System.Windows.Forms.GroupBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextLabel = new System.Windows.Forms.Label();
            this.salaryTextLabel = new System.Windows.Forms.Label();
            this.changeContractButton = new System.Windows.Forms.Button();
            this.mechanicAddressLabel = new System.Windows.Forms.Label();
            this.mechanicNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.assignJobButton = new System.Windows.Forms.Button();
            this.mechanicJobsLabel = new System.Windows.Forms.Label();
            this.mechanicJobsListBox = new System.Windows.Forms.ListBox();
            this.jobDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.removeNoteButton = new System.Windows.Forms.Button();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesListBox = new System.Windows.Forms.ListBox();
            this.jobStatusComboBox = new System.Windows.Forms.ComboBox();
            this.jobPriceTextBox = new System.Windows.Forms.TextBox();
            this.jobStatusLabel = new System.Windows.Forms.Label();
            this.jobPriceLabel = new System.Windows.Forms.Label();
            this.jobDateLabel = new System.Windows.Forms.Label();
            this.jobDescriptionLabel = new System.Windows.Forms.Label();
            this.jobDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.jobDateTextLabel = new System.Windows.Forms.Label();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireButton = new System.Windows.Forms.Button();
            this.hireButton = new System.Windows.Forms.Button();
            this.detailsGroupBox.SuspendLayout();
            this.mechanicDetailsGroupBox2.SuspendLayout();
            this.contractGroupBox.SuspendLayout();
            this.jobDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
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
            this.jobsListBox.Size = new System.Drawing.Size(224, 244);
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
            // mechanicsListBox
            // 
            this.mechanicsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mechanicsListBox.FormattingEnabled = true;
            this.mechanicsListBox.ItemHeight = 20;
            this.mechanicsListBox.Location = new System.Drawing.Point(22, 413);
            this.mechanicsListBox.Name = "mechanicsListBox";
            this.mechanicsListBox.Size = new System.Drawing.Size(224, 244);
            this.mechanicsListBox.TabIndex = 5;
            this.mechanicsListBox.SelectedValueChanged += new System.EventHandler(this.mechanicsListBox_SelectedValueChanged);
            // 
            // mechanicsLabel
            // 
            this.mechanicsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mechanicsLabel.AutoSize = true;
            this.mechanicsLabel.Location = new System.Drawing.Point(22, 390);
            this.mechanicsLabel.Name = "mechanicsLabel";
            this.mechanicsLabel.Size = new System.Drawing.Size(78, 20);
            this.mechanicsLabel.TabIndex = 6;
            this.mechanicsLabel.Text = "Mechanics";
            // 
            // addJobButton
            // 
            this.addJobButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addJobButton.Location = new System.Drawing.Point(22, 354);
            this.addJobButton.Name = "addJobButton";
            this.addJobButton.Size = new System.Drawing.Size(100, 29);
            this.addJobButton.TabIndex = 7;
            this.addJobButton.Text = "Add job";
            this.addJobButton.UseVisualStyleBackColor = true;
            this.addJobButton.Click += new System.EventHandler(this.addJobButton_Click);
            // 
            // removeJobButton
            // 
            this.removeJobButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeJobButton.Enabled = false;
            this.removeJobButton.Location = new System.Drawing.Point(146, 354);
            this.removeJobButton.Name = "removeJobButton";
            this.removeJobButton.Size = new System.Drawing.Size(100, 29);
            this.removeJobButton.TabIndex = 8;
            this.removeJobButton.Text = "Remove job";
            this.removeJobButton.UseVisualStyleBackColor = true;
            this.removeJobButton.Click += new System.EventHandler(this.removeJobButton_Click);
            // 
            // detailsGroupBox
            // 
            this.detailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsGroupBox.Controls.Add(this.mechanicDetailsGroupBox2);
            this.detailsGroupBox.Controls.Add(this.jobDetailsGroupBox);
            this.detailsGroupBox.Location = new System.Drawing.Point(266, 13);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Size = new System.Drawing.Size(703, 679);
            this.detailsGroupBox.TabIndex = 9;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Details";
            // 
            // mechanicDetailsGroupBox2
            // 
            this.mechanicDetailsGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mechanicDetailsGroupBox2.Controls.Add(this.unassignJobButton);
            this.mechanicDetailsGroupBox2.Controls.Add(this.mechanicAddressTextBox);
            this.mechanicDetailsGroupBox2.Controls.Add(this.contractGroupBox);
            this.mechanicDetailsGroupBox2.Controls.Add(this.mechanicAddressLabel);
            this.mechanicDetailsGroupBox2.Controls.Add(this.mechanicNameTextBox);
            this.mechanicDetailsGroupBox2.Controls.Add(this.nameLabel);
            this.mechanicDetailsGroupBox2.Controls.Add(this.assignJobButton);
            this.mechanicDetailsGroupBox2.Controls.Add(this.mechanicJobsLabel);
            this.mechanicDetailsGroupBox2.Controls.Add(this.mechanicJobsListBox);
            this.mechanicDetailsGroupBox2.Location = new System.Drawing.Point(15, 441);
            this.mechanicDetailsGroupBox2.Name = "mechanicDetailsGroupBox2";
            this.mechanicDetailsGroupBox2.Size = new System.Drawing.Size(672, 223);
            this.mechanicDetailsGroupBox2.TabIndex = 1;
            this.mechanicDetailsGroupBox2.TabStop = false;
            this.mechanicDetailsGroupBox2.Text = "Mechanic";
            // 
            // unassignJobButton
            // 
            this.unassignJobButton.Enabled = false;
            this.unassignJobButton.Location = new System.Drawing.Point(488, 185);
            this.unassignJobButton.Name = "unassignJobButton";
            this.unassignJobButton.Size = new System.Drawing.Size(120, 29);
            this.unassignJobButton.TabIndex = 21;
            this.unassignJobButton.Text = "Unassign job";
            this.unassignJobButton.UseVisualStyleBackColor = true;
            this.unassignJobButton.Click += new System.EventHandler(this.unassignJobButton_Click);
            // 
            // mechanicAddressTextBox
            // 
            this.mechanicAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mechanicAddressTextBox.Enabled = false;
            this.mechanicAddressTextBox.Location = new System.Drawing.Point(85, 72);
            this.mechanicAddressTextBox.Name = "mechanicAddressTextBox";
            this.mechanicAddressTextBox.Size = new System.Drawing.Size(263, 27);
            this.mechanicAddressTextBox.TabIndex = 19;
            this.mechanicAddressTextBox.TextChanged += new System.EventHandler(this.mechanicAddressTextBox_TextChanged);
            // 
            // contractGroupBox
            // 
            this.contractGroupBox.Controls.Add(this.hoursTextBox);
            this.contractGroupBox.Controls.Add(this.salaryTextBox);
            this.contractGroupBox.Controls.Add(this.hoursTextLabel);
            this.contractGroupBox.Controls.Add(this.salaryTextLabel);
            this.contractGroupBox.Controls.Add(this.changeContractButton);
            this.contractGroupBox.Location = new System.Drawing.Point(7, 122);
            this.contractGroupBox.Name = "contractGroupBox";
            this.contractGroupBox.Size = new System.Drawing.Size(350, 92);
            this.contractGroupBox.TabIndex = 17;
            this.contractGroupBox.TabStop = false;
            this.contractGroupBox.Text = "Contract";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoursTextBox.Location = new System.Drawing.Point(241, 20);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.ReadOnly = true;
            this.hoursTextBox.Size = new System.Drawing.Size(100, 27);
            this.hoursTextBox.TabIndex = 18;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryTextBox.Location = new System.Drawing.Point(64, 20);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.ReadOnly = true;
            this.salaryTextBox.Size = new System.Drawing.Size(100, 27);
            this.salaryTextBox.TabIndex = 17;
            // 
            // hoursTextLabel
            // 
            this.hoursTextLabel.AutoSize = true;
            this.hoursTextLabel.Location = new System.Drawing.Point(184, 24);
            this.hoursTextLabel.Name = "hoursTextLabel";
            this.hoursTextLabel.Size = new System.Drawing.Size(51, 20);
            this.hoursTextLabel.TabIndex = 17;
            this.hoursTextLabel.Text = "Hours:";
            // 
            // salaryTextLabel
            // 
            this.salaryTextLabel.AutoSize = true;
            this.salaryTextLabel.Location = new System.Drawing.Point(6, 23);
            this.salaryTextLabel.Name = "salaryTextLabel";
            this.salaryTextLabel.Size = new System.Drawing.Size(52, 20);
            this.salaryTextLabel.TabIndex = 16;
            this.salaryTextLabel.Text = "Salary:";
            // 
            // changeContractButton
            // 
            this.changeContractButton.Enabled = false;
            this.changeContractButton.Location = new System.Drawing.Point(218, 52);
            this.changeContractButton.Name = "changeContractButton";
            this.changeContractButton.Size = new System.Drawing.Size(123, 29);
            this.changeContractButton.TabIndex = 10;
            this.changeContractButton.Text = "Change";
            this.changeContractButton.UseVisualStyleBackColor = true;
            this.changeContractButton.Click += new System.EventHandler(this.changeContractButton_Click);
            // 
            // mechanicAddressLabel
            // 
            this.mechanicAddressLabel.AutoSize = true;
            this.mechanicAddressLabel.Location = new System.Drawing.Point(6, 75);
            this.mechanicAddressLabel.Name = "mechanicAddressLabel";
            this.mechanicAddressLabel.Size = new System.Drawing.Size(65, 20);
            this.mechanicAddressLabel.TabIndex = 20;
            this.mechanicAddressLabel.Text = "Address:";
            // 
            // mechanicNameTextBox
            // 
            this.mechanicNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mechanicNameTextBox.Enabled = false;
            this.mechanicNameTextBox.Location = new System.Drawing.Point(85, 39);
            this.mechanicNameTextBox.Name = "mechanicNameTextBox";
            this.mechanicNameTextBox.Size = new System.Drawing.Size(263, 27);
            this.mechanicNameTextBox.TabIndex = 16;
            this.mechanicNameTextBox.TextChanged += new System.EventHandler(this.mechanicNameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 42);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 20);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name:";
            // 
            // assignJobButton
            // 
            this.assignJobButton.Location = new System.Drawing.Point(362, 185);
            this.assignJobButton.Name = "assignJobButton";
            this.assignJobButton.Size = new System.Drawing.Size(120, 29);
            this.assignJobButton.TabIndex = 18;
            this.assignJobButton.Text = "Assign job";
            this.assignJobButton.UseVisualStyleBackColor = true;
            this.assignJobButton.Click += new System.EventHandler(this.assignJobButton_Click);
            // 
            // mechanicJobsLabel
            // 
            this.mechanicJobsLabel.AutoSize = true;
            this.mechanicJobsLabel.Location = new System.Drawing.Point(362, 29);
            this.mechanicJobsLabel.Name = "mechanicJobsLabel";
            this.mechanicJobsLabel.Size = new System.Drawing.Size(41, 20);
            this.mechanicJobsLabel.TabIndex = 16;
            this.mechanicJobsLabel.Text = "Jobs:";
            // 
            // mechanicJobsListBox
            // 
            this.mechanicJobsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mechanicJobsListBox.FormattingEnabled = true;
            this.mechanicJobsListBox.ItemHeight = 20;
            this.mechanicJobsListBox.Location = new System.Drawing.Point(362, 55);
            this.mechanicJobsListBox.Name = "mechanicJobsListBox";
            this.mechanicJobsListBox.Size = new System.Drawing.Size(292, 124);
            this.mechanicJobsListBox.TabIndex = 10;
            // 
            // jobDetailsGroupBox
            // 
            this.jobDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDetailsGroupBox.Controls.Add(this.textBox1);
            this.jobDetailsGroupBox.Controls.Add(this.removeNoteButton);
            this.jobDetailsGroupBox.Controls.Add(this.addNoteButton);
            this.jobDetailsGroupBox.Controls.Add(this.notesLabel);
            this.jobDetailsGroupBox.Controls.Add(this.notesListBox);
            this.jobDetailsGroupBox.Controls.Add(this.jobStatusComboBox);
            this.jobDetailsGroupBox.Controls.Add(this.jobPriceTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.jobStatusLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobPriceLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobDateLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobDescriptionLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobDescriptionTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.jobDateTextLabel);
            this.jobDetailsGroupBox.Location = new System.Drawing.Point(15, 23);
            this.jobDetailsGroupBox.Name = "jobDetailsGroupBox";
            this.jobDetailsGroupBox.Size = new System.Drawing.Size(672, 412);
            this.jobDetailsGroupBox.TabIndex = 0;
            this.jobDetailsGroupBox.TabStop = false;
            this.jobDetailsGroupBox.Text = "Job";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(100, 188);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(554, 95);
            this.textBox1.TabIndex = 20;
            // 
            // removeNoteButton
            // 
            this.removeNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeNoteButton.Enabled = false;
            this.removeNoteButton.Location = new System.Drawing.Point(578, 373);
            this.removeNoteButton.Name = "removeNoteButton";
            this.removeNoteButton.Size = new System.Drawing.Size(76, 29);
            this.removeNoteButton.TabIndex = 19;
            this.removeNoteButton.Text = "Remove";
            this.removeNoteButton.UseVisualStyleBackColor = true;
            this.removeNoteButton.Click += new System.EventHandler(this.removeNoteButton_Click);
            // 
            // addNoteButton
            // 
            this.addNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addNoteButton.Enabled = false;
            this.addNoteButton.Location = new System.Drawing.Point(578, 338);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(76, 29);
            this.addNoteButton.TabIndex = 18;
            this.addNoteButton.Text = "Add";
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.addNoteButton_Click);
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(7, 188);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(51, 20);
            this.notesLabel.TabIndex = 17;
            this.notesLabel.Text = "Notes:";
            // 
            // notesListBox
            // 
            this.notesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesListBox.FormattingEnabled = true;
            this.notesListBox.ItemHeight = 20;
            this.notesListBox.Location = new System.Drawing.Point(100, 338);
            this.notesListBox.Name = "notesListBox";
            this.notesListBox.Size = new System.Drawing.Size(472, 64);
            this.notesListBox.TabIndex = 16;
            this.notesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notesListBox_MouseDoubleClick);
            // 
            // jobStatusComboBox
            // 
            this.jobStatusComboBox.Enabled = false;
            this.jobStatusComboBox.FormattingEnabled = true;
            this.jobStatusComboBox.Location = new System.Drawing.Point(100, 20);
            this.jobStatusComboBox.Name = "jobStatusComboBox";
            this.jobStatusComboBox.Size = new System.Drawing.Size(176, 28);
            this.jobStatusComboBox.TabIndex = 2;
            this.jobStatusComboBox.SelectedValueChanged += new System.EventHandler(this.jobStatusComboBox_SelectedValueChanged);
            // 
            // jobPriceTextBox
            // 
            this.jobPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobPriceTextBox.Location = new System.Drawing.Point(100, 54);
            this.jobPriceTextBox.Name = "jobPriceTextBox";
            this.jobPriceTextBox.ReadOnly = true;
            this.jobPriceTextBox.Size = new System.Drawing.Size(554, 27);
            this.jobPriceTextBox.TabIndex = 15;
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
            this.jobDateLabel.Location = new System.Drawing.Point(654, 23);
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
            // jobDescriptionTextBox
            // 
            this.jobDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDescriptionTextBox.Enabled = false;
            this.jobDescriptionTextBox.Location = new System.Drawing.Point(100, 87);
            this.jobDescriptionTextBox.Multiline = true;
            this.jobDescriptionTextBox.Name = "jobDescriptionTextBox";
            this.jobDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jobDescriptionTextBox.Size = new System.Drawing.Size(554, 95);
            this.jobDescriptionTextBox.TabIndex = 1;
            // 
            // jobDateTextLabel
            // 
            this.jobDateTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDateTextLabel.AutoSize = true;
            this.jobDateTextLabel.Location = new System.Drawing.Point(520, 23);
            this.jobDateTextLabel.Name = "jobDateTextLabel";
            this.jobDateTextLabel.Size = new System.Drawing.Size(44, 20);
            this.jobDateTextLabel.TabIndex = 0;
            this.jobDateTextLabel.Text = "Date:";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(GarageApp.Employees);
            // 
            // fireButton
            // 
            this.fireButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fireButton.Enabled = false;
            this.fireButton.Location = new System.Drawing.Point(146, 663);
            this.fireButton.Name = "fireButton";
            this.fireButton.Size = new System.Drawing.Size(100, 29);
            this.fireButton.TabIndex = 11;
            this.fireButton.Text = "Fire";
            this.fireButton.UseVisualStyleBackColor = true;
            // 
            // hireButton
            // 
            this.hireButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hireButton.Location = new System.Drawing.Point(22, 663);
            this.hireButton.Name = "hireButton";
            this.hireButton.Size = new System.Drawing.Size(100, 29);
            this.hireButton.TabIndex = 10;
            this.hireButton.Text = "Hire new";
            this.hireButton.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.fireButton);
            this.Controls.Add(this.hireButton);
            this.Controls.Add(this.detailsGroupBox);
            this.Controls.Add(this.removeJobButton);
            this.Controls.Add(this.addJobButton);
            this.Controls.Add(this.mechanicsLabel);
            this.Controls.Add(this.mechanicsListBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.jobsLabel);
            this.Controls.Add(this.jobsListBox);
            this.Controls.Add(this.userLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagerForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garage App v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.detailsGroupBox.ResumeLayout(false);
            this.mechanicDetailsGroupBox2.ResumeLayout(false);
            this.mechanicDetailsGroupBox2.PerformLayout();
            this.contractGroupBox.ResumeLayout(false);
            this.contractGroupBox.PerformLayout();
            this.jobDetailsGroupBox.ResumeLayout(false);
            this.jobDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userLabel;
        private ListBox jobsListBox;
        private Label jobsLabel;
        private Button logoutButton;
        private ListBox mechanicsListBox;
        private Label mechanicsLabel;
        private Button addJobButton;
        private Button removeJobButton;
        private GroupBox detailsGroupBox;
        private BindingSource employeesBindingSource;
        private GroupBox mechanicDetailsGroupBox2;
        private GroupBox jobDetailsGroupBox;
        private Button changeContractButton;
        private Label jobDescriptionLabel;
        private TextBox jobDescriptionTextBox;
        private Label jobDateTextLabel;
        private TextBox jobPriceTextBox;
        private Label jobDateLabel;
        private Label jobStatusLabel;
        private Label jobPriceLabel;
        private ComboBox jobStatusComboBox;
        private Label mechanicJobsLabel;
        private ListBox mechanicJobsListBox;
        private Label salaryTextLabel;
        private GroupBox contractGroupBox;
        private Label hoursTextLabel;
        private Button assignJobButton;
        private TextBox salaryTextBox;
        private Label nameLabel;
        private TextBox hoursTextBox;
        private TextBox mechanicNameTextBox;
        private TextBox mechanicAddressTextBox;
        private Label mechanicAddressLabel;
        private Button unassignJobButton;
        private Label notesLabel;
        private ListBox notesListBox;
        private Button addNoteButton;
        private Button removeNoteButton;
        private Button fireButton;
        private Button hireButton;
        private TextBox textBox1;
    }
}