namespace GarageApp
{
    partial class AuthenticationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationForm));
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.errorLabel);
            this.loginGroupBox.Controls.Add(this.passwordLabel);
            this.loginGroupBox.Controls.Add(this.usernameLabel);
            this.loginGroupBox.Controls.Add(this.passTextBox);
            this.loginGroupBox.Controls.Add(this.userTextBox);
            this.loginGroupBox.Controls.Add(this.submitButton);
            this.loginGroupBox.Location = new System.Drawing.Point(116, 76);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(450, 275);
            this.loginGroupBox.TabIndex = 6;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Login";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(75, 176);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 6;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(75, 118);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 20);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(75, 46);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(75, 20);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(75, 141);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '●';
            this.passTextBox.Size = new System.Drawing.Size(300, 27);
            this.passTextBox.TabIndex = 2;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            this.passTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTextBox_KeyDown);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(75, 69);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(300, 27);
            this.userTextBox.TabIndex = 1;
            this.userTextBox.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            this.userTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userTextBox_KeyDown);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(275, 211);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 30);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.loginGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthenticationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox loginGroupBox;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passTextBox;
        private TextBox userTextBox;
        private Button submitButton;
        private Label errorLabel;
    }
}