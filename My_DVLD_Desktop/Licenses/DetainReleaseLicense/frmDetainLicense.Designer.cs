namespace My_DVLD_Desktop.Applications.Licenses.DetainReleaseLicense
{
    partial class frmDetainLicense
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDetain = new System.Windows.Forms.Button();
            this.lbllShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.lbllShowHistory = new System.Windows.Forms.LinkLabel();
            this.gpApplicationInfo = new System.Windows.Forms.GroupBox();
            this.txtbFees = new System.Windows.Forms.TextBox();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlLicenseInfoWithFilter1 = new My_DVLD_Desktop.Applications.Licenses.Controls.ctrlLicenseInfoWithFilter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::My_DVLD_Desktop.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(921, 715);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 41);
            this.btnClose.TabIndex = 190;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.BackColor = System.Drawing.Color.White;
            this.btnDetain.Enabled = false;
            this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.Image = global::My_DVLD_Desktop.Properties.Resources.Renew_Driving_License_32;
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetain.Location = new System.Drawing.Point(1051, 715);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(107, 41);
            this.btnDetain.TabIndex = 189;
            this.btnDetain.Text = "Detain";
            this.btnDetain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetain.UseVisualStyleBackColor = false;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // lbllShowLicenseInfo
            // 
            this.lbllShowLicenseInfo.AutoSize = true;
            this.lbllShowLicenseInfo.Enabled = false;
            this.lbllShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllShowLicenseInfo.Location = new System.Drawing.Point(262, 726);
            this.lbllShowLicenseInfo.Name = "lbllShowLicenseInfo";
            this.lbllShowLicenseInfo.Size = new System.Drawing.Size(146, 18);
            this.lbllShowLicenseInfo.TabIndex = 188;
            this.lbllShowLicenseInfo.TabStop = true;
            this.lbllShowLicenseInfo.Text = "Show License Info";
            this.lbllShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllShowLicenseInfo_LinkClicked);
            // 
            // lbllShowHistory
            // 
            this.lbllShowHistory.AutoSize = true;
            this.lbllShowHistory.Enabled = false;
            this.lbllShowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllShowHistory.Location = new System.Drawing.Point(12, 726);
            this.lbllShowHistory.Name = "lbllShowHistory";
            this.lbllShowHistory.Size = new System.Drawing.Size(172, 18);
            this.lbllShowHistory.TabIndex = 187;
            this.lbllShowHistory.TabStop = true;
            this.lbllShowHistory.Text = "Show License History";
            this.lbllShowHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllShowHistory_LinkClicked);
            // 
            // gpApplicationInfo
            // 
            this.gpApplicationInfo.Controls.Add(this.txtbFees);
            this.gpApplicationInfo.Controls.Add(this.lblFineFees);
            this.gpApplicationInfo.Controls.Add(this.pictureBox10);
            this.gpApplicationInfo.Controls.Add(this.pictureBox7);
            this.gpApplicationInfo.Controls.Add(this.lblLicenseID);
            this.gpApplicationInfo.Controls.Add(this.label10);
            this.gpApplicationInfo.Controls.Add(this.pictureBox2);
            this.gpApplicationInfo.Controls.Add(this.pictureBox1);
            this.gpApplicationInfo.Controls.Add(this.label2);
            this.gpApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.gpApplicationInfo.Controls.Add(this.lblDetainDate);
            this.gpApplicationInfo.Controls.Add(this.pictureBox4);
            this.gpApplicationInfo.Controls.Add(this.label5);
            this.gpApplicationInfo.Controls.Add(this.lblDetainID);
            this.gpApplicationInfo.Controls.Add(this.label11);
            this.gpApplicationInfo.Location = new System.Drawing.Point(14, 521);
            this.gpApplicationInfo.Name = "gpApplicationInfo";
            this.gpApplicationInfo.Size = new System.Drawing.Size(1146, 188);
            this.gpApplicationInfo.TabIndex = 186;
            this.gpApplicationInfo.TabStop = false;
            this.gpApplicationInfo.Text = "Application New License Info";
            // 
            // txtbFees
            // 
            this.txtbFees.Location = new System.Drawing.Point(294, 139);
            this.txtbFees.MaxLength = 500;
            this.txtbFees.Name = "txtbFees";
            this.txtbFees.Size = new System.Drawing.Size(131, 22);
            this.txtbFees.TabIndex = 202;
            this.txtbFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFees_KeyPress);
            this.txtbFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtbFees_Validating);
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.Location = new System.Drawing.Point(47, 128);
            this.lblFineFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(121, 25);
            this.lblFineFees.TabIndex = 199;
            this.lblFineFees.Text = "Fine  Fees:";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::My_DVLD_Desktop.Properties.Resources.money_32;
            this.pictureBox10.Location = new System.Drawing.Point(239, 135);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(31, 26);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 200;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::My_DVLD_Desktop.Properties.Resources.Number_32;
            this.pictureBox7.Location = new System.Drawing.Point(783, 39);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 26);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 192;
            this.pictureBox7.TabStop = false;
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(833, 39);
            this.lblLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(62, 25);
            this.lblLicenseID.TabIndex = 191;
            this.lblLicenseID.Text = "[???]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(651, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 25);
            this.label10.TabIndex = 190;
            this.label10.Text = "License ID:";
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
            this.pictureBox1.Location = new System.Drawing.Point(783, 86);
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
            this.label2.Location = new System.Drawing.Point(651, 86);
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
            this.lblCreatedByUser.Location = new System.Drawing.Point(833, 86);
            this.lblCreatedByUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(74, 25);
            this.lblCreatedByUser.TabIndex = 180;
            this.lblCreatedByUser.Text = "[????]";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.Location = new System.Drawing.Point(289, 86);
            this.lblDetainDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(136, 25);
            this.lblDetainDate.TabIndex = 176;
            this.lblDetainDate.Text = "[??/??/????]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::My_DVLD_Desktop.Properties.Resources.Calendar_32;
            this.pictureBox4.Location = new System.Drawing.Point(239, 87);
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
            this.label5.Location = new System.Drawing.Point(45, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 174;
            this.label5.Text = "Detain Date:";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.Location = new System.Drawing.Point(289, 38);
            this.lblDetainID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(62, 25);
            this.lblDetainID.TabIndex = 173;
            this.lblDetainID.Text = "[???]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 39);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 25);
            this.label11.TabIndex = 172;
            this.label11.Text = "Detain ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(459, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 36);
            this.label1.TabIndex = 185;
            this.label1.Text = "Detain License";
            // 
            // ctrlLicenseInfoWithFilter1
            // 
            this.ctrlLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlLicenseInfoWithFilter1.Location = new System.Drawing.Point(12, 41);
            this.ctrlLicenseInfoWithFilter1.Name = "ctrlLicenseInfoWithFilter1";
            this.ctrlLicenseInfoWithFilter1.Size = new System.Drawing.Size(1148, 466);
            this.ctrlLicenseInfoWithFilter1.TabIndex = 184;
            this.ctrlLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 767);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.lbllShowLicenseInfo);
            this.Controls.Add(this.lbllShowHistory);
            this.Controls.Add(this.gpApplicationInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlLicenseInfoWithFilter1);
            this.Name = "frmDetainLicense";
            this.Text = "frmDetainLicense";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.gpApplicationInfo.ResumeLayout(false);
            this.gpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.LinkLabel lbllShowLicenseInfo;
        private System.Windows.Forms.LinkLabel lbllShowHistory;
        private System.Windows.Forms.GroupBox gpApplicationInfo;
        private System.Windows.Forms.TextBox txtbFees;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private Controls.ctrlLicenseInfoWithFilter ctrlLicenseInfoWithFilter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}