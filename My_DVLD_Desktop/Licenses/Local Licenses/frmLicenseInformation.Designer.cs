namespace My_DVLD_Desktop.Applications.Licenses
{
    partial class frmLicenseInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlLicenseInfo2 = new My_DVLD_Desktop.Applications.Licenses.Controls.ctrlLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(437, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Driver License Info";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnClose.Location = new System.Drawing.Point(1035, 619);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 36);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::My_DVLD_Desktop.Properties.Resources.LicenseView_400;
            this.pictureBox1.Location = new System.Drawing.Point(467, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlLicenseInfo2
            // 
            this.ctrlLicenseInfo2.Location = new System.Drawing.Point(3, 213);
            this.ctrlLicenseInfo2.Name = "ctrlLicenseInfo2";
            this.ctrlLicenseInfo2.Size = new System.Drawing.Size(1144, 400);
            this.ctrlLicenseInfo2.TabIndex = 17;
            // 
            // frmLicenseInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.ctrlLicenseInfo2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLicenseInformation";
            this.Text = "frmLicenseInformation";
            this.Load += new System.EventHandler(this.frmLicenseInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private Controls.ctrlLicenseInfo ctrlLicenseInfo1;
        private Controls.ctrlLicenseInfo ctrlLicenseInfo2;
    }
}