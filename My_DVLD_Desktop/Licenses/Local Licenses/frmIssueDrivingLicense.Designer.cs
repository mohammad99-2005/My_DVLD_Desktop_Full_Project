namespace My_DVLD_Desktop.Applications.Local_Driving_License
{
    partial class frmIssueDrivingLicense
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
            this.ctrlLocalDrivingLicenseInfo1 = new My_DVLD_Desktop.Applications.Tests.Test_Types.ctrlLocalDrivingLicenseInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNotes = new System.Windows.Forms.TextBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseInfo1
            // 
            this.ctrlLocalDrivingLicenseInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlLocalDrivingLicenseInfo1.Name = "ctrlLocalDrivingLicenseInfo1";
            this.ctrlLocalDrivingLicenseInfo1.Size = new System.Drawing.Size(934, 369);
            this.ctrlLocalDrivingLicenseInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(58, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notes:";
            // 
            // txtbNotes
            // 
            this.txtbNotes.Location = new System.Drawing.Point(132, 397);
            this.txtbNotes.Multiline = true;
            this.txtbNotes.Name = "txtbNotes";
            this.txtbNotes.Size = new System.Drawing.Size(814, 163);
            this.txtbNotes.TabIndex = 3;
            // 
            // btnIssue
            // 
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Image = global::My_DVLD_Desktop.Properties.Resources.IssueDrivingLicense_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(829, 584);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(117, 36);
            this.btnIssue.TabIndex = 5;
            this.btnIssue.Text = "Issue";
            this.btnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::My_DVLD_Desktop.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(688, 584);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::My_DVLD_Desktop.Properties.Resources.Notes_32;
            this.pictureBox1.Location = new System.Drawing.Point(12, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 35);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmIssueDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 632);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtbNotes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlLocalDrivingLicenseInfo1);
            this.Name = "frmIssueDrivingLicense";
            this.Text = "frmIssueDrivingLicense";
            this.Load += new System.EventHandler(this.frmIssueDrivingLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tests.Test_Types.ctrlLocalDrivingLicenseInfo ctrlLocalDrivingLicenseInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbNotes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
    }
}