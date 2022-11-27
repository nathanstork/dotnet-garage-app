namespace GarageApp.Forms
{
    partial class RemoveJobForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveJobForm));
            this.label1 = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to remove this job?";
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(53, 160);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(123, 40);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "This action can not be reversed.";
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(206, 160);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(123, 40);
            this.noButton.TabIndex = 3;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // RemoveJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoveJobForm";
            this.Padding = new System.Windows.Forms.Padding(50);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Warning!";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button yesButton;
        private Label label2;
        private Button noButton;
    }
}