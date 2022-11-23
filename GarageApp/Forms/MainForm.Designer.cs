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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MechanicForm));
            this.testLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mechanicsListBox = new System.Windows.Forms.ListBox();
            this.mechanicsLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testLabel
            // 
            this.testLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(788, 9);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(0, 20);
            this.testLabel.TabIndex = 0;
            this.testLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(353, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mechanicsListBox
            // 
            this.mechanicsListBox.FormattingEnabled = true;
            this.mechanicsListBox.ItemHeight = 20;
            this.mechanicsListBox.Location = new System.Drawing.Point(12, 29);
            this.mechanicsListBox.Name = "mechanicsListBox";
            this.mechanicsListBox.Size = new System.Drawing.Size(250, 404);
            this.mechanicsListBox.TabIndex = 2;
            // 
            // mechanicsLabel
            // 
            this.mechanicsLabel.AutoSize = true;
            this.mechanicsLabel.Location = new System.Drawing.Point(12, 6);
            this.mechanicsLabel.Name = "mechanicsLabel";
            this.mechanicsLabel.Size = new System.Drawing.Size(50, 20);
            this.mechanicsLabel.TabIndex = 3;
            this.mechanicsLabel.Text = "label1";
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Location = new System.Drawing.Point(720, 32);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(68, 29);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // MechanicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.mechanicsLabel);
            this.Controls.Add(this.mechanicsListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MechanicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garage App v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label testLabel;
        private Button button1;
        private ListBox mechanicsListBox;
        private Label mechanicsLabel;
        private Button logoutButton;
    }
}