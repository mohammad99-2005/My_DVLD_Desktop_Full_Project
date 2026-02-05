namespace My_DVLD_Desktop.Applications.Licenses
{
    partial class frmReplaceLicenseForDamageOrLost
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
            this.lbllShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lbllShowHistory = new System.Windows.Forms.LinkLabel();
            this.gpApplicationInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblRenewedLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReplacement = new System.Windows.Forms.Button();
            this.ctrlLicenseInfoWithFilter1 = new My_DVLD_Desktop.Applications.Licenses.Controls.ctrlLicenseInfoWithFilter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbReplacementFilter = new System.Windows.Forms.GroupBox();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.rbDamage = new System.Windows.Forms.RadioButton();
            this.gpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gbReplacementFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbllShowLicenseInfo
            // 
            this.lbllShowLicenseInfo.AutoSize = true;
            this.lbllShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllShowLicenseInfo.Location = new System.Drawing.Point(210, 685);
            this.lbllShowLicenseInfo.Name = "lbllShowLicenseInfo";
            this.lbllShowLicenseInfo.Size = new System.Drawing.Size(175, 18);
            this.lbllShowLicenseInfo.TabIndex = 186;
            this.lbllShowLicenseInfo.TabStop = true;
            this.lbllShowLicenseInfo.Text = "Show New License Ifo";
            this.lbllShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllShowLicenseInfo_LinkClicked);
            // 
            // lbllShowHistory
            // 
            this.lbllShowHistory.AutoSize = true;
            this.lbllShowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllShowHistory.Location = new System.Drawing.Point(20, 685);
            this.lbllShowHistory.Name = "lbllShowHistory";
            this.lbllShowHistory.Size = new System.Drawing.Size(172, 18);
            this.lbllShowHistory.TabIndex = 185;
            this.lbllShowHistory.TabStop = true;
            this.lbllShowHistory.Text = "Show License History";
            this.lbllShowHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllShowHistory_LinkClicked);
            // 
            // gpApplicationInfo
            // 
            this.gpApplicationInfo.Controls.Add(this.pictureBox8);
            this.gpApplicationInfo.Controls.Add(this.lblOldLicenseID);
            this.gpApplicationInfo.Controls.Add(this.label12);
            this.gpApplicationInfo.Controls.Add(this.pictureBox7);
            this.gpApplicationInfo.Controls.Add(this.lblRenewedLicenseID);
            this.gpApplicationInfo.Controls.Add(this.label10);
            this.gpApplicationInfo.Controls.Add(this.pictureBox2);
            this.gpApplicationInfo.Controls.Add(this.pictureBox1);
            this.gpApplicationInfo.Controls.Add(this.label2);
            this.gpApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.gpApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.gpApplicationInfo.Controls.Add(this.label4);
            this.gpApplicationInfo.Controls.Add(this.pictureBox3);
            this.gpApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.gpApplicationInfo.Controls.Add(this.pictureBox4);
            this.gpApplicationInfo.Controls.Add(this.label5);
            this.gpApplicationInfo.Controls.Add(this.lblApplicationID);
            this.gpApplicationInfo.Controls.Add(this.label11);
            this.gpApplicationInfo.Location = new System.Drawing.Point(12, 519);
            this.gpApplicationInfo.Name = "gpApplicationInfo";
            this.gpApplicationInfo.Size = new System.Drawing.Size(1146, 147);
            this.gpApplicationInfo.TabIndex = 184;
            this.gpApplicationInfo.TabStop = false;
            this.gpApplicationInfo.Text = "Application New License Info";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::My_DVLD_Desktop.Properties.Resources.Number_32;
            this.pictureBox8.Location = new System.Drawing.Point(885, 70);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 195;
            this.pictureBox8.TabStop = false;
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.Location = new System.Drawing.Point(923, 70);
            this.lblOldLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(62, 25);
            this.lblOldLicenseID.TabIndex = 194;
            this.lblOldLicenseID.Text = "[???]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(626, 71);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 25);
            this.label12.TabIndex = 193;
            this.label12.Text = "Old License ID:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::My_DVLD_Desktop.Properties.Resources.Number_32;
            this.pictureBox7.Location = new System.Drawing.Point(885, 38);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 192;
            this.pictureBox7.TabStop = false;
            // 
            // lblRenewedLicenseID
            // 
            this.lblRenewedLicenseID.AutoSize = true;
            this.lblRenewedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewedLicenseID.Location = new System.Drawing.Point(923, 38);
            this.lblRenewedLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRenewedLicenseID.Name = "lblRenewedLicenseID";
            this.lblRenewedLicenseID.Size = new System.Drawing.Size(62, 25);
            this.lblRenewedLicenseID.TabIndex = 191;
            this.lblRenewedLicenseID.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(626, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 25);
            this.label10.TabIndex = 190;
            this.label10.Text = "Replacement License ID:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::My_DVLD_Desktop.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(239, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 183;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_DVLD_Desktop.Properties.Resources.User_32__2;
            this.pictureBox1.Location = new System.Drawing.Point(885, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 182;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(626, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 181;
            this.label2.Text = "Created By:";
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.Location = new System.Drawing.Point(923, 103);
            this.lblCreatedByUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(74, 25);
            this.lblCreatedByUser.TabIndex = 180;
            this.lblCreatedByUser.Text = "[????]";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(289, 104);
            this.lblApplicationFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(62, 25);
            this.lblApplicationFees.TabIndex = 179;
            this.lblApplicationFees.Text = "[$$$]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 177;
            this.label4.Text = "Application Fees:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::My_DVLD_Desktop.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(239, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 178;
            this.pictureBox3.TabStop = false;
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(289, 70);
            this.lblApplicationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(136, 25);
            this.lblApplicationDate.TabIndex = 176;
            this.lblApplicationDate.Text = "[??/??/????]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::My_DVLD_Desktop.Properties.Resources.Calendar_32;
            this.pictureBox4.Location = new System.Drawing.Point(239, 71);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 175;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 174;
            this.label5.Text = "Application Date:";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(289, 38);
            this.lblApplicationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(62, 25);
            this.lblApplicationID.TabIndex = 173;
            this.lblApplicationID.Text = "[???]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 39);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 25);
            this.label11.TabIndex = 172;
            this.label11.Text = "L.R.Application ID:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::My_DVLD_Desktop.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(847, 674);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 41);
            this.btnClose.TabIndex = 188;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReplacement
            // 
            this.btnReplacement.BackColor = System.Drawing.Color.White;
            this.btnReplacement.Enabled = false;
            this.btnReplacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplacement.Image = global::My_DVLD_Desktop.Properties.Resources.Renew_Driving_License_32;
            this.btnReplacement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplacement.Location = new System.Drawing.Point(963, 674);
            this.btnReplacement.Name = "btnReplacement";
            this.btnReplacement.Size = new System.Drawing.Size(193, 41);
            this.btnReplacement.TabIndex = 187;
            this.btnReplacement.Text = "Issue Replacement";
            this.btnReplacement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReplacement.UseVisualStyleBackColor = false;
            this.btnReplacement.Click += new System.EventHandler(this.btnReplacement_Click);
            // 
            // ctrlLicenseInfoWithFilter1
            // 
            this.ctrlLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlLicenseInfoWithFilter1.Location = new System.Drawing.Point(8, 42);
            this.ctrlLicenseInfoWithFilter1.Name = "ctrlLicenseInfoWithFilter1";
            this.ctrlLicenseInfoWithFilter1.Size = new System.Drawing.Size(1148, 471);
            this.ctrlLicenseInfoWithFilter1.TabIndex = 189;
            this.ctrlLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Location = new System.Drawing.Point(377, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 36);
            this.lblTitle.TabIndex = 190;
            this.lblTitle.Text = "Replacement For Damage";
            // 
            // gbReplacementFilter
            // 
            this.gbReplacementFilter.Controls.Add(this.rbLost);
            this.gbReplacementFilter.Controls.Add(this.rbDamage);
            this.gbReplacementFilter.Location = new System.Drawing.Point(781, 42);
            this.gbReplacementFilter.Name = "gbReplacementFilter";
            this.gbReplacementFilter.Size = new System.Drawing.Size(375, 79);
            this.gbReplacementFilter.TabIndex = 191;
            this.gbReplacementFilter.TabStop = false;
            this.gbReplacementFilter.Text = "Replacement For";
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Location = new System.Drawing.Point(19, 47);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(160, 20);
            this.rbLost.TabIndex = 1;
            this.rbLost.TabStop = true;
            this.rbLost.Text = "Replacement For Lost";
            this.rbLost.UseVisualStyleBackColor = true;
            this.rbLost.CheckedChanged += new System.EventHandler(this.rbLost_CheckedChanged);
            // 
            // rbDamage
            // 
            this.rbDamage.AutoSize = true;
            this.rbDamage.Location = new System.Drawing.Point(19, 21);
            this.rbDamage.Name = "rbDamage";
            this.rbDamage.Size = new System.Drawing.Size(188, 20);
            this.rbDamage.TabIndex = 0;
            this.rbDamage.TabStop = true;
            this.rbDamage.Text = "Replacement For Damage";
            this.rbDamage.UseVisualStyleBackColor = true;
            this.rbDamage.CheckedChanged += new System.EventHandler(this.rbDamage_CheckedChanged);
            // 
            // frmReplaceLicenseForDamageOrLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 727);
            this.Controls.Add(this.gbReplacementFilter);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlLicenseInfoWithFilter1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReplacement);
            this.Controls.Add(this.lbllShowLicenseInfo);
            this.Controls.Add(this.lbllShowHistory);
            this.Controls.Add(this.gpApplicationInfo);
            this.Name = "frmReplaceLicenseForDamageOrLost";
            this.Text = "frmReplaceLicenseForDamageOrLost";
            this.Load += new System.EventHandler(this.frmReplaceLicenseForDamageOrLost_Load);
            this.gpApplicationInfo.ResumeLayout(false);
            this.gpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gbReplacementFilter.ResumeLayout(false);
            this.gbReplacementFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReplacement;
        private System.Windows.Forms.LinkLabel lbllShowLicenseInfo;
        private System.Windows.Forms.LinkLabel lbllShowHistory;
        private System.Windows.Forms.GroupBox gpApplicationInfo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblRenewedLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label11;
        private Controls.ctrlLicenseInfoWithFilter ctrlLicenseInfoWithFilter1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbReplacementFilter;
        private System.Windows.Forms.RadioButton rbLost;
        private System.Windows.Forms.RadioButton rbDamage;
    }
}