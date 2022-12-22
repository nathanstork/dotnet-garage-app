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
            this.customerGroupBox.SuspendLayout();
            this.carGroupBox.SuspendLayout();
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
            // jobDetailsGroupBox
            // 
            this.jobDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDetailsGroupBox.Controls.Add(this.customerGroupBox);
            this.jobDetailsGroupBox.Controls.Add(this.carGroupBox);
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
            this.jobDetailsGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.jobDetailsGroupBox.Size = new System.Drawing.Size(703, 521);
            this.jobDetailsGroupBox.TabIndex = 0;
            this.jobDetailsGroupBox.TabStop = false;
            this.jobDetailsGroupBox.Text = "Job";
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
            this.customerGroupBox.Location = new System.Drawing.Point(342, 352);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(348, 156);
            this.customerGroupBox.TabIndex = 25;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "Customer";
            // 
            // customerPhoneTextBox
            // 
            this.customerPhoneTextBox.Location = new System.Drawing.Point(78, 119);
            this.customerPhoneTextBox.Name = "customerPhoneTextBox";
            this.customerPhoneTextBox.ReadOnly = true;
            this.customerPhoneTextBox.Size = new System.Drawing.Size(264, 27);
            this.customerPhoneTextBox.TabIndex = 15;
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.Location = new System.Drawing.Point(78, 53);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.ReadOnly = true;
            this.customerAddressTextBox.Size = new System.Drawing.Size(264, 27);
            this.customerAddressTextBox.TabIndex = 14;
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Location = new System.Drawing.Point(78, 86);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.ReadOnly = true;
            this.customerEmailTextBox.Size = new System.Drawing.Size(264, 27);
            this.customerEmailTextBox.TabIndex = 13;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(78, 20);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.ReadOnly = true;
            this.customerNameTextBox.Size = new System.Drawing.Size(264, 27);
            this.customerNameTextBox.TabIndex = 12;
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
            this.carGroupBox.Location = new System.Drawing.Point(13, 352);
            this.carGroupBox.Name = "carGroupBox";
            this.carGroupBox.Size = new System.Drawing.Size(306, 156);
            this.carGroupBox.TabIndex = 24;
            this.carGroupBox.TabStop = false;
            this.carGroupBox.Text = "Car";
            // 
            // carModelTextBox
            // 
            this.carModelTextBox.Location = new System.Drawing.Point(78, 86);
            this.carModelTextBox.Name = "carModelTextBox";
            this.carModelTextBox.ReadOnly = true;
            this.carModelTextBox.Size = new System.Drawing.Size(222, 27);
            this.carModelTextBox.TabIndex = 15;
            // 
            // carColorTextBox
            // 
            this.carColorTextBox.Location = new System.Drawing.Point(78, 119);
            this.carColorTextBox.Name = "carColorTextBox";
            this.carColorTextBox.ReadOnly = true;
            this.carColorTextBox.Size = new System.Drawing.Size(222, 27);
            this.carColorTextBox.TabIndex = 14;
            // 
            // carBrandTextBox
            // 
            this.carBrandTextBox.Location = new System.Drawing.Point(78, 53);
            this.carBrandTextBox.Name = "carBrandTextBox";
            this.carBrandTextBox.ReadOnly = true;
            this.carBrandTextBox.Size = new System.Drawing.Size(222, 27);
            this.carBrandTextBox.TabIndex = 13;
            // 
            // carPlateTextBox
            // 
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
            // notesTextBox
            // 
            this.notesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTextBox.Enabled = false;
            this.notesTextBox.Location = new System.Drawing.Point(107, 241);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesTextBox.Size = new System.Drawing.Size(583, 105);
            this.notesTextBox.TabIndex = 18;
            this.notesTextBox.TextChanged += new System.EventHandler(this.notesTextBox_TextChanged);
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(13, 241);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(51, 20);
            this.notesLabel.TabIndex = 17;
            this.notesLabel.Text = "Notes:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Enabled = false;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(107, 27);
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
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(107, 61);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(176, 27);
            this.priceTextBox.TabIndex = 15;
            // 
            // jobStatusLabel
            // 
            this.jobStatusLabel.AutoSize = true;
            this.jobStatusLabel.Location = new System.Drawing.Point(13, 30);
            this.jobStatusLabel.Name = "jobStatusLabel";
            this.jobStatusLabel.Size = new System.Drawing.Size(52, 20);
            this.jobStatusLabel.TabIndex = 13;
            this.jobStatusLabel.Text = "Status:";
            // 
            // jobPriceLabel
            // 
            this.jobPriceLabel.AutoSize = true;
            this.jobPriceLabel.Location = new System.Drawing.Point(13, 64);
            this.jobPriceLabel.Name = "jobPriceLabel";
            this.jobPriceLabel.Size = new System.Drawing.Size(44, 20);
            this.jobPriceLabel.TabIndex = 11;
            this.jobPriceLabel.Text = "Price:";
            // 
            // jobDateLabel
            // 
            this.jobDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDateLabel.AutoSize = true;
            this.jobDateLabel.Location = new System.Drawing.Point(678, 30);
            this.jobDateLabel.Name = "jobDateLabel";
            this.jobDateLabel.Size = new System.Drawing.Size(0, 20);
            this.jobDateLabel.TabIndex = 10;
            // 
            // jobDescriptionLabel
            // 
            this.jobDescriptionLabel.AutoSize = true;
            this.jobDescriptionLabel.Location = new System.Drawing.Point(13, 97);
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
            this.descriptionTextBox.Location = new System.Drawing.Point(107, 94);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(583, 141);
            this.descriptionTextBox.TabIndex = 1;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // jobDateTextLabel
            // 
            this.jobDateTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDateTextLabel.AutoSize = true;
            this.jobDateTextLabel.Location = new System.Drawing.Point(537, 30);
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
            this.customerGroupBox.ResumeLayout(false);
            this.customerGroupBox.PerformLayout();
            this.carGroupBox.ResumeLayout(false);
            this.carGroupBox.PerformLayout();
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
        private GroupBox customerGroupBox;
        private TextBox customerPhoneTextBox;
        private TextBox customerAddressTextBox;
        private TextBox customerEmailTextBox;
        private TextBox customerNameTextBox;
        private Label customerPhoneLabel;
        private Label customerEmailLabel;
        private Label customerAddressLabel;
        private Label customerNameLabel;
        private GroupBox carGroupBox;
        private TextBox carModelTextBox;
        private TextBox carColorTextBox;
        private TextBox carBrandTextBox;
        private TextBox carPlateTextBox;
        private Label carModelLabel;
        private Label carBrandLabel;
        private Label carColorLabel;
        private Label carPlateLabel;
    }
}