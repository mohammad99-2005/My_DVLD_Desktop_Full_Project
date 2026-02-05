namespace My_DVLD_Desktop.Applications.International
{
    partial class frmInternationalLicenesInfo
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
            this.internationalLicenseInformation1 = new My_DVLD_Desktop.Applications.International.Controls.InternationalLicenseInformation();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(306, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 36);
            this.label1.TabIndex = 200;
            this.label1.Text = "International License Information";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::My_DVLD_Desktop.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1049, 344);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 36);
            this.btnClose.TabIndex = 205;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // internationalLicenseInformation1
            // 
            this.internationalLicenseInformation1.Location = new System.Drawing.Point(12, 62);
            this.internationalLicenseInformation1.Name = "internationalLicenseInformation1";
            this.internationalLicenseInformation1.Size = new System.Drawing.Size(1160, 283);
            this.internationalLicenseInformation1.TabIndex = 0;
            // 
            // frmInternationalLicenesInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 392);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.internationalLicenseInformation1);
            this.Name = "frmInternationalLicenesInfo";
            this.Text = "frmInternationalLicenesInfo";
            this.Load += new System.EventHandler(this.frmInternationalLicenesInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.InternationalLicenseInformation internationalLicenseInformation1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}