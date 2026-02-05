namespace My_DVLD_Desktop.Applications.Tests
{
    partial class frmTestAppointments
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAppointmentTests = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.ctrlVisionTest1 = new My_DVLD_Desktop.Applications.Tests.Test_Types.ctrlLocalDrivingLicenseInfo();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentTests)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTitle.Location = new System.Drawing.Point(278, 172);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(361, 32);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Vision Test Appointments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Appointments";
            // 
            // dgvAppointmentTests
            // 
            this.dgvAppointmentTests.AllowUserToAddRows = false;
            this.dgvAppointmentTests.AllowUserToDeleteRows = false;
            this.dgvAppointmentTests.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAppointmentTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentTests.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAppointmentTests.Location = new System.Drawing.Point(2, 617);
            this.dgvAppointmentTests.MultiSelect = false;
            this.dgvAppointmentTests.Name = "dgvAppointmentTests";
            this.dgvAppointmentTests.ReadOnly = true;
            this.dgvAppointmentTests.RowHeadersWidth = 30;
            this.dgvAppointmentTests.RowTemplate.Height = 24;
            this.dgvAppointmentTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointmentTests.Size = new System.Drawing.Size(934, 190);
            this.dgvAppointmentTests.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 60);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.edit_324;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Schedule_Test_32;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 810);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "#Count";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblCount.Location = new System.Drawing.Point(92, 810);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(24, 25);
            this.lblCount.TabIndex = 21;
            this.lblCount.Text = "0";
            // 
            // ctrlVisionTest1
            // 
            this.ctrlVisionTest1.Location = new System.Drawing.Point(2, 207);
            this.ctrlVisionTest1.Name = "ctrlVisionTest1";
            this.ctrlVisionTest1.Size = new System.Drawing.Size(934, 366);
            this.ctrlVisionTest1.TabIndex = 19;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Image = global::My_DVLD_Desktop.Properties.Resources.AddAppointment_32;
            this.btnAddAppointment.Location = new System.Drawing.Point(884, 571);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(42, 40);
            this.btnAddAppointment.TabIndex = 17;
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::My_DVLD_Desktop.Properties.Resources.Vision_512;
            this.pictureBox1.Location = new System.Drawing.Point(365, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 839);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrlVisionTest1);
            this.Controls.Add(this.dgvAppointmentTests);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTestAppointments";
            this.Text = "frmVisionTest";
            this.Load += new System.EventHandler(this.frmTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentTests)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.DataGridView dgvAppointmentTests;
        private Test_Types.ctrlLocalDrivingLicenseInfo ctrlVisionTest1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}