namespace My_DVLD_Desktop.Applications.Local_Driving_License
{
    partial class AddNewLocalDrivingLicenseApplication
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
            this.tbLocalDriningLicense = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlPersonDetailsWithFilter1 = new My_DVLD_Desktop.ctrlPersonDetailsWithFilter();
            this.tpNewLDLApp = new System.Windows.Forms.TabPage();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblDLAppID = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAppFeees = new System.Windows.Forms.Label();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.labelddd = new System.Windows.Forms.Label();
            this.lblAddOrEdit = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbLocalDriningLicense.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpNewLDLApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLocalDriningLicense
            // 
            this.tbLocalDriningLicense.Controls.Add(this.tpPersonInfo);
            this.tbLocalDriningLicense.Controls.Add(this.tpNewLDLApp);
            this.tbLocalDriningLicense.Location = new System.Drawing.Point(5, 85);
            this.tbLocalDriningLicense.Name = "tbLocalDriningLicense";
            this.tbLocalDriningLicense.SelectedIndex = 0;
            this.tbLocalDriningLicense.Size = new System.Drawing.Size(1008, 520);
            this.tbLocalDriningLicense.TabIndex = 1;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.ctrlPersonDetailsWithFilter1);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(1000, 491);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Silver;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNext.Location = new System.Drawing.Point(899, 447);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(97, 35);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonDetailsWithFilter1
            // 
            this.ctrlPersonDetailsWithFilter1.Location = new System.Drawing.Point(6, 23);
            this.ctrlPersonDetailsWithFilter1.Name = "ctrlPersonDetailsWithFilter1";
            this.ctrlPersonDetailsWithFilter1.ShowAddPerson = false;
            this.ctrlPersonDetailsWithFilter1.ShowFilterBox = false;
            this.ctrlPersonDetailsWithFilter1.Size = new System.Drawing.Size(990, 418);
            this.ctrlPersonDetailsWithFilter1.TabIndex = 0;
            this.ctrlPersonDetailsWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonDetailsWithFilter1_OnPersonSelected);
            // 
            // tpNewLDLApp
            // 
            this.tpNewLDLApp.Controls.Add(this.cbLicenseClasses);
            this.tpNewLDLApp.Controls.Add(this.lblCreatedBy);
            this.tpNewLDLApp.Controls.Add(this.lblAppFees);
            this.tpNewLDLApp.Controls.Add(this.lblAppDate);
            this.tpNewLDLApp.Controls.Add(this.lblDLAppID);
            this.tpNewLDLApp.Controls.Add(this.pictureBox5);
            this.tpNewLDLApp.Controls.Add(this.pictureBox4);
            this.tpNewLDLApp.Controls.Add(this.pictureBox3);
            this.tpNewLDLApp.Controls.Add(this.pictureBox2);
            this.tpNewLDLApp.Controls.Add(this.pictureBox1);
            this.tpNewLDLApp.Controls.Add(this.label5);
            this.tpNewLDLApp.Controls.Add(this.lblAppFeees);
            this.tpNewLDLApp.Controls.Add(this.lblLicenseClass);
            this.tpNewLDLApp.Controls.Add(this.lblApplicationDate);
            this.tpNewLDLApp.Controls.Add(this.labelddd);
            this.tpNewLDLApp.Location = new System.Drawing.Point(4, 25);
            this.tpNewLDLApp.Name = "tpNewLDLApp";
            this.tpNewLDLApp.Padding = new System.Windows.Forms.Padding(3);
            this.tpNewLDLApp.Size = new System.Drawing.Size(1000, 491);
            this.tpNewLDLApp.TabIndex = 1;
            this.tpNewLDLApp.Text = "LDLApp Info";
            this.tpNewLDLApp.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(319, 169);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(231, 24);
            this.cbLicenseClasses.TabIndex = 14;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(315, 272);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(61, 20);
            this.lblCreatedBy.TabIndex = 13;
            this.lblCreatedBy.Text = "[????]";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.Location = new System.Drawing.Point(315, 222);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(61, 20);
            this.lblAppFees.TabIndex = 12;
            this.lblAppFees.Text = "[????]";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.Location = new System.Drawing.Point(315, 116);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(61, 20);
            this.lblAppDate.TabIndex = 11;
            this.lblAppDate.Text = "[????]";
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.AutoSize = true;
            this.lblDLAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLAppID.Location = new System.Drawing.Point(315, 65);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(61, 20);
            this.lblDLAppID.TabIndex = 10;
            this.lblDLAppID.Text = "[????]";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::My_DVLD_Desktop.Properties.Resources.User_32__21;
            this.pictureBox5.Location = new System.Drawing.Point(260, 262);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::My_DVLD_Desktop.Properties.Resources.money_32;
            this.pictureBox4.Location = new System.Drawing.Point(260, 209);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::My_DVLD_Desktop.Properties.Resources.New_Driving_License_321;
            this.pictureBox3.Location = new System.Drawing.Point(260, 157);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::My_DVLD_Desktop.Properties.Resources.Calendar_321;
            this.pictureBox2.Location = new System.Drawing.Point(260, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::My_DVLD_Desktop.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(260, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Created By :";
            // 
            // lblAppFeees
            // 
            this.lblAppFeees.AutoSize = true;
            this.lblAppFeees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFeees.Location = new System.Drawing.Point(77, 222);
            this.lblAppFeees.Name = "lblAppFeees";
            this.lblAppFeees.Size = new System.Drawing.Size(171, 22);
            this.lblAppFeees.TabIndex = 3;
            this.lblAppFeees.Text = "Application Fees :";
            // 
            // lblLicenseClass
            // 
            this.lblLicenseClass.AutoSize = true;
            this.lblLicenseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseClass.Location = new System.Drawing.Point(77, 169);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(147, 22);
            this.lblLicenseClass.TabIndex = 2;
            this.lblLicenseClass.Text = "License Class :";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(77, 116);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(175, 22);
            this.lblApplicationDate.TabIndex = 1;
            this.lblApplicationDate.Text = "Application Date  :";
            // 
            // labelddd
            // 
            this.labelddd.AutoSize = true;
            this.labelddd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelddd.Location = new System.Drawing.Point(77, 63);
            this.labelddd.Name = "labelddd";
            this.labelddd.Size = new System.Drawing.Size(183, 22);
            this.labelddd.TabIndex = 0;
            this.labelddd.Text = "D.L.Application ID :";
            // 
            // lblAddOrEdit
            // 
            this.lblAddOrEdit.AutoSize = true;
            this.lblAddOrEdit.BackColor = System.Drawing.Color.Transparent;
            this.lblAddOrEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOrEdit.ForeColor = System.Drawing.Color.Brown;
            this.lblAddOrEdit.Location = new System.Drawing.Point(196, 21);
            this.lblAddOrEdit.Name = "lblAddOrEdit";
            this.lblAddOrEdit.Size = new System.Drawing.Size(608, 38);
            this.lblAddOrEdit.TabIndex = 5;
            this.lblAddOrEdit.Text = "New Local Driving License Application";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClose.Location = new System.Drawing.Point(772, 614);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 39);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.Location = new System.Drawing.Point(901, 614);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 39);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddNewLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 665);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAddOrEdit);
            this.Controls.Add(this.tbLocalDriningLicense);
            this.Name = "AddNewLocalDrivingLicenseApplication";
            this.Text = "AddNewLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.AddNewLocalDrivingLicenseApplication_Load);
            this.tbLocalDriningLicense.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpNewLDLApp.ResumeLayout(false);
            this.tpNewLDLApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlPersonDetailsWithFilter ctrlPersonDetailsWithFilter1;
        private System.Windows.Forms.TabControl tbLocalDriningLicense;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpNewLDLApp;
        private System.Windows.Forms.Label lblAddOrEdit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAppFeees;
        private System.Windows.Forms.Label lblLicenseClass;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label labelddd;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
    }
}