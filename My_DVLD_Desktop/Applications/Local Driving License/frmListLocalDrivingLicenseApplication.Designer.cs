namespace My_DVLD_Desktop.Applications.Local_Driving_License
{
    partial class frmListLocalDrivingLicenseApplication
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
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLocalDriningLicenseApp = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.showDrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDriningLicenseApp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblCount.Location = new System.Drawing.Point(107, 711);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(45, 25);
            this.lblCount.TabIndex = 18;
            this.lblCount.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 711);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "#Count:";
            // 
            // txtbFilterValue
            // 
            this.txtbFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFilterValue.Location = new System.Drawing.Point(354, 282);
            this.txtbFilterValue.Name = "txtbFilterValue";
            this.txtbFilterValue.Size = new System.Drawing.Size(195, 24);
            this.txtbFilterValue.TabIndex = 16;
            this.txtbFilterValue.Visible = false;
            this.txtbFilterValue.TextChanged += new System.EventHandler(this.txtbFilterValue_TextChanged);
            this.txtbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFilterValue_KeyPress);
            this.txtbFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtbFilterValue_Validating);
            // 
            // cbFilters
            // 
            this.cbFilters.DisplayMember = "0";
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "L.D.L AppID",
            "NationalNo",
            "FullName",
            "Status"});
            this.cbFilters.Location = new System.Drawing.Point(156, 282);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(177, 24);
            this.cbFilters.TabIndex = 15;
            this.cbFilters.Tag = "0";
            this.cbFilters.ValueMember = "0";
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filter By : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(469, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Local Driving License Application";
            // 
            // dgvLocalDriningLicenseApp
            // 
            this.dgvLocalDriningLicenseApp.AllowUserToAddRows = false;
            this.dgvLocalDriningLicenseApp.AllowUserToDeleteRows = false;
            this.dgvLocalDriningLicenseApp.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvLocalDriningLicenseApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDriningLicenseApp.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLocalDriningLicenseApp.Location = new System.Drawing.Point(1, 312);
            this.dgvLocalDriningLicenseApp.MultiSelect = false;
            this.dgvLocalDriningLicenseApp.Name = "dgvLocalDriningLicenseApp";
            this.dgvLocalDriningLicenseApp.ReadOnly = true;
            this.dgvLocalDriningLicenseApp.RowHeadersWidth = 30;
            this.dgvLocalDriningLicenseApp.RowTemplate.Height = 24;
            this.dgvLocalDriningLicenseApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalDriningLicenseApp.Size = new System.Drawing.Size(1455, 394);
            this.dgvLocalDriningLicenseApp.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripSeparator3,
            this.scheduleTestsToolStripMenuItem,
            this.toolStripSeparator4,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripSeparator5,
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator6,
            this.showDrToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(329, 264);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showApplicationDetailsToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.PersonDetails_323;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(328, 28);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show ApplicationDetails";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(325, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editApplicationToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.edit_323;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(328, 28);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteApplicationToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Delete_32_2;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(328, 28);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(325, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelApplicationToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Delete_321;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(328, 28);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(325, 6);
            // 
            // scheduleTestsToolStripMenuItem
            // 
            this.scheduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionToolStripMenuItem,
            this.writenToolStripMenuItem,
            this.streetToolStripMenuItem});
            this.scheduleTestsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleTestsToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.TestType_321;
            this.scheduleTestsToolStripMenuItem.Name = "scheduleTestsToolStripMenuItem";
            this.scheduleTestsToolStripMenuItem.Size = new System.Drawing.Size(328, 28);
            this.scheduleTestsToolStripMenuItem.Text = "Schedule Tests";
            this.scheduleTestsToolStripMenuItem.DropDownClosed += new System.EventHandler(this.scheduleTestsToolStripMenuItem_DropDownClosed);
            // 
            // visionToolStripMenuItem
            // 
            this.visionToolStripMenuItem.Enabled = false;
            this.visionToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Vision_Test_32;
            this.visionToolStripMenuItem.Name = "visionToolStripMenuItem";
            this.visionToolStripMenuItem.Size = new System.Drawing.Size(258, 28);
            this.visionToolStripMenuItem.Text = "Schedule Vision Test";
            this.visionToolStripMenuItem.Click += new System.EventHandler(this.visionToolStripMenuItem_Click);
            // 
            // writenToolStripMenuItem
            // 
            this.writenToolStripMenuItem.Enabled = false;
            this.writenToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Written_Test_321;
            this.writenToolStripMenuItem.Name = "writenToolStripMenuItem";
            this.writenToolStripMenuItem.Size = new System.Drawing.Size(258, 28);
            this.writenToolStripMenuItem.Text = "Schedule  Writen Test";
            this.writenToolStripMenuItem.Click += new System.EventHandler(this.schedualToolStripMenuItem_Click);
            // 
            // streetToolStripMenuItem
            // 
            this.streetToolStripMenuItem.Enabled = false;
            this.streetToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Street_Test_32;
            this.streetToolStripMenuItem.Name = "streetToolStripMenuItem";
            this.streetToolStripMenuItem.Size = new System.Drawing.Size(258, 28);
            this.streetToolStripMenuItem.Text = "Schedule Street Test";
            this.streetToolStripMenuItem.Click += new System.EventHandler(this.streetToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(325, 6);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.New_Driving_License_322;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(328, 28);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(325, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLicenseToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.License_View_32;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(328, 28);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(325, 6);
            // 
            // showDrToolStripMenuItem
            // 
            this.showDrToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDrToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.PersonLicenseHistory_32;
            this.showDrToolStripMenuItem.Name = "showDrToolStripMenuItem";
            this.showDrToolStripMenuItem.Size = new System.Drawing.Size(328, 28);
            this.showDrToolStripMenuItem.Text = "Show Person License History";
            this.showDrToolStripMenuItem.Click += new System.EventHandler(this.showDrToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = global::My_DVLD_Desktop.Properties.Resources.Add_Person_40;
            this.btnAddNew.Location = new System.Drawing.Point(1372, 226);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(84, 80);
            this.btnAddNew.TabIndex = 13;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::My_DVLD_Desktop.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(580, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmListLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 739);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbFilterValue);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvLocalDriningLicenseApp);
            this.Name = "frmListLocalDrivingLicenseApplication";
            this.Text = "frmListLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frmListLocalDrivingLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDriningLicenseApp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbFilterValue;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvLocalDriningLicenseApp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDrToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem visionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streetToolStripMenuItem;
    }
}