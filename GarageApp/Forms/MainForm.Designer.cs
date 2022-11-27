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
            this.mechanicsListBox = new System.Windows.Forms.ListBox();
            this.mechanicsLabel = new System.Windows.Forms.Label();
            this.addJobButton = new System.Windows.Forms.Button();
            this.removeJobButton = new System.Windows.Forms.Button();
            this.detailsGroupBox = new System.Windows.Forms.GroupBox();
            this.mechanicDetailsGroupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.jobDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.jobStatusComboBox = new System.Windows.Forms.ComboBox();
            this.jobPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.jobStatusLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jobPriceLabel = new System.Windows.Forms.Label();
            this.jobDetailsDateLabel = new System.Windows.Forms.Label();
            this.jobDescriptionLabel = new System.Windows.Forms.Label();
            this.jobDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.jobDateLabel = new System.Windows.Forms.Label();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailsGroupBox.SuspendLayout();
            this.mechanicDetailsGroupBox2.SuspendLayout();
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
            this.jobsListBox.Size = new System.Drawing.Size(224, 184);
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
            this.mechanicsListBox.Location = new System.Drawing.Point(22, 358);
            this.mechanicsListBox.Name = "mechanicsListBox";
            this.mechanicsListBox.Size = new System.Drawing.Size(224, 184);
            this.mechanicsListBox.TabIndex = 5;
            this.mechanicsListBox.SelectedValueChanged += new System.EventHandler(this.mechanicsListBox_SelectedValueChanged);
            // 
            // mechanicsLabel
            // 
            this.mechanicsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mechanicsLabel.AutoSize = true;
            this.mechanicsLabel.Location = new System.Drawing.Point(22, 335);
            this.mechanicsLabel.Name = "mechanicsLabel";
            this.mechanicsLabel.Size = new System.Drawing.Size(78, 20);
            this.mechanicsLabel.TabIndex = 6;
            this.mechanicsLabel.Text = "Mechanics";
            // 
            // addJobButton
            // 
            this.addJobButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addJobButton.Location = new System.Drawing.Point(22, 294);
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
            this.removeJobButton.Location = new System.Drawing.Point(146, 294);
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
            this.detailsGroupBox.Location = new System.Drawing.Point(266, 42);
            this.detailsGroupBox.Name = "detailsGroupBox";
            this.detailsGroupBox.Size = new System.Drawing.Size(694, 489);
            this.detailsGroupBox.TabIndex = 9;
            this.detailsGroupBox.TabStop = false;
            this.detailsGroupBox.Text = "Details";
            // 
            // mechanicDetailsGroupBox2
            // 
            this.mechanicDetailsGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mechanicDetailsGroupBox2.Controls.Add(this.button1);
            this.mechanicDetailsGroupBox2.Location = new System.Drawing.Point(15, 252);
            this.mechanicDetailsGroupBox2.Name = "mechanicDetailsGroupBox2";
            this.mechanicDetailsGroupBox2.Size = new System.Drawing.Size(663, 220);
            this.mechanicDetailsGroupBox2.TabIndex = 1;
            this.mechanicDetailsGroupBox2.TabStop = false;
            this.mechanicDetailsGroupBox2.Text = "Mechanic";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // jobDetailsGroupBox
            // 
            this.jobDetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDetailsGroupBox.Controls.Add(this.jobStatusComboBox);
            this.jobDetailsGroupBox.Controls.Add(this.jobPriceTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.label5);
            this.jobDetailsGroupBox.Controls.Add(this.jobStatusLabel);
            this.jobDetailsGroupBox.Controls.Add(this.label3);
            this.jobDetailsGroupBox.Controls.Add(this.jobPriceLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobDetailsDateLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobDescriptionLabel);
            this.jobDetailsGroupBox.Controls.Add(this.jobDescriptionTextBox);
            this.jobDetailsGroupBox.Controls.Add(this.jobDateLabel);
            this.jobDetailsGroupBox.Location = new System.Drawing.Point(15, 26);
            this.jobDetailsGroupBox.Name = "jobDetailsGroupBox";
            this.jobDetailsGroupBox.Size = new System.Drawing.Size(663, 220);
            this.jobDetailsGroupBox.TabIndex = 0;
            this.jobDetailsGroupBox.TabStop = false;
            this.jobDetailsGroupBox.Text = "Job";
            // 
            // jobStatusComboBox
            // 
            this.jobStatusComboBox.FormattingEnabled = true;
            this.jobStatusComboBox.Location = new System.Drawing.Point(100, 20);
            this.jobStatusComboBox.Name = "jobStatusComboBox";
            this.jobStatusComboBox.Size = new System.Drawing.Size(176, 28);
            this.jobStatusComboBox.TabIndex = 2;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 14;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 12;
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
            // jobDetailsDateLabel
            // 
            this.jobDetailsDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDetailsDateLabel.AutoSize = true;
            this.jobDetailsDateLabel.Location = new System.Drawing.Point(581, 23);
            this.jobDetailsDateLabel.Name = "jobDetailsDateLabel";
            this.jobDetailsDateLabel.Size = new System.Drawing.Size(0, 20);
            this.jobDetailsDateLabel.TabIndex = 10;
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
            this.jobDescriptionTextBox.Location = new System.Drawing.Point(100, 87);
            this.jobDescriptionTextBox.Multiline = true;
            this.jobDescriptionTextBox.Name = "jobDescriptionTextBox";
            this.jobDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jobDescriptionTextBox.Size = new System.Drawing.Size(554, 127);
            this.jobDescriptionTextBox.TabIndex = 1;
            // 
            // jobDateLabel
            // 
            this.jobDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jobDateLabel.AutoSize = true;
            this.jobDateLabel.Location = new System.Drawing.Point(531, 23);
            this.jobDateLabel.Name = "jobDateLabel";
            this.jobDateLabel.Size = new System.Drawing.Size(44, 20);
            this.jobDateLabel.TabIndex = 0;
            this.jobDateLabel.Text = "Date:";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(GarageApp.Employees);
            // 
            // MechanicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.detailsGroupBox);
            this.Controls.Add(this.removeJobButton);
            this.Controls.Add(this.addJobButton);
            this.Controls.Add(this.mechanicsLabel);
            this.Controls.Add(this.mechanicsListBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.jobsLabel);
            this.Controls.Add(this.jobsListBox);
            this.Controls.Add(this.userLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MechanicForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garage App v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.detailsGroupBox.ResumeLayout(false);
            this.mechanicDetailsGroupBox2.ResumeLayout(false);
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
        private Button button1;
        private Label jobDetailsDateLabel;
        private Label jobDescriptionLabel;
        private TextBox jobDescriptionTextBox;
        private Label jobDateLabel;
        private TextBox jobPriceTextBox;
        private Label label5;
        private Label jobStatusLabel;
        private Label label3;
        private Label jobPriceLabel;
        private ComboBox jobStatusComboBox;
    }
}