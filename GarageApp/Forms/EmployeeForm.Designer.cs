namespace GarageApp.Forms
{
    partial class EmployeeForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.employeeTabControl = new System.Windows.Forms.TabControl();
            this.mechanicTabPage = new System.Windows.Forms.TabPage();
            this.contractGroupBox = new System.Windows.Forms.GroupBox();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.weeklyRadioButton = new System.Windows.Forms.RadioButton();
            this.monthlyRadioButton = new System.Windows.Forms.RadioButton();
            this.hoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.salaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.mechanicPersonalDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.mechanicPersonalDetailsErrorLabel = new System.Windows.Forms.Label();
            this.mechanicAddressLabel = new System.Windows.Forms.Label();
            this.mechanicNameTextBox = new System.Windows.Forms.TextBox();
            this.mechanicAddressTextBox = new System.Windows.Forms.TextBox();
            this.mechanicNameLabel = new System.Windows.Forms.Label();
            this.mechanicLoginGroupBox = new System.Windows.Forms.GroupBox();
            this.mechanicLoginErrorLabel = new System.Windows.Forms.Label();
            this.mechanicRepeatPasswordLabel = new System.Windows.Forms.Label();
            this.mechanicRepeatPasswordTextbox = new System.Windows.Forms.TextBox();
            this.mechanicPasswordLabel = new System.Windows.Forms.Label();
            this.mechanicPasswordTextbox = new System.Windows.Forms.TextBox();
            this.mechanicUsernameLabel = new System.Windows.Forms.Label();
            this.mechanicUsernameTextBox = new System.Windows.Forms.TextBox();
            this.managerTabPage = new System.Windows.Forms.TabPage();
            this.managerPersonalDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.managerPersonalDetailsErrorLabel = new System.Windows.Forms.Label();
            this.managerAddressLabel = new System.Windows.Forms.Label();
            this.managerNameTextBox = new System.Windows.Forms.TextBox();
            this.managerAddressTextBox = new System.Windows.Forms.TextBox();
            this.managerNameLabel = new System.Windows.Forms.Label();
            this.managerLoginGroupBox = new System.Windows.Forms.GroupBox();
            this.managerLoginErrorLabel = new System.Windows.Forms.Label();
            this.managerRepeatPasswordLabel = new System.Windows.Forms.Label();
            this.managerRepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.managerPasswordLabel = new System.Windows.Forms.Label();
            this.managerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.managerUsernameLabel = new System.Windows.Forms.Label();
            this.managerUsernameTextBox = new System.Windows.Forms.TextBox();
            this.employeeTabControl.SuspendLayout();
            this.mechanicTabPage.SuspendLayout();
            this.contractGroupBox.SuspendLayout();
            this.typeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).BeginInit();
            this.mechanicPersonalDetailsGroupBox.SuspendLayout();
            this.mechanicLoginGroupBox.SuspendLayout();
            this.managerTabPage.SuspendLayout();
            this.managerPersonalDetailsGroupBox.SuspendLayout();
            this.managerLoginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(182, 680);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(133, 40);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // employeeTabControl
            // 
            this.employeeTabControl.Controls.Add(this.mechanicTabPage);
            this.employeeTabControl.Controls.Add(this.managerTabPage);
            this.employeeTabControl.Location = new System.Drawing.Point(28, 28);
            this.employeeTabControl.Name = "employeeTabControl";
            this.employeeTabControl.SelectedIndex = 0;
            this.employeeTabControl.Size = new System.Drawing.Size(441, 630);
            this.employeeTabControl.TabIndex = 2;
            // 
            // mechanicTabPage
            // 
            this.mechanicTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mechanicTabPage.Controls.Add(this.contractGroupBox);
            this.mechanicTabPage.Controls.Add(this.mechanicPersonalDetailsGroupBox);
            this.mechanicTabPage.Controls.Add(this.mechanicLoginGroupBox);
            this.mechanicTabPage.Location = new System.Drawing.Point(4, 29);
            this.mechanicTabPage.Name = "mechanicTabPage";
            this.mechanicTabPage.Padding = new System.Windows.Forms.Padding(20);
            this.mechanicTabPage.Size = new System.Drawing.Size(433, 597);
            this.mechanicTabPage.TabIndex = 0;
            this.mechanicTabPage.Text = "Mechanic";
            // 
            // contractGroupBox
            // 
            this.contractGroupBox.Controls.Add(this.typeGroupBox);
            this.contractGroupBox.Controls.Add(this.hoursNumericUpDown);
            this.contractGroupBox.Controls.Add(this.salaryLabel);
            this.contractGroupBox.Controls.Add(this.salaryNumericUpDown);
            this.contractGroupBox.Controls.Add(this.hoursLabel);
            this.contractGroupBox.Location = new System.Drawing.Point(23, 418);
            this.contractGroupBox.Name = "contractGroupBox";
            this.contractGroupBox.Size = new System.Drawing.Size(384, 158);
            this.contractGroupBox.TabIndex = 12;
            this.contractGroupBox.TabStop = false;
            this.contractGroupBox.Text = "Contract";
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.weeklyRadioButton);
            this.typeGroupBox.Controls.Add(this.monthlyRadioButton);
            this.typeGroupBox.Location = new System.Drawing.Point(13, 31);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(176, 110);
            this.typeGroupBox.TabIndex = 6;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Type";
            // 
            // weeklyRadioButton
            // 
            this.weeklyRadioButton.AutoSize = true;
            this.weeklyRadioButton.Location = new System.Drawing.Point(13, 58);
            this.weeklyRadioButton.Name = "weeklyRadioButton";
            this.weeklyRadioButton.Size = new System.Drawing.Size(77, 24);
            this.weeklyRadioButton.TabIndex = 1;
            this.weeklyRadioButton.TabStop = true;
            this.weeklyRadioButton.Text = "Weekly";
            this.weeklyRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthlyRadioButton
            // 
            this.monthlyRadioButton.AutoSize = true;
            this.monthlyRadioButton.Location = new System.Drawing.Point(13, 28);
            this.monthlyRadioButton.Name = "monthlyRadioButton";
            this.monthlyRadioButton.Size = new System.Drawing.Size(84, 24);
            this.monthlyRadioButton.TabIndex = 0;
            this.monthlyRadioButton.TabStop = true;
            this.monthlyRadioButton.Text = "Monthly";
            this.monthlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // hoursNumericUpDown
            // 
            this.hoursNumericUpDown.Location = new System.Drawing.Point(221, 54);
            this.hoursNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.hoursNumericUpDown.Name = "hoursNumericUpDown";
            this.hoursNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.hoursNumericUpDown.TabIndex = 7;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(221, 89);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(49, 20);
            this.salaryLabel.TabIndex = 10;
            this.salaryLabel.Text = "Salary";
            // 
            // salaryNumericUpDown
            // 
            this.salaryNumericUpDown.Location = new System.Drawing.Point(221, 114);
            this.salaryNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.salaryNumericUpDown.Name = "salaryNumericUpDown";
            this.salaryNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.salaryNumericUpDown.TabIndex = 8;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(221, 31);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(48, 20);
            this.hoursLabel.TabIndex = 9;
            this.hoursLabel.Text = "Hours";
            // 
            // mechanicPersonalDetailsGroupBox
            // 
            this.mechanicPersonalDetailsGroupBox.Controls.Add(this.mechanicPersonalDetailsErrorLabel);
            this.mechanicPersonalDetailsGroupBox.Controls.Add(this.mechanicAddressLabel);
            this.mechanicPersonalDetailsGroupBox.Controls.Add(this.mechanicNameTextBox);
            this.mechanicPersonalDetailsGroupBox.Controls.Add(this.mechanicAddressTextBox);
            this.mechanicPersonalDetailsGroupBox.Controls.Add(this.mechanicNameLabel);
            this.mechanicPersonalDetailsGroupBox.Location = new System.Drawing.Point(26, 249);
            this.mechanicPersonalDetailsGroupBox.Name = "mechanicPersonalDetailsGroupBox";
            this.mechanicPersonalDetailsGroupBox.Size = new System.Drawing.Size(384, 163);
            this.mechanicPersonalDetailsGroupBox.TabIndex = 11;
            this.mechanicPersonalDetailsGroupBox.TabStop = false;
            this.mechanicPersonalDetailsGroupBox.Text = "Personal details";
            // 
            // mechanicPersonalDetailsErrorLabel
            // 
            this.mechanicPersonalDetailsErrorLabel.AutoSize = true;
            this.mechanicPersonalDetailsErrorLabel.Location = new System.Drawing.Point(13, 129);
            this.mechanicPersonalDetailsErrorLabel.Name = "mechanicPersonalDetailsErrorLabel";
            this.mechanicPersonalDetailsErrorLabel.Size = new System.Drawing.Size(205, 20);
            this.mechanicPersonalDetailsErrorLabel.TabIndex = 7;
            this.mechanicPersonalDetailsErrorLabel.Text = "mechanicPersonalDetailsError";
            // 
            // mechanicAddressLabel
            // 
            this.mechanicAddressLabel.AutoSize = true;
            this.mechanicAddressLabel.Location = new System.Drawing.Point(13, 76);
            this.mechanicAddressLabel.Name = "mechanicAddressLabel";
            this.mechanicAddressLabel.Size = new System.Drawing.Size(62, 20);
            this.mechanicAddressLabel.TabIndex = 10;
            this.mechanicAddressLabel.Text = "Address";
            // 
            // mechanicNameTextBox
            // 
            this.mechanicNameTextBox.Location = new System.Drawing.Point(13, 46);
            this.mechanicNameTextBox.Name = "mechanicNameTextBox";
            this.mechanicNameTextBox.Size = new System.Drawing.Size(358, 27);
            this.mechanicNameTextBox.TabIndex = 7;
            this.mechanicNameTextBox.TextChanged += new System.EventHandler(this.mechanicNameTextBox_TextChanged);
            // 
            // mechanicAddressTextBox
            // 
            this.mechanicAddressTextBox.Location = new System.Drawing.Point(13, 99);
            this.mechanicAddressTextBox.Name = "mechanicAddressTextBox";
            this.mechanicAddressTextBox.PasswordChar = '●';
            this.mechanicAddressTextBox.Size = new System.Drawing.Size(358, 27);
            this.mechanicAddressTextBox.TabIndex = 9;
            this.mechanicAddressTextBox.TextChanged += new System.EventHandler(this.mechanicAddressTextBox_TextChanged);
            // 
            // mechanicNameLabel
            // 
            this.mechanicNameLabel.AutoSize = true;
            this.mechanicNameLabel.Location = new System.Drawing.Point(13, 23);
            this.mechanicNameLabel.Name = "mechanicNameLabel";
            this.mechanicNameLabel.Size = new System.Drawing.Size(49, 20);
            this.mechanicNameLabel.TabIndex = 8;
            this.mechanicNameLabel.Text = "Name";
            // 
            // mechanicLoginGroupBox
            // 
            this.mechanicLoginGroupBox.Controls.Add(this.mechanicLoginErrorLabel);
            this.mechanicLoginGroupBox.Controls.Add(this.mechanicRepeatPasswordLabel);
            this.mechanicLoginGroupBox.Controls.Add(this.mechanicRepeatPasswordTextbox);
            this.mechanicLoginGroupBox.Controls.Add(this.mechanicPasswordLabel);
            this.mechanicLoginGroupBox.Controls.Add(this.mechanicPasswordTextbox);
            this.mechanicLoginGroupBox.Controls.Add(this.mechanicUsernameLabel);
            this.mechanicLoginGroupBox.Controls.Add(this.mechanicUsernameTextBox);
            this.mechanicLoginGroupBox.Location = new System.Drawing.Point(23, 23);
            this.mechanicLoginGroupBox.Name = "mechanicLoginGroupBox";
            this.mechanicLoginGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.mechanicLoginGroupBox.Size = new System.Drawing.Size(384, 220);
            this.mechanicLoginGroupBox.TabIndex = 1;
            this.mechanicLoginGroupBox.TabStop = false;
            this.mechanicLoginGroupBox.Text = "Login credentials";
            // 
            // mechanicLoginErrorLabel
            // 
            this.mechanicLoginErrorLabel.AutoSize = true;
            this.mechanicLoginErrorLabel.Location = new System.Drawing.Point(13, 190);
            this.mechanicLoginErrorLabel.Name = "mechanicLoginErrorLabel";
            this.mechanicLoginErrorLabel.Size = new System.Drawing.Size(141, 20);
            this.mechanicLoginErrorLabel.TabIndex = 6;
            this.mechanicLoginErrorLabel.Text = "mechanicLoginError";
            // 
            // mechanicRepeatPasswordLabel
            // 
            this.mechanicRepeatPasswordLabel.AutoSize = true;
            this.mechanicRepeatPasswordLabel.Location = new System.Drawing.Point(13, 136);
            this.mechanicRepeatPasswordLabel.Name = "mechanicRepeatPasswordLabel";
            this.mechanicRepeatPasswordLabel.Size = new System.Drawing.Size(123, 20);
            this.mechanicRepeatPasswordLabel.TabIndex = 5;
            this.mechanicRepeatPasswordLabel.Text = "Repeat password";
            // 
            // mechanicRepeatPasswordTextbox
            // 
            this.mechanicRepeatPasswordTextbox.Location = new System.Drawing.Point(13, 159);
            this.mechanicRepeatPasswordTextbox.Name = "mechanicRepeatPasswordTextbox";
            this.mechanicRepeatPasswordTextbox.PasswordChar = '●';
            this.mechanicRepeatPasswordTextbox.Size = new System.Drawing.Size(358, 27);
            this.mechanicRepeatPasswordTextbox.TabIndex = 4;
            this.mechanicRepeatPasswordTextbox.TextChanged += new System.EventHandler(this.mechanicRepeatPasswordTextbox_TextChanged);
            // 
            // mechanicPasswordLabel
            // 
            this.mechanicPasswordLabel.AutoSize = true;
            this.mechanicPasswordLabel.Location = new System.Drawing.Point(13, 83);
            this.mechanicPasswordLabel.Name = "mechanicPasswordLabel";
            this.mechanicPasswordLabel.Size = new System.Drawing.Size(70, 20);
            this.mechanicPasswordLabel.TabIndex = 3;
            this.mechanicPasswordLabel.Text = "Password";
            // 
            // mechanicPasswordTextbox
            // 
            this.mechanicPasswordTextbox.Location = new System.Drawing.Point(13, 106);
            this.mechanicPasswordTextbox.Name = "mechanicPasswordTextbox";
            this.mechanicPasswordTextbox.PasswordChar = '●';
            this.mechanicPasswordTextbox.Size = new System.Drawing.Size(358, 27);
            this.mechanicPasswordTextbox.TabIndex = 2;
            this.mechanicPasswordTextbox.TextChanged += new System.EventHandler(this.mechanicPasswordTextbox_TextChanged);
            // 
            // mechanicUsernameLabel
            // 
            this.mechanicUsernameLabel.AutoSize = true;
            this.mechanicUsernameLabel.Location = new System.Drawing.Point(13, 30);
            this.mechanicUsernameLabel.Name = "mechanicUsernameLabel";
            this.mechanicUsernameLabel.Size = new System.Drawing.Size(75, 20);
            this.mechanicUsernameLabel.TabIndex = 1;
            this.mechanicUsernameLabel.Text = "Username";
            // 
            // mechanicUsernameTextBox
            // 
            this.mechanicUsernameTextBox.Location = new System.Drawing.Point(13, 53);
            this.mechanicUsernameTextBox.Name = "mechanicUsernameTextBox";
            this.mechanicUsernameTextBox.Size = new System.Drawing.Size(358, 27);
            this.mechanicUsernameTextBox.TabIndex = 0;
            this.mechanicUsernameTextBox.TextChanged += new System.EventHandler(this.mechanicUsernameTextBox_TextChanged);
            // 
            // managerTabPage
            // 
            this.managerTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.managerTabPage.Controls.Add(this.managerPersonalDetailsGroupBox);
            this.managerTabPage.Controls.Add(this.managerLoginGroupBox);
            this.managerTabPage.Location = new System.Drawing.Point(4, 29);
            this.managerTabPage.Name = "managerTabPage";
            this.managerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.managerTabPage.Size = new System.Drawing.Size(433, 597);
            this.managerTabPage.TabIndex = 1;
            this.managerTabPage.Text = "Manager";
            // 
            // managerPersonalDetailsGroupBox
            // 
            this.managerPersonalDetailsGroupBox.Controls.Add(this.managerPersonalDetailsErrorLabel);
            this.managerPersonalDetailsGroupBox.Controls.Add(this.managerAddressLabel);
            this.managerPersonalDetailsGroupBox.Controls.Add(this.managerNameTextBox);
            this.managerPersonalDetailsGroupBox.Controls.Add(this.managerAddressTextBox);
            this.managerPersonalDetailsGroupBox.Controls.Add(this.managerNameLabel);
            this.managerPersonalDetailsGroupBox.Location = new System.Drawing.Point(23, 343);
            this.managerPersonalDetailsGroupBox.Name = "managerPersonalDetailsGroupBox";
            this.managerPersonalDetailsGroupBox.Size = new System.Drawing.Size(384, 163);
            this.managerPersonalDetailsGroupBox.TabIndex = 13;
            this.managerPersonalDetailsGroupBox.TabStop = false;
            this.managerPersonalDetailsGroupBox.Text = "Personal details";
            // 
            // managerPersonalDetailsErrorLabel
            // 
            this.managerPersonalDetailsErrorLabel.AutoSize = true;
            this.managerPersonalDetailsErrorLabel.Location = new System.Drawing.Point(13, 129);
            this.managerPersonalDetailsErrorLabel.Name = "managerPersonalDetailsErrorLabel";
            this.managerPersonalDetailsErrorLabel.Size = new System.Drawing.Size(201, 20);
            this.managerPersonalDetailsErrorLabel.TabIndex = 7;
            this.managerPersonalDetailsErrorLabel.Text = "managerPersonalDetailsError";
            // 
            // managerAddressLabel
            // 
            this.managerAddressLabel.AutoSize = true;
            this.managerAddressLabel.Location = new System.Drawing.Point(13, 76);
            this.managerAddressLabel.Name = "managerAddressLabel";
            this.managerAddressLabel.Size = new System.Drawing.Size(62, 20);
            this.managerAddressLabel.TabIndex = 10;
            this.managerAddressLabel.Text = "Address";
            // 
            // managerNameTextBox
            // 
            this.managerNameTextBox.Location = new System.Drawing.Point(13, 46);
            this.managerNameTextBox.Name = "managerNameTextBox";
            this.managerNameTextBox.Size = new System.Drawing.Size(358, 27);
            this.managerNameTextBox.TabIndex = 7;
            this.managerNameTextBox.TextChanged += new System.EventHandler(this.managerNameTextBox_TextChanged);
            // 
            // managerAddressTextBox
            // 
            this.managerAddressTextBox.Location = new System.Drawing.Point(13, 99);
            this.managerAddressTextBox.Name = "managerAddressTextBox";
            this.managerAddressTextBox.PasswordChar = '●';
            this.managerAddressTextBox.Size = new System.Drawing.Size(358, 27);
            this.managerAddressTextBox.TabIndex = 9;
            this.managerAddressTextBox.TextChanged += new System.EventHandler(this.managerAddressTextBox_TextChanged);
            // 
            // managerNameLabel
            // 
            this.managerNameLabel.AutoSize = true;
            this.managerNameLabel.Location = new System.Drawing.Point(13, 23);
            this.managerNameLabel.Name = "managerNameLabel";
            this.managerNameLabel.Size = new System.Drawing.Size(49, 20);
            this.managerNameLabel.TabIndex = 8;
            this.managerNameLabel.Text = "Name";
            // 
            // managerLoginGroupBox
            // 
            this.managerLoginGroupBox.Controls.Add(this.managerLoginErrorLabel);
            this.managerLoginGroupBox.Controls.Add(this.managerRepeatPasswordLabel);
            this.managerLoginGroupBox.Controls.Add(this.managerRepeatPasswordTextBox);
            this.managerLoginGroupBox.Controls.Add(this.managerPasswordLabel);
            this.managerLoginGroupBox.Controls.Add(this.managerPasswordTextBox);
            this.managerLoginGroupBox.Controls.Add(this.managerUsernameLabel);
            this.managerLoginGroupBox.Controls.Add(this.managerUsernameTextBox);
            this.managerLoginGroupBox.Location = new System.Drawing.Point(23, 91);
            this.managerLoginGroupBox.Name = "managerLoginGroupBox";
            this.managerLoginGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.managerLoginGroupBox.Size = new System.Drawing.Size(384, 220);
            this.managerLoginGroupBox.TabIndex = 12;
            this.managerLoginGroupBox.TabStop = false;
            this.managerLoginGroupBox.Text = "Login credentials";
            // 
            // managerLoginErrorLabel
            // 
            this.managerLoginErrorLabel.AutoSize = true;
            this.managerLoginErrorLabel.Location = new System.Drawing.Point(13, 190);
            this.managerLoginErrorLabel.Name = "managerLoginErrorLabel";
            this.managerLoginErrorLabel.Size = new System.Drawing.Size(137, 20);
            this.managerLoginErrorLabel.TabIndex = 6;
            this.managerLoginErrorLabel.Text = "managerLoginError";
            // 
            // managerRepeatPasswordLabel
            // 
            this.managerRepeatPasswordLabel.AutoSize = true;
            this.managerRepeatPasswordLabel.Location = new System.Drawing.Point(20, 143);
            this.managerRepeatPasswordLabel.Name = "managerRepeatPasswordLabel";
            this.managerRepeatPasswordLabel.Size = new System.Drawing.Size(123, 20);
            this.managerRepeatPasswordLabel.TabIndex = 5;
            this.managerRepeatPasswordLabel.Text = "Repeat password";
            // 
            // managerRepeatPasswordTextBox
            // 
            this.managerRepeatPasswordTextBox.Location = new System.Drawing.Point(13, 159);
            this.managerRepeatPasswordTextBox.Name = "managerRepeatPasswordTextBox";
            this.managerRepeatPasswordTextBox.PasswordChar = '●';
            this.managerRepeatPasswordTextBox.Size = new System.Drawing.Size(358, 27);
            this.managerRepeatPasswordTextBox.TabIndex = 4;
            this.managerRepeatPasswordTextBox.TextChanged += new System.EventHandler(this.managerRepeatPasswordTextBox_TextChanged);
            // 
            // managerPasswordLabel
            // 
            this.managerPasswordLabel.AutoSize = true;
            this.managerPasswordLabel.Location = new System.Drawing.Point(20, 90);
            this.managerPasswordLabel.Name = "managerPasswordLabel";
            this.managerPasswordLabel.Size = new System.Drawing.Size(70, 20);
            this.managerPasswordLabel.TabIndex = 3;
            this.managerPasswordLabel.Text = "Password";
            // 
            // managerPasswordTextBox
            // 
            this.managerPasswordTextBox.Location = new System.Drawing.Point(13, 106);
            this.managerPasswordTextBox.Name = "managerPasswordTextBox";
            this.managerPasswordTextBox.PasswordChar = '●';
            this.managerPasswordTextBox.Size = new System.Drawing.Size(358, 27);
            this.managerPasswordTextBox.TabIndex = 2;
            this.managerPasswordTextBox.TextChanged += new System.EventHandler(this.managerPasswordTextBox_TextChanged);
            // 
            // managerUsernameLabel
            // 
            this.managerUsernameLabel.AutoSize = true;
            this.managerUsernameLabel.Location = new System.Drawing.Point(20, 37);
            this.managerUsernameLabel.Name = "managerUsernameLabel";
            this.managerUsernameLabel.Size = new System.Drawing.Size(75, 20);
            this.managerUsernameLabel.TabIndex = 1;
            this.managerUsernameLabel.Text = "Username";
            // 
            // managerUsernameTextBox
            // 
            this.managerUsernameTextBox.Location = new System.Drawing.Point(13, 53);
            this.managerUsernameTextBox.Name = "managerUsernameTextBox";
            this.managerUsernameTextBox.Size = new System.Drawing.Size(358, 27);
            this.managerUsernameTextBox.TabIndex = 0;
            this.managerUsernameTextBox.TextChanged += new System.EventHandler(this.managerUsernameTextBox_TextChanged);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(497, 748);
            this.Controls.Add(this.employeeTabControl);
            this.Controls.Add(this.submitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmployeeForm";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hire new employee";
            this.employeeTabControl.ResumeLayout(false);
            this.mechanicTabPage.ResumeLayout(false);
            this.contractGroupBox.ResumeLayout(false);
            this.contractGroupBox.PerformLayout();
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
            this.mechanicPersonalDetailsGroupBox.ResumeLayout(false);
            this.mechanicPersonalDetailsGroupBox.PerformLayout();
            this.mechanicLoginGroupBox.ResumeLayout(false);
            this.mechanicLoginGroupBox.PerformLayout();
            this.managerTabPage.ResumeLayout(false);
            this.managerPersonalDetailsGroupBox.ResumeLayout(false);
            this.managerPersonalDetailsGroupBox.PerformLayout();
            this.managerLoginGroupBox.ResumeLayout(false);
            this.managerLoginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button submitButton;
        private TabControl employeeTabControl;
        private TabPage mechanicTabPage;
        private TabPage managerTabPage;
        private GroupBox mechanicLoginGroupBox;
        private Label mechanicPasswordLabel;
        private TextBox mechanicPasswordTextbox;
        private Label mechanicUsernameLabel;
        private TextBox mechanicUsernameTextBox;
        private Label mechanicRepeatPasswordLabel;
        private TextBox mechanicRepeatPasswordTextbox;
        private Label salaryLabel;
        private Label hoursLabel;
        private GroupBox typeGroupBox;
        private RadioButton weeklyRadioButton;
        private RadioButton monthlyRadioButton;
        private NumericUpDown salaryNumericUpDown;
        private NumericUpDown hoursNumericUpDown;
        private Label mechanicLoginErrorLabel;
        private GroupBox mechanicPersonalDetailsGroupBox;
        private Label mechanicPersonalDetailsErrorLabel;
        private Label mechanicAddressLabel;
        private TextBox mechanicNameTextBox;
        private TextBox mechanicAddressTextBox;
        private Label mechanicNameLabel;
        private GroupBox contractGroupBox;
        private GroupBox managerPersonalDetailsGroupBox;
        private Label managerPersonalDetailsErrorLabel;
        private Label managerAddressLabel;
        private TextBox managerNameTextBox;
        private TextBox managerAddressTextBox;
        private Label managerNameLabel;
        private GroupBox managerLoginGroupBox;
        private Label managerLoginErrorLabel;
        private Label managerRepeatPasswordLabel;
        private TextBox managerRepeatPasswordTextBox;
        private Label managerPasswordLabel;
        private TextBox managerPasswordTextBox;
        private Label managerUsernameLabel;
        private TextBox managerUsernameTextBox;
    }
}