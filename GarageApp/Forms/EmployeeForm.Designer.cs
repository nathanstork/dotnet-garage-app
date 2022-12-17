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
            this.contractGroupBox = new System.Windows.Forms.GroupBox();
            this.contractTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.weeklyRadioButton = new System.Windows.Forms.RadioButton();
            this.monthlyRadioButton = new System.Windows.Forms.RadioButton();
            this.hoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.salaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.personalDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.employeeTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.managerRadioButton = new System.Windows.Forms.RadioButton();
            this.mechanicRadioButton = new System.Windows.Forms.RadioButton();
            this.contractGroupBox.SuspendLayout();
            this.contractTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).BeginInit();
            this.personalDetailsGroupBox.SuspendLayout();
            this.loginGroupBox.SuspendLayout();
            this.employeeTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(124, 663);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(174, 40);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // contractGroupBox
            // 
            this.contractGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.contractGroupBox.Controls.Add(this.contractTypeGroupBox);
            this.contractGroupBox.Controls.Add(this.hoursNumericUpDown);
            this.contractGroupBox.Controls.Add(this.hoursLabel);
            this.contractGroupBox.Controls.Add(this.salaryLabel);
            this.contractGroupBox.Controls.Add(this.salaryNumericUpDown);
            this.contractGroupBox.Location = new System.Drawing.Point(28, 486);
            this.contractGroupBox.Name = "contractGroupBox";
            this.contractGroupBox.Size = new System.Drawing.Size(383, 158);
            this.contractGroupBox.TabIndex = 17;
            this.contractGroupBox.TabStop = false;
            this.contractGroupBox.Text = "Contract";
            // 
            // contractTypeGroupBox
            // 
            this.contractTypeGroupBox.Controls.Add(this.weeklyRadioButton);
            this.contractTypeGroupBox.Controls.Add(this.monthlyRadioButton);
            this.contractTypeGroupBox.Location = new System.Drawing.Point(13, 31);
            this.contractTypeGroupBox.Name = "contractTypeGroupBox";
            this.contractTypeGroupBox.Size = new System.Drawing.Size(151, 110);
            this.contractTypeGroupBox.TabIndex = 6;
            this.contractTypeGroupBox.TabStop = false;
            this.contractTypeGroupBox.Text = "Type";
            // 
            // weeklyRadioButton
            // 
            this.weeklyRadioButton.AutoSize = true;
            this.weeklyRadioButton.Location = new System.Drawing.Point(13, 58);
            this.weeklyRadioButton.Name = "weeklyRadioButton";
            this.weeklyRadioButton.Size = new System.Drawing.Size(77, 24);
            this.weeklyRadioButton.TabIndex = 1;
            this.weeklyRadioButton.Text = "Weekly";
            this.weeklyRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthlyRadioButton
            // 
            this.monthlyRadioButton.AutoSize = true;
            this.monthlyRadioButton.Checked = true;
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
            this.hoursNumericUpDown.Location = new System.Drawing.Point(187, 107);
            this.hoursNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.hoursNumericUpDown.Name = "hoursNumericUpDown";
            this.hoursNumericUpDown.Size = new System.Drawing.Size(175, 27);
            this.hoursNumericUpDown.TabIndex = 7;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(188, 84);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(48, 20);
            this.hoursLabel.TabIndex = 9;
            this.hoursLabel.Text = "Hours";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(187, 25);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(49, 20);
            this.salaryLabel.TabIndex = 10;
            this.salaryLabel.Text = "Salary";
            // 
            // salaryNumericUpDown
            // 
            this.salaryNumericUpDown.Location = new System.Drawing.Point(187, 50);
            this.salaryNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.salaryNumericUpDown.Name = "salaryNumericUpDown";
            this.salaryNumericUpDown.Size = new System.Drawing.Size(175, 27);
            this.salaryNumericUpDown.TabIndex = 8;
            // 
            // personalDetailsGroupBox
            // 
            this.personalDetailsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.personalDetailsGroupBox.Controls.Add(this.addressLabel);
            this.personalDetailsGroupBox.Controls.Add(this.nameTextBox);
            this.personalDetailsGroupBox.Controls.Add(this.addressTextBox);
            this.personalDetailsGroupBox.Controls.Add(this.nameLabel);
            this.personalDetailsGroupBox.Location = new System.Drawing.Point(28, 332);
            this.personalDetailsGroupBox.Name = "personalDetailsGroupBox";
            this.personalDetailsGroupBox.Size = new System.Drawing.Size(383, 148);
            this.personalDetailsGroupBox.TabIndex = 16;
            this.personalDetailsGroupBox.TabStop = false;
            this.personalDetailsGroupBox.Text = "Personal details";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(13, 76);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 20);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(13, 46);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(357, 27);
            this.nameTextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(13, 99);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(357, 27);
            this.addressTextBox.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.loginGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginGroupBox.Controls.Add(this.repeatPasswordLabel);
            this.loginGroupBox.Controls.Add(this.repeatPasswordTextBox);
            this.loginGroupBox.Controls.Add(this.passwordLabel);
            this.loginGroupBox.Controls.Add(this.passwordTextBox);
            this.loginGroupBox.Controls.Add(this.usernameLabel);
            this.loginGroupBox.Controls.Add(this.usernameTextBox);
            this.loginGroupBox.Location = new System.Drawing.Point(28, 119);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.loginGroupBox.Size = new System.Drawing.Size(383, 207);
            this.loginGroupBox.TabIndex = 15;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Login credentials";
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(13, 136);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(123, 20);
            this.repeatPasswordLabel.TabIndex = 5;
            this.repeatPasswordLabel.Text = "Repeat password";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(13, 159);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.PasswordChar = '●';
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(357, 27);
            this.repeatPasswordTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(13, 83);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 20);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(13, 106);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(357, 27);
            this.passwordTextBox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(13, 30);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(75, 20);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(13, 53);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(357, 27);
            this.usernameTextBox.TabIndex = 0;
            // 
            // employeeTypeGroupBox
            // 
            this.employeeTypeGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.employeeTypeGroupBox.Controls.Add(this.managerRadioButton);
            this.employeeTypeGroupBox.Controls.Add(this.mechanicRadioButton);
            this.employeeTypeGroupBox.Location = new System.Drawing.Point(28, 18);
            this.employeeTypeGroupBox.Name = "employeeTypeGroupBox";
            this.employeeTypeGroupBox.Size = new System.Drawing.Size(383, 95);
            this.employeeTypeGroupBox.TabIndex = 18;
            this.employeeTypeGroupBox.TabStop = false;
            this.employeeTypeGroupBox.Text = "Type";
            // 
            // managerRadioButton
            // 
            this.managerRadioButton.AutoSize = true;
            this.managerRadioButton.Location = new System.Drawing.Point(17, 56);
            this.managerRadioButton.Name = "managerRadioButton";
            this.managerRadioButton.Size = new System.Drawing.Size(89, 24);
            this.managerRadioButton.TabIndex = 1;
            this.managerRadioButton.Text = "Manager";
            this.managerRadioButton.UseVisualStyleBackColor = true;
            // 
            // mechanicRadioButton
            // 
            this.mechanicRadioButton.AutoSize = true;
            this.mechanicRadioButton.Checked = true;
            this.mechanicRadioButton.Location = new System.Drawing.Point(17, 26);
            this.mechanicRadioButton.Name = "mechanicRadioButton";
            this.mechanicRadioButton.Size = new System.Drawing.Size(93, 24);
            this.mechanicRadioButton.TabIndex = 0;
            this.mechanicRadioButton.TabStop = true;
            this.mechanicRadioButton.Text = "Mechanic";
            this.mechanicRadioButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(439, 731);
            this.Controls.Add(this.employeeTypeGroupBox);
            this.Controls.Add(this.contractGroupBox);
            this.Controls.Add(this.personalDetailsGroupBox);
            this.Controls.Add(this.loginGroupBox);
            this.Controls.Add(this.submitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmployeeForm";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hire new employee";
            this.contractGroupBox.ResumeLayout(false);
            this.contractGroupBox.PerformLayout();
            this.contractTypeGroupBox.ResumeLayout(false);
            this.contractTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumericUpDown)).EndInit();
            this.personalDetailsGroupBox.ResumeLayout(false);
            this.personalDetailsGroupBox.PerformLayout();
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.employeeTypeGroupBox.ResumeLayout(false);
            this.employeeTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button submitButton;
        private GroupBox contractGroupBox;
        private GroupBox contractTypeGroupBox;
        private RadioButton weeklyRadioButton;
        private RadioButton monthlyRadioButton;
        private NumericUpDown hoursNumericUpDown;
        private Label salaryLabel;
        private NumericUpDown salaryNumericUpDown;
        private Label hoursLabel;
        private GroupBox personalDetailsGroupBox;
        private Label addressLabel;
        private TextBox nameTextBox;
        private TextBox addressTextBox;
        private Label nameLabel;
        private GroupBox loginGroupBox;
        private Label repeatPasswordLabel;
        private TextBox repeatPasswordTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private GroupBox employeeTypeGroupBox;
        private RadioButton managerRadioButton;
        private RadioButton mechanicRadioButton;
    }
}