namespace My_DVLD_Desktop.Applications.International
{
    partial class frmManageInternationalLicenses
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
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.btnNewInternationalApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personHistoryLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbIsActive
            // 
            this.cbIsActive.DisplayMember = "0";
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(325, 307);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(103, 24);
            this.cbIsActive.TabIndex = 37;
            this.cbIsActive.Tag = "0";
            this.cbIsActive.ValueMember = "0";
            this.cbIsActive.Visible = false;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(396, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 36);
            this.label1.TabIndex = 35;
            this.label1.Text = "International Licenses";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblCount.Location = new System.Drawing.Point(111, 750);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(45, 25);
            this.lblCount.TabIndex = 33;
            this.lblCount.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 750);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "#Count:";
            // 
            // txtbFilterValue
            // 
            this.txtbFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFilterValue.Location = new System.Drawing.Point(325, 307);
            this.txtbFilterValue.Name = "txtbFilterValue";
            this.txtbFilterValue.Size = new System.Drawing.Size(253, 24);
            this.txtbFilterValue.TabIndex = 31;
            this.txtbFilterValue.Visible = false;
            this.txtbFilterValue.TextChanged += new System.EventHandler(this.txtbFilterValue_TextChanged);
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "International License ID",
            "Application ID",
            "Driver ID",
            "Local License ID",
            "Is Active"});
            this.cbFilters.Location = new System.Drawing.Point(127, 307);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(177, 24);
            this.cbFilters.TabIndex = 30;
            this.cbFilters.Tag = "0";
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "Filter By : ";
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(14, 337);
            this.dgvInternationalLicenses.MultiSelect = false;
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.ReadOnly = true;
            this.dgvInternationalLicenses.RowHeadersWidth = 30;
            this.dgvInternationalLicenses.RowTemplate.Height = 24;
            this.dgvInternationalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(1122, 405);
            this.dgvInternationalLicenses.TabIndex = 28;
            // 
            // btnNewInternationalApplication
            // 
            this.btnNewInternationalApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewInternationalApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewInternationalApplication.Image = global::My_DVLD_Desktop.Properties.Resources.New_Application_64;
            this.btnNewInternationalApplication.Location = new System.Drawing.Point(1056, 254);
            this.btnNewInternationalApplication.Name = "btnNewInternationalApplication";
            this.btnNewInternationalApplication.Size = new System.Drawing.Size(80, 77);
            this.btnNewInternationalApplication.TabIndex = 36;
            this.btnNewInternationalApplication.UseVisualStyleBackColor = true;
            this.btnNewInternationalApplication.Click += new System.EventHandler(this.btnNewInternationalApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::My_DVLD_Desktop.Properties.Resources.Applications1;
            this.pictureBox1.Location = new System.Drawing.Point(425, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.personHistoryLicensesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(235, 82);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.PersonDetails_32;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.showPersonDetailsToolStripMenuItem.Text = "Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.License_View_321;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.showLicenseToolStripMenuItem.Text = "License Information";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // personHistoryLicensesToolStripMenuItem
            // 
            this.personHistoryLicensesToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.PersonLicenseHistory_32;
            this.personHistoryLicensesToolStripMenuItem.Name = "personHistoryLicensesToolStripMenuItem";
            this.personHistoryLicensesToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.personHistoryLicensesToolStripMenuItem.Text = "Person History Licenses";
            this.personHistoryLicensesToolStripMenuItem.Click += new System.EventHandler(this.personHistoryLicensesToolStripMenuItem_Click);
            // 
            // frmManageInternationalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 785);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.btnNewInternationalApplication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbFilterValue);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInternationalLicenses);
            this.Name = "frmManageInternationalLicenses";
            this.Text = "frmManageInternationalLicenses";
            this.Load += new System.EventHandler(this.frmManageInternationalLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.Button btnNewInternationalApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbFilterValue;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personHistoryLicensesToolStripMenuItem;
    }
}