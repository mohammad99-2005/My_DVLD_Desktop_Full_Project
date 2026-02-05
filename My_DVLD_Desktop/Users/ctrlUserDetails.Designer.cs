namespace My_DVLD_Desktop.Users
{
    partial class ctrlUserDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbUserDetails = new System.Windows.Forms.GroupBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlPersonDetails1 = new My_DVLD_Desktop.ctrlPersonDetails();
            this.gbUserDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUserDetails
            // 
            this.gbUserDetails.Controls.Add(this.lblUserID);
            this.gbUserDetails.Controls.Add(this.lblIsActive);
            this.gbUserDetails.Controls.Add(this.lblUsername);
            this.gbUserDetails.Controls.Add(this.label3);
            this.gbUserDetails.Controls.Add(this.label2);
            this.gbUserDetails.Controls.Add(this.label1);
            this.gbUserDetails.Location = new System.Drawing.Point(3, 337);
            this.gbUserDetails.Name = "gbUserDetails";
            this.gbUserDetails.Size = new System.Drawing.Size(982, 77);
            this.gbUserDetails.TabIndex = 3;
            this.gbUserDetails.TabStop = false;
            this.gbUserDetails.Text = "User Details";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.IndianRed;
            this.lblUserID.Location = new System.Drawing.Point(194, 33);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(59, 20);
            this.lblUserID.TabIndex = 5;
            this.lblUserID.Text = "?????";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.ForeColor = System.Drawing.Color.IndianRed;
            this.lblIsActive.Location = new System.Drawing.Point(832, 33);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(59, 20);
            this.lblIsActive.TabIndex = 4;
            this.lblIsActive.Text = "?????";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.IndianRed;
            this.lblUsername.Location = new System.Drawing.Point(507, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(59, 20);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "?????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(732, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Is Active :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID :";
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(982, 328);
            this.ctrlPersonDetails1.TabIndex = 2;
            // 
            // ctrlUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbUserDetails);
            this.Controls.Add(this.ctrlPersonDetails1);
            this.Name = "ctrlUserDetails";
            this.Size = new System.Drawing.Size(989, 419);
            this.Load += new System.EventHandler(this.ctrlUserDetails_Load);
            this.gbUserDetails.ResumeLayout(false);
            this.gbUserDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUserDetails;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ctrlPersonDetails ctrlPersonDetails1;
    }
}
