namespace My_DVLD_Desktop.Applications.Licenses
{
    partial class frmPersonHistoryLicenses
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlPersonDetailsWithFilter1 = new My_DVLD_Desktop.ctrlPersonDetailsWithFilter();
            this.ctrlDriverLicenses1 = new My_DVLD_Desktop.Drivers.Controls.ctrlDriverLicenses();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(467, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "License History";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1129, 816);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::My_DVLD_Desktop.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(18, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlPersonDetailsWithFilter1
            // 
            this.ctrlPersonDetailsWithFilter1.Location = new System.Drawing.Point(257, 41);
            this.ctrlPersonDetailsWithFilter1.Name = "ctrlPersonDetailsWithFilter1";
            this.ctrlPersonDetailsWithFilter1.ShowAddPerson = false;
            this.ctrlPersonDetailsWithFilter1.ShowFilterBox = false;
            this.ctrlPersonDetailsWithFilter1.Size = new System.Drawing.Size(990, 419);
            this.ctrlPersonDetailsWithFilter1.TabIndex = 18;
            this.ctrlPersonDetailsWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonDetailsWithFilter1_OnPersonSelected);
            // 
            // ctrlDriverLicenses1
            // 
            this.ctrlDriverLicenses1.Location = new System.Drawing.Point(12, 445);
            this.ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            this.ctrlDriverLicenses1.Size = new System.Drawing.Size(1235, 365);
            this.ctrlDriverLicenses1.TabIndex = 19;
            // 
            // frmPersonHistoryLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 860);
            this.Controls.Add(this.ctrlPersonDetailsWithFilter1);
            this.Controls.Add(this.ctrlDriverLicenses1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPersonHistoryLicenses";
            this.Text = "frmPersonHistoryLicenses";
            this.Load += new System.EventHandler(this.frmPersonHistoryLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private ctrlPersonDetailsWithFilter ctrlPersonDetailsWithFilter1;
        private Drivers.Controls.ctrlDriverLicenses ctrlDriverLicenses1;
    }
}