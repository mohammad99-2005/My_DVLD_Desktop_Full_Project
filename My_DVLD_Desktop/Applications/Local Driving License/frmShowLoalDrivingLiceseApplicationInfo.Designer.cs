namespace My_DVLD_Desktop.Applications.Local_Driving_License
{
    partial class frmShowLoalDrivingLiceseApplicationInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseInfo1
            // 
            this.ctrlLocalDrivingLicenseInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlLocalDrivingLicenseInfo1.Name = "ctrlLocalDrivingLicenseInfo1";
            this.ctrlLocalDrivingLicenseInfo1.Size = new System.Drawing.Size(934, 369);
            this.ctrlLocalDrivingLicenseInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(837, 387);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowLoalDrivingLiceseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 433);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlLocalDrivingLicenseInfo1);
            this.Name = "frmShowLoalDrivingLiceseApplicationInfo";
            this.Text = "frmShowLoalDrivingLiceseApplicationInfo";
            this.Load += new System.EventHandler(this.frmShowLoalDrivingLiceseApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Tests.Test_Types.ctrlLocalDrivingLicenseInfo ctrlLocalDrivingLicenseInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}