namespace My_DVLD_Desktop.Applications.Licenses.DetainReleaseLicense
{
    partial class frmManageDetainedLicenses
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
            this.cbIsReleased = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnDetain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.DisplayMember = "0";
            this.cbIsReleased.FormattingEnabled = true;
            this.cbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsReleased.Location = new System.Drawing.Point(326, 309);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.Size = new System.Drawing.Size(103, 24);
            this.cbIsReleased.TabIndex = 26;
            this.cbIsReleased.Tag = "0";
            this.cbIsReleased.ValueMember = "0";
            this.cbIsReleased.Visible = false;
            this.cbIsReleased.SelectedIndexChanged += new System.EventHandler(this.cbIsReleased_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(481, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Manage Detained Licenses";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblCount.Location = new System.Drawing.Point(112, 752);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(45, 25);
            this.lblCount.TabIndex = 22;
            this.lblCount.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 752);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "#Count:";
            // 
            // txtbFilterValue
            // 
            this.txtbFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFilterValue.Location = new System.Drawing.Point(326, 309);
            this.txtbFilterValue.Name = "txtbFilterValue";
            this.txtbFilterValue.Size = new System.Drawing.Size(253, 24);
            this.txtbFilterValue.TabIndex = 20;
            this.txtbFilterValue.Visible = false;
            this.txtbFilterValue.TextChanged += new System.EventHandler(this.txtbFilterValue_TextChanged);
            this.txtbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFilterValue_KeyPress);
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "DetainID",
            "IsReleased",
            "NationalNo",
            "FullName",
            "ReleaseApplicationID"});
            this.cbFilters.Location = new System.Drawing.Point(128, 309);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(177, 24);
            this.cbFilters.TabIndex = 19;
            this.cbFilters.Tag = "0";
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Filter By : ";
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(15, 339);
            this.dgvDetainedLicenses.MultiSelect = false;
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            this.dgvDetainedLicenses.RowHeadersWidth = 30;
            this.dgvDetainedLicenses.RowTemplate.Height = 24;
            this.dgvDetainedLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1337, 405);
            this.dgvDetainedLicenses.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personDetailsToolStripMenuItem,
            this.licenseInformationToolStripMenuItem,
            this.licenseHistoryToolStripMenuItem,
            this.toolStripSeparator1,
            this.releaseLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(235, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // personDetailsToolStripMenuItem
            // 
            this.personDetailsToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.PersonDetails_32;
            this.personDetailsToolStripMenuItem.Name = "personDetailsToolStripMenuItem";
            this.personDetailsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.personDetailsToolStripMenuItem.Text = "Person Details";
            this.personDetailsToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // licenseInformationToolStripMenuItem
            // 
            this.licenseInformationToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.License_View_32;
            this.licenseInformationToolStripMenuItem.Name = "licenseInformationToolStripMenuItem";
            this.licenseInformationToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.licenseInformationToolStripMenuItem.Text = "License Information";
            this.licenseInformationToolStripMenuItem.Click += new System.EventHandler(this.licenseInformationToolStripMenuItem_Click);
            // 
            // licenseHistoryToolStripMenuItem
            // 
            this.licenseHistoryToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.PersonLicenseHistory_32;
            this.licenseHistoryToolStripMenuItem.Name = "licenseHistoryToolStripMenuItem";
            this.licenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.licenseHistoryToolStripMenuItem.Text = "Person Licenses History";
            this.licenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.licenseHistoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // releaseLicenseToolStripMenuItem
            // 
            this.releaseLicenseToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Release_Detained_License_32;
            this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.releaseLicenseToolStripMenuItem.Text = "Release License";
            this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Image = global::My_DVLD_Desktop.Properties.Resources.Release_Detained_License_64;
            this.btnRelease.Location = new System.Drawing.Point(1153, 256);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(80, 77);
            this.btnRelease.TabIndex = 27;
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetain.Image = global::My_DVLD_Desktop.Properties.Resources.Detain_64;
            this.btnDetain.Location = new System.Drawing.Point(1272, 256);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(80, 77);
            this.btnDetain.TabIndex = 25;
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::My_DVLD_Desktop.Properties.Resources.Detain_512;
            this.pictureBox1.Location = new System.Drawing.Point(554, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 785);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.cbIsReleased);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbFilterValue);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.Name = "frmManageDetainedLicenses";
            this.Text = "frmManageDetainedLicenses";
            this.Load += new System.EventHandler(this.frmManageDetainedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIsReleased;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbFilterValue;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetainedLicenses;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}