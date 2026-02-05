namespace My_DVLD_Desktop.Applications.Tests
{
    partial class frmScheduleTest
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
            this.scheduleTests1 = new My_DVLD_Desktop.Applications.LocalDrivingLicenseApplications.SchedualTest.Controls.ScheduleTests();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scheduleTests1
            // 
            this.scheduleTests1.Location = new System.Drawing.Point(5, 12);
            this.scheduleTests1.Name = "scheduleTests1";
            this.scheduleTests1.Size = new System.Drawing.Size(632, 721);
            this.scheduleTests1.TabIndex = 0;
            this.scheduleTests1.TestType = My_DVLD_BussinessLayer.clsTestTypeBussinuse.enTestType.VisionTest;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(276, 736);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 35);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 783);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.scheduleTests1);
            this.Name = "frmScheduleTest";
            this.Text = "Schedule Test";
            this.Load += new System.EventHandler(this.frmSchedualAppoitnmentTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LocalDrivingLicenseApplications.SchedualTest.Controls.ScheduleTests scheduleTests1;
        private System.Windows.Forms.Button btnClose;
    }
}