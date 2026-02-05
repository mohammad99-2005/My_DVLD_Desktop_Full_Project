namespace My_DVLD_Desktop
{
    partial class MainScreen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driveingLicenseServicingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementForDamagedOrLostLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("SimSun", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1437, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driveingLicenseServicingToolStripMenuItem,
            this.toolStripSeparator2,
            this.manageApplicationsToolStripMenuItem,
            this.toolStripSeparator1,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.applicationsToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Applications_64;
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(229, 39);
            this.applicationsToolStripMenuItem.Text = "Applications";
            this.applicationsToolStripMenuItem.Click += new System.EventHandler(this.applicationsToolStripMenuItem_Click);
            // 
            // driveingLicenseServicingToolStripMenuItem
            // 
            this.driveingLicenseServicingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.reToolStripMenuItem,
            this.replacementForDamagedOrLostLicenseToolStripMenuItem,
            this.releaseToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.driveingLicenseServicingToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Driver_License_48;
            this.driveingLicenseServicingToolStripMenuItem.Name = "driveingLicenseServicingToolStripMenuItem";
            this.driveingLicenseServicingToolStripMenuItem.Size = new System.Drawing.Size(491, 42);
            this.driveingLicenseServicingToolStripMenuItem.Text = "Driveing Licenses Servicing";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicensToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.New_Driving_License_32;
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(659, 42);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicensToolStripMenuItem
            // 
            this.localLicensToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Local_32;
            this.localLicensToolStripMenuItem.Name = "localLicensToolStripMenuItem";
            this.localLicensToolStripMenuItem.Size = new System.Drawing.Size(407, 42);
            this.localLicensToolStripMenuItem.Text = "Local License";
            this.localLicensToolStripMenuItem.Click += new System.EventHandler(this.localLicensToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.International_32;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(407, 42);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Renew_Driving_License_32;
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(659, 42);
            this.reToolStripMenuItem.Text = "Renew Driving License";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
            // 
            // replacementForDamagedOrLostLicenseToolStripMenuItem
            // 
            this.replacementForDamagedOrLostLicenseToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Damaged_Driving_License_32;
            this.replacementForDamagedOrLostLicenseToolStripMenuItem.Name = "replacementForDamagedOrLostLicenseToolStripMenuItem";
            this.replacementForDamagedOrLostLicenseToolStripMenuItem.Size = new System.Drawing.Size(659, 42);
            this.replacementForDamagedOrLostLicenseToolStripMenuItem.Text = "Replacement For Damaged Or Lost License";
            this.replacementForDamagedOrLostLicenseToolStripMenuItem.Click += new System.EventHandler(this.replacementForDamagedOrLostLicenseToolStripMenuItem_Click);
            // 
            // releaseToolStripMenuItem
            // 
            this.releaseToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Release_Detained_License_32;
            this.releaseToolStripMenuItem.Name = "releaseToolStripMenuItem";
            this.releaseToolStripMenuItem.Size = new System.Drawing.Size(659, 42);
            this.releaseToolStripMenuItem.Text = "Release Detained Driving License";
            this.releaseToolStripMenuItem.Click += new System.EventHandler(this.releaseToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Retake_Test_32;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(659, 42);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(488, 6);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationToolStripMenuItem,
            this.internationalDrivingLicenseApplicationsToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Manage_Applications_32;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(491, 42);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Driver_License_48;
            this.localDrivingLicenseApplicationToolStripMenuItem.Name = "localDrivingLicenseApplicationToolStripMenuItem";
            this.localDrivingLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(701, 42);
            this.localDrivingLicenseApplicationToolStripMenuItem.Text = "Local Driving License Applications";
            this.localDrivingLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationToolStripMenuItem_Click);
            // 
            // internationalDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.internationalDrivingLicenseApplicationsToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.International_32;
            this.internationalDrivingLicenseApplicationsToolStripMenuItem.Name = "internationalDrivingLicenseApplicationsToolStripMenuItem";
            this.internationalDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(701, 42);
            this.internationalDrivingLicenseApplicationsToolStripMenuItem.Text = "International Driving License Applications";
            this.internationalDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.internationalDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(488, 6);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaseLicenseToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Detain_32;
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(491, 42);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Detain_321;
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(449, 42);
            this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicensesToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Detain_32;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(449, 42);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // releaseLicenseToolStripMenuItem
            // 
            this.releaseLicenseToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Release_Detained_License_32;
            this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(449, 42);
            this.releaseLicenseToolStripMenuItem.Text = "Release License";
            this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Application_Types_64;
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(491, 42);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.TestType_32;
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(491, 42);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.People_64;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(145, 39);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Drivers_64;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(159, 39);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Users_2_64;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(131, 39);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.account_settings_64;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(285, 39);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.PersonDetails_322;
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(351, 42);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Password_32;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(351, 42);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.sign_out_32__2;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(351, 42);
            this.logOutToolStripMenuItem.Text = "Sign Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::My_DVLD_Desktop.Properties.Resources.ChatGPT_Image_Sep_11__2025__12_22_22_AM1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1437, 707);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::My_DVLD_Desktop.Properties.Resources.ChatGPT_Image_Sep_11__2025__12_22_22_AM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1437, 748);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driveingLicenseServicingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForDamagedOrLostLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
    }
}

