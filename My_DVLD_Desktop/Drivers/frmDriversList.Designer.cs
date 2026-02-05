namespace My_DVLD_Desktop.Drivers
{
    partial class frmDriversList
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvDrivers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDriversFilter = new System.Windows.Forms.ComboBox();
            this.txtbDriverFilterValue = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.showDrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(551, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Manage Drivers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::My_DVLD_Desktop.Properties.Resources.Driver_Main;
            this.pictureBox1.Location = new System.Drawing.Point(541, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1222, 716);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 735);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Count:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCount.Location = new System.Drawing.Point(82, 735);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(36, 20);
            this.lblCount.TabIndex = 17;
            this.lblCount.Text = "###";
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDrivers.Location = new System.Drawing.Point(16, 314);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            this.dgvDrivers.RowHeadersWidth = 51;
            this.dgvDrivers.RowTemplate.Height = 24;
            this.dgvDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivers.Size = new System.Drawing.Size(1313, 396);
            this.dgvDrivers.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Filter By:";
            // 
            // cbDriversFilter
            // 
            this.cbDriversFilter.DisplayMember = "0";
            this.cbDriversFilter.FormattingEnabled = true;
            this.cbDriversFilter.Items.AddRange(new object[] {
            "None",
            "DriverID",
            "PersonID",
            "NationalNo",
            "FullName"});
            this.cbDriversFilter.Location = new System.Drawing.Point(124, 278);
            this.cbDriversFilter.Name = "cbDriversFilter";
            this.cbDriversFilter.Size = new System.Drawing.Size(177, 24);
            this.cbDriversFilter.TabIndex = 20;
            this.cbDriversFilter.Tag = "0";
            this.cbDriversFilter.ValueMember = "0";
            this.cbDriversFilter.SelectedIndexChanged += new System.EventHandler(this.cbDriversFilter_SelectedIndexChanged);
            // 
            // txtbDriverFilterValue
            // 
            this.txtbDriverFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDriverFilterValue.Location = new System.Drawing.Point(327, 278);
            this.txtbDriverFilterValue.Name = "txtbDriverFilterValue";
            this.txtbDriverFilterValue.Size = new System.Drawing.Size(228, 24);
            this.txtbDriverFilterValue.TabIndex = 21;
            this.txtbDriverFilterValue.Visible = false;
            this.txtbDriverFilterValue.TextChanged += new System.EventHandler(this.txtbDriverFilterValue_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.toolStripSeparator1,
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator6,
            this.showDrToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(344, 100);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPersonInfoToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.PersonDetails_323;
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(343, 28);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(340, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLicenseToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.License_View_32;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(343, 28);
            this.showLicenseToolStripMenuItem.Text = "Issue International Driving License";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(340, 6);
            // 
            // showDrToolStripMenuItem
            // 
            this.showDrToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDrToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.PersonLicenseHistory_32;
            this.showDrToolStripMenuItem.Name = "showDrToolStripMenuItem";
            this.showDrToolStripMenuItem.Size = new System.Drawing.Size(343, 28);
            this.showDrToolStripMenuItem.Text = "Show Person License History";
            this.showDrToolStripMenuItem.Click += new System.EventHandler(this.showDrToolStripMenuItem_Click);
            // 
            // frmDriversList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 764);
            this.Controls.Add(this.txtbDriverFilterValue);
            this.Controls.Add(this.cbDriversFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDrivers);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDriversList";
            this.Text = "frmDriversList";
            this.Load += new System.EventHandler(this.frmDriversList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvDrivers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDriversFilter;
        private System.Windows.Forms.TextBox txtbDriverFilterValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem showDrToolStripMenuItem;
    }
}