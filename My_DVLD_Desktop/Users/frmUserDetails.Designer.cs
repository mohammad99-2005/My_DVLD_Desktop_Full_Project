namespace My_DVLD_Desktop.Users
{
    partial class frmUserDetails
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
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlUserDetails1 = new My_DVLD_Desktop.Users.ctrlUserDetails();
            this.SuspendLayout();
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDetails.ForeColor = System.Drawing.Color.Brown;
            this.lblUserDetails.Location = new System.Drawing.Point(387, 23);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(208, 38);
            this.lblUserDetails.TabIndex = 5;
            this.lblUserDetails.Text = "User Details";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(894, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlUserDetails1
            // 
            this.ctrlUserDetails1.Location = new System.Drawing.Point(3, 81);
            this.ctrlUserDetails1.Name = "ctrlUserDetails1";
            this.ctrlUserDetails1.Size = new System.Drawing.Size(989, 419);
            this.ctrlUserDetails1.TabIndex = 7;
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 569);
            this.Controls.Add(this.ctrlUserDetails1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUserDetails);
            this.Name = "frmUserDetails";
            this.Text = "frmUserDetails";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.Button button1;
        private ctrlUserDetails ctrlUserDetails1;
    }
}