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
            this.jobsListBox = new System.Windows.Forms.ListBox();
            this.mechanicsLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mechanicsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(22, 19);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(0, 20);
            this.testLabel.TabIndex = 0;
            this.testLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jobsListBox
            // 
            this.jobsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.jobsListBox.FormattingEnabled = true;
            this.jobsListBox.ItemHeight = 20;
            this.jobsListBox.Location = new System.Drawing.Point(22, 116);
            this.jobsListBox.Name = "jobsListBox";
            this.jobsListBox.Size = new System.Drawing.Size(224, 364);
            this.jobsListBox.TabIndex = 2;
            // 
            // mechanicsLabel
            // 
            this.mechanicsLabel.AutoSize = true;
            this.mechanicsLabel.Location = new System.Drawing.Point(22, 93);
            this.mechanicsLabel.Name = "mechanicsLabel";
            this.mechanicsLabel.Size = new System.Drawing.Size(38, 20);
            this.mechanicsLabel.TabIndex = 3;
            this.mechanicsLabel.Text = "Jobs";
            this.mechanicsLabel.Click += new System.EventHandler(this.mechanicsLabel_Click);
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
            this.mechanicsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mechanicsListBox.FormattingEnabled = true;
            this.mechanicsListBox.ItemHeight = 20;
            this.mechanicsListBox.Location = new System.Drawing.Point(282, 116);
            this.mechanicsListBox.Name = "mechanicsListBox";
            this.mechanicsListBox.Size = new System.Drawing.Size(224, 364);
            this.mechanicsListBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mechanics";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(22, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add job";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(146, 495);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Remove job";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(545, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 489);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // MechanicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mechanicsListBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.mechanicsLabel);
            this.Controls.Add(this.jobsListBox);
            this.Controls.Add(this.testLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MechanicForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garage App v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label testLabel;
        private ListBox jobsListBox;
        private Label mechanicsLabel;
        private Button logoutButton;
        private ListBox mechanicsListBox;
        private Label label1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
    }
}