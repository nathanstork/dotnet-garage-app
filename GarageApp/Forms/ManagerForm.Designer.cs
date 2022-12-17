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
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.employeesLabel = new System.Windows.Forms.Label();
            this.addJobButton = new System.Windows.Forms.Button();
            this.removeJobButton = new System.Windows.Forms.Button();
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.employeeGroupBox = new System.Windows.Forms.GroupBox();
            this.employeeTypeLabel = new System.Windows.Forms.Label();
            this.unassignJobButton = new System.Windows.Forms.Button();
            this.mechanicAddressTextBox = new System.Windows.Forms.TextBox();
            this.contractGroupBox = new System.Windows.Forms.GroupBox();
            this.contractTypeLabel = new System.Windows.Forms.Label();
            this.contractTypeTextLabel = new System.Windows.Forms.Label();
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
            this.jobStatusTextBox = new System.Windows.Forms.TextBox();
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.customerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.customerAddressTextBox = new System.Windows.Forms.TextBox();
            this.customerEmailTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneLabel = new System.Windows.Forms.Label();
            this.customerEmailLabel = new System.Windows.Forms.Label();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.carGroupBox = new System.Windows.Forms.GroupBox();
            this.carModelTextBox = new System.Windows.Forms.TextBox();
            this.carColorTextBox = new System.Windows.Forms.TextBox();
            this.carBrandTextBox = new System.Windows.Forms.TextBox();
            this.carPlateTextBox = new System.Windows.Forms.TextBox();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.carBrandLabel = new System.Windows.Forms.Label();
            this.carColorLabel = new System.Windows.Forms.Label();
            this.carPlateLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.jobNotesTextBox = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.Label();
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
            this.profitButton = new System.Windows.Forms.Button();
            this.garageGroupBox = new System.Windows.Forms.GroupBox();
            this.detailsGroupBox.SuspendLayout();
            this.employeeGroupBox.SuspendLayout();
            this.contractGroupBox.SuspendLayout();
            this.jobDetailsGroupBox.SuspendLayout();
            this.customerGroupBox.SuspendLayout();
            this.carGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.garageGroupBox.SuspendLayout();
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
            this.jobsListBox.Sorted = true;
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
            // employeesListBox
            // 
            this.employeesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.ItemHeight = 20;
            this.employeesListBox.Location = new System.Drawing.Point(22, 413);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(224, 244);
            this.employeesListBox.Sorted = true;
            this.employeesListBox.TabIndex = 5;
            this.employeesListBox.SelectedValueChanged += new System.EventHandler(this.mechanicsListBox_SelectedValueChanged);
            // 
            // employeesLabel
            // 
            this.employeesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.employeesLabel.AutoSize = true;
            this.employeesLabel.Location = new System.Drawing.Point(22, 390);
            this.employeesLabel.Name = "employeesLabel";
            this.employeesLabel.Size = new System.Drawing.Size(81, 20);
            this.employeesLabel.TabIndex = 6;
            this.employeesLabel.Text = "Employees";
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
            this.detailsGroupBox.Controls.Add(this.employeeGroupBox);
            this.detailsGroupBox.Controls.Add(this.jobDetailsGroupBox);
            this.detailsGroupBox.Location = new System.Drawing.Point(266, 13);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Size = new System.Drawing.Size(703, 603);
            this.detailsGroupBox.TabIndex = 9;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Details";
            // 
            // employeeGroupBox
            // 
            this.employeeGroupBox.Controls.Add(this.employeeTypeLabel);
            this.employeeGroupBox.Controls.Add(this.unassignJobButton);
            this.employeeGroupBox.Controls.Add(this.mechanicAddressTextBox);
            this.employeeGroupBox.Controls.Add(this.contractGroupBox);
            this.employeeGroupBox.Controls.Add(this.mechanicAddressLabel);
            this.employeeGroupBox.Controls.Add(this.mechanicNameTextBox);
            this.employeeGroupBox.Controls.Add(this.nameLabel);
            this.employeeGroupBox.Controls.Add(this.assignJobButton);
            this.employeeGroupBox.Controls.Add(this.mechanicJobsLabel);
            this.employeeGroupBox.Controls.Add(this.mechanicJobsListBox);
            this.employeeGroupBox.Location = new System.Drawing.Point(15, 392);
            this.employeeGroupBox.Name = "employeeGroupBox";
            this.employeeGroupBox.Size = new System.Drawing.Size(672, 192);
            this.employeeGroupBox.TabIndex = 1;
            this.employeeGroupBox.TabStop = false;
            this.employeeGroupBox.Text = "Employee";
            // 
            // employeeTypeLabel
            // 
            this.employeeTypeLabel.AutoSize = true;
            this.employeeTypeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.employeeTypeLabel.Location = new System.Drawing.Point(579, 20);
            this.employeeTypeLabel.Name = "employeeTypeLabel";
            this.employeeTypeLabel.Size = new System.Drawing.Size(110, 20);
            this.employeeTypeLabel.TabIndex = 23;
            this.employeeTypeLabel.Text = "employeeType";
            this.employeeTypeLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // unassignJobButton
            // 
            this.unassignJobButton.Enabled = false;
            this.unassignJobButton.Location = new System.Drawing.Point(514, 154);
            this.unassignJobButton.Name = "unassignJobButton";
            this.unassignJobButton.Size = new System.Drawing.Size(140, 29);
            this.unassignJobButton.TabIndex = 21;
            this.unassignJobButton.Text = "Unassign job";
            this.unassignJobButton.UseVisualStyleBackColor = true;
            this.unassignJobButton.Click += new System.EventHandler(this.unassignJobButton_Click);
            // 
            // mechanicAddressTextBox
            // 
            this.mechanicAddressTextBox.Enabled = false;
            this.mechanicAddressTextBox.Location = new System.Drawing.Point(85, 53);
            this.mechanicAddressTextBox.Name = "mechanicAddressTextBox";
            this.mechanicAddressTextBox.Size = new System.Drawing.Size(263, 27);
            this.mechanicAddressTextBox.TabIndex = 19;
            this.mechanicAddressTextBox.TextChanged += new System.EventHandler(this.mechanicAddressTextBox_TextChanged);
            // 
            // contractGroupBox
            // 
            this.contractGroupBox.Controls.Add(this.contractTypeLabel);
            this.contractGroupBox.Controls.Add(this.contractTypeTextLabel);
            this.contractGroupBox.Controls.Add(this.hoursTextBox);
            this.contractGroupBox.Controls.Add(this.salaryTextBox);
            this.contractGroupBox.Controls.Add(this.hoursTextLabel);
            this.contractGroupBox.Controls.Add(this.salaryTextLabel);
            this.contractGroupBox.Controls.Add(this.changeContractButton);
            this.contractGroupBox.Location = new System.Drawing.Point(7, 86);
            this.contractGroupBox.Name = "contractGroupBox";
            this.contractGroupBox.Size = new System.Drawing.Size(350, 97);
            this.contractGroupBox.TabIndex = 17;
            this.contractGroupBox.TabStop = false;
            this.contractGroupBox.Text = "Contract";
            // 
            // contractTypeLabel
            // 
            this.contractTypeLabel.AutoSize = true;
            this.contractTypeLabel.Location = new System.Drawing.Point(66, 61);
            this.contractTypeLabel.Name = "contractTypeLabel";
            this.contractTypeLabel.Size = new System.Drawing.Size(94, 20);
            this.contractTypeLabel.TabIndex = 20;
            this.contractTypeLabel.Text = "contractType";
            // 
            // contractTypeTextLabel
            // 
            this.contractTypeTextLabel.AutoSize = true;
            this.contractTypeTextLabel.Location = new System.Drawing.Point(8, 61);
            this.contractTypeTextLabel.Name = "contractTypeTextLabel";
            this.contractTypeTextLabel.Size = new System.Drawing.Size(43, 20);
            this.contractTypeTextLabel.TabIndex = 19;
            this.contractTypeTextLabel.Text = "Type:";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Enabled = false;
            this.hoursTextBox.Location = new System.Drawing.Point(241, 24);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.ReadOnly = true;
            this.hoursTextBox.Size = new System.Drawing.Size(100, 27);
            this.hoursTextBox.TabIndex = 18;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Enabled = false;
            this.salaryTextBox.Location = new System.Drawing.Point(66, 24);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.ReadOnly = true;
            this.salaryTextBox.Size = new System.Drawing.Size(100, 27);
            this.salaryTextBox.TabIndex = 17;
            // 
            // hoursTextLabel
            // 
            this.hoursTextLabel.AutoSize = true;
            this.hoursTextLabel.Location = new System.Drawing.Point(184, 27);
            this.hoursTextLabel.Name = "hoursTextLabel";
            this.hoursTextLabel.Size = new System.Drawing.Size(51, 20);
            this.hoursTextLabel.TabIndex = 17;
            this.hoursTextLabel.Text = "Hours:";
            // 
            // salaryTextLabel
            // 
            this.salaryTextLabel.AutoSize = true;
            this.salaryTextLabel.Location = new System.Drawing.Point(8, 27);
            this.salaryTextLabel.Name = "salaryTextLabel";
            this.salaryTextLabel.Size = new System.Drawing.Size(52, 20);
            this.salaryTextLabel.TabIndex = 16;
            this.salaryTextLabel.Text = "Salary:";
            // 
            // changeContractButton
            // 
            this.changeContractButton.Enabled = false;
            this.changeContractButton.Location = new System.Drawing.Point(221, 57);
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
            this.mechanicAddressLabel.Location = new System.Drawing.Point(6, 56);
            this.mechanicAddressLabel.Name = "mechanicAddressLabel";
            this.mechanicAddressLabel.Size = new System.Drawing.Size(65, 20);
            this.mechanicAddressLabel.TabIndex = 20;
            this.mechanicAddressLabel.Text = "Address:";
            // 
            // mechanicNameTextBox
            // 
            this.mechanicNameTextBox.Enabled = false;
            this.mechanicNameTextBox.Location = new System.Drawing.Point(85, 20);
            this.mechanicNameTextBox.Name = "mechanicNameTextBox";
            this.mechanicNameTextBox.Size = new System.Drawing.Size(263, 27);
            this.mechanicNameTextBox.TabIndex = 16;
            this.mechanicNameTextBox.TextChanged += new System.EventHandler(this.mechanicNameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(5, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 20);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name:";
            // 
            // assignJobButton
            // 
            this.assignJobButton.Location = new System.Drawing.Point(363, 154);
            this.assignJobButton.Name = "assignJobButton";
            this.assignJobButton.Size = new System.Drawing.Size(145, 29);
            this.assignJobButton.TabIndex = 18;
            this.assignJobButton.Text = "Assign job";
            this.assignJobButton.UseVisualStyleBackColor = true;
            this.assignJobButton.Click += new System.EventHandler(this.assignJobButton_Click);
            // 
            // mechanicJobsLabel
            // 
            this.mechanicJobsLabel.AutoSize = true;
            this.mechanicJobsLabel.Location = new System.Drawing.Point(362, 23);
            this.mechanicJobsLabel.Name = "mechanicJobsLabel";
            this.mechanicJobsLabel.Size = new System.Drawing.Size(41, 20);
            this.mechanicJobsLabel.TabIndex = 16;
            this.mechanicJobsLabel.Text = "Jobs:";
            // 
            // mechanicJobsListBox
            // 
            this.mechanicJobsListBox.FormattingEnabled = true;
            this.mechanicJobsListBox.ItemHeight = 20;
            this.mechanicJobsListBox.Location = new System.Drawing.Point(362, 46);
            this.mechanicJobsListBox.Name = "mechanicJobsListBox";
            this.mechanicJobsListBox.Size = new System.Drawing.Size(292, 104);
            this.mechanicJobsListBox.Sorted = true;
            this.mechanicJobsListBox.TabIndex = 10;
            // 
            // jobDetailsGroupBox
            // 
            this.jobDetailsGroupBox.Controls.Add(this.jobStatusTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.customerGroupBox);
            this.jobDetailsGroupBox.Controls.Add(this.carGroupBox);
            this.jobDetailsGroupBox.Controls.Add(this.receiptButton);
            this.jobDetailsGroupBox.Controls.Add(this.jobNotesTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.notesLabel);
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
            this.jobDetailsGroupBox.Size = new System.Drawing.Size(672, 363);
            this.jobDetailsGroupBox.TabIndex = 0;
            this.jobDetailsGroupBox.TabStop = false;
            this.jobDetailsGroupBox.Text = "Job";
            // 
            // jobStatusTextBox
            // 
            this.jobStatusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobStatusTextBox.Location = new System.Drawing.Point(100, 51);
            this.jobStatusTextBox.Name = "jobStatusTextBox";
            this.jobStatusTextBox.ReadOnly = true;
            this.jobStatusTextBox.Size = new System.Drawing.Size(212, 27);
            this.jobStatusTextBox.TabIndex = 24;
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.customerPhoneTextBox);
            this.customerGroupBox.Controls.Add(this.customerAddressTextBox);
            this.customerGroupBox.Controls.Add(this.customerEmailTextBox);
            this.customerGroupBox.Controls.Add(this.customerNameTextBox);
            this.customerGroupBox.Controls.Add(this.customerPhoneLabel);
            this.customerGroupBox.Controls.Add(this.customerEmailLabel);
            this.customerGroupBox.Controls.Add(this.customerAddressLabel);
            this.customerGroupBox.Controls.Add(this.customerNameLabel);
            this.customerGroupBox.Location = new System.Drawing.Point(318, 199);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(348, 156);
            this.customerGroupBox.TabIndex = 23;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customer";
            // 
            // customerPhoneTextBox
            // 
            this.customerPhoneTextBox.Location = new System.Drawing.Point(78, 119);
            this.customerPhoneTextBox.Name = "customerPhoneTextBox";
            this.customerPhoneTextBox.Size = new System.Drawing.Size(264, 27);
            this.customerPhoneTextBox.TabIndex = 15;
            this.customerPhoneTextBox.TextChanged += new System.EventHandler(this.customerPhoneTextBox_TextChanged);
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.Location = new System.Drawing.Point(78, 53);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.Size = new System.Drawing.Size(264, 27);
            this.customerAddressTextBox.TabIndex = 14;
            this.customerAddressTextBox.TextChanged += new System.EventHandler(this.customerAddressTextBox_TextChanged);
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Location = new System.Drawing.Point(78, 86);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.Size = new System.Drawing.Size(264, 27);
            this.customerEmailTextBox.TabIndex = 13;
            this.customerEmailTextBox.TextChanged += new System.EventHandler(this.customerEmailTextBox_TextChanged);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(78, 20);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(264, 27);
            this.customerNameTextBox.TabIndex = 12;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
            // 
            // customerPhoneLabel
            // 
            this.customerPhoneLabel.AutoSize = true;
            this.customerPhoneLabel.Location = new System.Drawing.Point(6, 122);
            this.customerPhoneLabel.Name = "customerPhoneLabel";
            this.customerPhoneLabel.Size = new System.Drawing.Size(53, 20);
            this.customerPhoneLabel.TabIndex = 11;
            this.customerPhoneLabel.Text = "Phone:";
            // 
            // customerEmailLabel
            // 
            this.customerEmailLabel.AutoSize = true;
            this.customerEmailLabel.Location = new System.Drawing.Point(6, 89);
            this.customerEmailLabel.Name = "customerEmailLabel";
            this.customerEmailLabel.Size = new System.Drawing.Size(49, 20);
            this.customerEmailLabel.TabIndex = 10;
            this.customerEmailLabel.Text = "Email:";
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Location = new System.Drawing.Point(6, 56);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(65, 20);
            this.customerAddressLabel.TabIndex = 9;
            this.customerAddressLabel.Text = "Address:";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(6, 23);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(52, 20);
            this.customerNameLabel.TabIndex = 8;
            this.customerNameLabel.Text = "Name:";
            // 
            // carGroupBox
            // 
            this.carGroupBox.Controls.Add(this.carModelTextBox);
            this.carGroupBox.Controls.Add(this.carColorTextBox);
            this.carGroupBox.Controls.Add(this.carBrandTextBox);
            this.carGroupBox.Controls.Add(this.carPlateTextBox);
            this.carGroupBox.Controls.Add(this.carModelLabel);
            this.carGroupBox.Controls.Add(this.carBrandLabel);
            this.carGroupBox.Controls.Add(this.carColorLabel);
            this.carGroupBox.Controls.Add(this.carPlateLabel);
            this.carGroupBox.Location = new System.Drawing.Point(6, 199);
            this.carGroupBox.Name = "carGroupBox";
            this.carGroupBox.Size = new System.Drawing.Size(306, 156);
            this.carGroupBox.TabIndex = 22;
            this.carGroupBox.TabStop = false;
            this.carGroupBox.Text = "Car";
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Enabled = false;
            this.carModelTextBox.Location = new System.Drawing.Point(78, 86);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.ReadOnly = true;
            this.carModelTextBox.Size = new System.Drawing.Size(222, 27);
            this.carModelTextBox.TabIndex = 15;
            // 
            // carColorTextBox
            // 
            this.carColorTextBox.Enabled = false;
            this.carColorTextBox.Location = new System.Drawing.Point(78, 119);
            this.carColorTextBox.Name = "carColorTextBox";
            this.carColorTextBox.ReadOnly = true;
            this.carColorTextBox.Size = new System.Drawing.Size(222, 27);
            this.carColorTextBox.TabIndex = 14;
            // 
            // carBrandTextBox
            // 
            this.carBrandTextBox.Enabled = false;
            this.carBrandTextBox.Location = new System.Drawing.Point(78, 53);
            this.carBrandTextBox.Name = "carBrandTextBox";
            this.carBrandTextBox.ReadOnly = true;
            this.carBrandTextBox.Size = new System.Drawing.Size(222, 27);
            this.carBrandTextBox.TabIndex = 13;
            // 
            // carPlateTextBox
            // 
            this.carPlateTextBox.Enabled = false;
            this.carPlateTextBox.Location = new System.Drawing.Point(78, 20);
            this.carPlateTextBox.Name = "carPlateTextBox";
            this.carPlateTextBox.ReadOnly = true;
            this.carPlateTextBox.Size = new System.Drawing.Size(222, 27);
            this.carPlateTextBox.TabIndex = 12;
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Location = new System.Drawing.Point(6, 89);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(55, 20);
            this.carModelLabel.TabIndex = 11;
            this.carModelLabel.Text = "Model:";
            // 
            // carBrandLabel
            // 
            this.carBrandLabel.AutoSize = true;
            this.carBrandLabel.Location = new System.Drawing.Point(6, 56);
            this.carBrandLabel.Name = "carBrandLabel";
            this.carBrandLabel.Size = new System.Drawing.Size(51, 20);
            this.carBrandLabel.TabIndex = 10;
            this.carBrandLabel.Text = "Brand:";
            // 
            // carColorLabel
            // 
            this.carColorLabel.AutoSize = true;
            this.carColorLabel.Location = new System.Drawing.Point(6, 122);
            this.carColorLabel.Name = "carColorLabel";
            this.carColorLabel.Size = new System.Drawing.Size(48, 20);
            this.carColorLabel.TabIndex = 9;
            this.carColorLabel.Text = "Color:";
            // 
            // carPlateLabel
            // 
            this.carPlateLabel.AutoSize = true;
            this.carPlateLabel.Location = new System.Drawing.Point(6, 23);
            this.carPlateLabel.Name = "carPlateLabel";
            this.carPlateLabel.Size = new System.Drawing.Size(45, 20);
            this.carPlateLabel.TabIndex = 8;
            this.carPlateLabel.Text = "Plate:";
            // 
            // receiptButton
            // 
            this.receiptButton.Enabled = false;
            this.receiptButton.Location = new System.Drawing.Point(535, 19);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(131, 29);
            this.receiptButton.TabIndex = 21;
            this.receiptButton.Text = "Show receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // jobNotesTextBox
            // 
            this.jobNotesTextBox.Enabled = false;
            this.jobNotesTextBox.Location = new System.Drawing.Point(100, 143);
            this.jobNotesTextBox.Multiline = true;
            this.jobNotesTextBox.Name = "jobNotesTextBox";
            this.jobNotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jobNotesTextBox.Size = new System.Drawing.Size(567, 50);
            this.jobNotesTextBox.TabIndex = 20;
            this.jobNotesTextBox.TextChanged += new System.EventHandler(this.jobNotesTextBox_TextChanged);
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(7, 143);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(51, 20);
            this.notesLabel.TabIndex = 17;
            this.notesLabel.Text = "Notes:";
            // 
            // jobStatusComboBox
            // 
            this.jobStatusComboBox.FormattingEnabled = true;
            this.jobStatusComboBox.Location = new System.Drawing.Point(100, 51);
            this.jobStatusComboBox.Name = "jobStatusComboBox";
            this.jobStatusComboBox.Size = new System.Drawing.Size(213, 28);
            this.jobStatusComboBox.TabIndex = 2;
            this.jobStatusComboBox.Visible = false;
            this.jobStatusComboBox.SelectedValueChanged += new System.EventHandler(this.jobStatusComboBox_SelectedValueChanged);
            // 
            // jobPriceTextBox
            // 
            this.jobPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobPriceTextBox.Enabled = false;
            this.jobPriceTextBox.Location = new System.Drawing.Point(453, 52);
            this.jobPriceTextBox.Name = "jobPriceTextBox";
            this.jobPriceTextBox.ReadOnly = true;
            this.jobPriceTextBox.Size = new System.Drawing.Size(213, 27);
            this.jobPriceTextBox.TabIndex = 15;
            // 
            // jobStatusLabel
            // 
            this.jobStatusLabel.AutoSize = true;
            this.jobStatusLabel.Location = new System.Drawing.Point(6, 54);
            this.jobStatusLabel.Name = "jobStatusLabel";
            this.jobStatusLabel.Size = new System.Drawing.Size(52, 20);
            this.jobStatusLabel.TabIndex = 13;
            this.jobStatusLabel.Text = "Status:";
            // 
            // jobPriceLabel
            // 
            this.jobPriceLabel.AutoSize = true;
            this.jobPriceLabel.Location = new System.Drawing.Point(374, 55);
            this.jobPriceLabel.Name = "jobPriceLabel";
            this.jobPriceLabel.Size = new System.Drawing.Size(44, 20);
            this.jobPriceLabel.TabIndex = 11;
            this.jobPriceLabel.Text = "Price:";
            // 
            // jobDateLabel
            // 
            this.jobDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDateLabel.AutoSize = true;
            this.jobDateLabel.Location = new System.Drawing.Point(99, 23);
            this.jobDateLabel.Name = "jobDateLabel";
            this.jobDateLabel.Size = new System.Drawing.Size(63, 20);
            this.jobDateLabel.TabIndex = 10;
            this.jobDateLabel.Text = "jobDate";
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
            this.jobDescriptionTextBox.Enabled = false;
            this.jobDescriptionTextBox.Location = new System.Drawing.Point(100, 87);
            this.jobDescriptionTextBox.Multiline = true;
            this.jobDescriptionTextBox.Name = "jobDescriptionTextBox";
            this.jobDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jobDescriptionTextBox.Size = new System.Drawing.Size(566, 50);
            this.jobDescriptionTextBox.TabIndex = 1;
            this.jobDescriptionTextBox.TextChanged += new System.EventHandler(this.jobDescriptionTextBox_TextChanged);
            // 
            // jobDateTextLabel
            // 
            this.jobDateTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDateTextLabel.AutoSize = true;
            this.jobDateTextLabel.Location = new System.Drawing.Point(7, 23);
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
            this.fireButton.Click += new System.EventHandler(this.fireButton_Click);
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
            this.hireButton.Click += new System.EventHandler(this.hireButton_Click);
            // 
            // profitButton
            // 
            this.profitButton.Location = new System.Drawing.Point(6, 26);
            this.profitButton.Name = "profitButton";
            this.profitButton.Size = new System.Drawing.Size(131, 29);
            this.profitButton.TabIndex = 24;
            this.profitButton.Text = "Calculate profit";
            this.profitButton.UseVisualStyleBackColor = true;
            // 
            // garageGroupBox
            // 
            this.garageGroupBox.Controls.Add(this.profitButton);
            this.garageGroupBox.Location = new System.Drawing.Point(266, 622);
            this.garageGroupBox.Name = "garageGroupBox";
            this.garageGroupBox.Size = new System.Drawing.Size(703, 68);
            this.garageGroupBox.TabIndex = 12;
            this.garageGroupBox.TabStop = false;
            this.garageGroupBox.Text = "Garage";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.garageGroupBox);
            this.Controls.Add(this.fireButton);
            this.Controls.Add(this.hireButton);
            this.Controls.Add(this.detailsGroupBox);
            this.Controls.Add(this.removeJobButton);
            this.Controls.Add(this.addJobButton);
            this.Controls.Add(this.employeesLabel);
            this.Controls.Add(this.employeesListBox);
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
            this.employeeGroupBox.ResumeLayout(false);
            this.employeeGroupBox.PerformLayout();
            this.contractGroupBox.ResumeLayout(false);
            this.contractGroupBox.PerformLayout();
            this.jobDetailsGroupBox.ResumeLayout(false);
            this.jobDetailsGroupBox.PerformLayout();
            this.customerGroupBox.ResumeLayout(false);
            this.customerGroupBox.PerformLayout();
            this.carGroupBox.ResumeLayout(false);
            this.carGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.garageGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label userLabel;
        private ListBox jobsListBox;
        private Label jobsLabel;
        private Button logoutButton;
        private ListBox employeesListBox;
        private Label employeesLabel;
        private Button addJobButton;
        private Button removeJobButton;
        private GroupBox detailsGroupBox;
        private BindingSource employeesBindingSource;
        private GroupBox employeeGroupBox;
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
        private Button fireButton;
        private Button hireButton;
        private TextBox jobNotesTextBox;
        private Button receiptButton;
        private Label contractTypeLabel;
        private Label contractTypeTextLabel;
        private GroupBox carGroupBox;
        private Button profitButton;
        private GroupBox garageGroupBox;
        private TextBox carModelTextBox;
        private TextBox carColorTextBox;
        private TextBox carBrandTextBox;
        private TextBox carPlateTextBox;
        private Label carModelLabel;
        private Label carBrandLabel;
        private Label carColorLabel;
        private Label carPlateLabel;
        private GroupBox customerGroupBox;
        private TextBox customerPhoneTextBox;
        private TextBox customerAddressTextBox;
        private TextBox customerEmailTextBox;
        private TextBox customerNameTextBox;
        private Label customerPhoneLabel;
        private Label customerEmailLabel;
        private Label customerAddressLabel;
        private Label customerNameLabel;
        private Label employeeTypeLabel;
        private TextBox jobStatusTextBox;
    }
}