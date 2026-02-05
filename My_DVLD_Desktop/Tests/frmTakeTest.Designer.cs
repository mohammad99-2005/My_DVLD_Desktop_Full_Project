namespace My_DVLD_Desktop.Applications.Tests
{
    partial class frmTakeTest
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
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnPass = new System.Windows.Forms.RadioButton();
            this.rbtnFail = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbNotes = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.scheduledTest1 = new My_DVLD_Desktop.Applications.LocalDrivingLicenseApplications.ScheduleTests.Controls.ScheduledTest();
            this.lblUserMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "D.L.App ID:";
            // 
            // rbtnPass
            // 
            this.rbtnPass.AutoSize = true;
            this.rbtnPass.Location = new System.Drawing.Point(225, 585);
            this.rbtnPass.Name = "rbtnPass";
            this.rbtnPass.Size = new System.Drawing.Size(59, 20);
            this.rbtnPass.TabIndex = 45;
            this.rbtnPass.TabStop = true;
            this.rbtnPass.Text = "Pass";
            this.rbtnPass.UseVisualStyleBackColor = true;
            // 
            // rbtnFail
            // 
            this.rbtnFail.AutoSize = true;
            this.rbtnFail.Location = new System.Drawing.Point(299, 585);
            this.rbtnFail.Name = "rbtnFail";
            this.rbtnFail.Size = new System.Drawing.Size(50, 20);
            this.rbtnFail.TabIndex = 46;
            this.rbtnFail.TabStop = true;
            this.rbtnFail.Text = "Fail";
            this.rbtnFail.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 629);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 47;
            this.label7.Text = "Notes:";
            // 
            // txtbNotes
            // 
            this.txtbNotes.Location = new System.Drawing.Point(171, 620);
            this.txtbNotes.Multiline = true;
            this.txtbNotes.Name = "txtbNotes";
            this.txtbNotes.Size = new System.Drawing.Size(438, 133);
            this.txtbNotes.TabIndex = 49;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::My_DVLD_Desktop.Properties.Resources.Save_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(371, 759);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 41);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::My_DVLD_Desktop.Properties.Resources.Notes_32;
            this.pictureBox10.Location = new System.Drawing.Point(50, 620);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(41, 40);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 48;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::My_DVLD_Desktop.Properties.Resources.Number_32;
            this.pictureBox9.Location = new System.Drawing.Point(50, 573);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(41, 40);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 44;
            this.pictureBox9.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::My_DVLD_Desktop.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(493, 759);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 41);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // scheduledTest1
            // 
            this.scheduledTest1.Location = new System.Drawing.Point(3, 3);
            this.scheduledTest1.Name = "scheduledTest1";
            this.scheduledTest1.Size = new System.Drawing.Size(615, 555);
            this.scheduledTest1.TabIndex = 51;
            this.scheduledTest1.TestType = My_DVLD_BussinessLayer.clsTestTypeBussinuse.enTestType.VisionTest;
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMessage.ForeColor = System.Drawing.Color.Red;
            this.lblUserMessage.Location = new System.Drawing.Point(15, 765);
            this.lblUserMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(304, 25);
            this.lblUserMessage.TabIndex = 200;
            this.lblUserMessage.Text = "You cannot change the results";
            this.lblUserMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserMessage.Visible = false;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 803);
            this.Controls.Add(this.lblUserMessage);
            this.Controls.Add(this.scheduledTest1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtbNotes);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbtnFail);
            this.Controls.Add(this.rbtnPass);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Name = "frmTakeTest";
            this.Text = "frmTakeVisionTest";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnPass;
        private System.Windows.Forms.RadioButton rbtnFail;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbNotes;
        private System.Windows.Forms.Button btnClose;
        private LocalDrivingLicenseApplications.ScheduleTests.Controls.ScheduledTest scheduledTest1;
        private System.Windows.Forms.Label lblUserMessage;
    }
}