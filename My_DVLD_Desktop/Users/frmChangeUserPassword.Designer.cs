namespace My_DVLD_Desktop.Users
{
    partial class frmChangeUserPassword
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
            this.ctrlUserDetails1 = new My_DVLD_Desktop.Users.ctrlUserDetails();
            this.txtbConfirmePassword = new System.Windows.Forms.TextBox();
            this.txtbNewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtbCurrentPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Change User Password";
            // 
            // ctrlUserDetails1
            // 
            this.ctrlUserDetails1.Location = new System.Drawing.Point(12, 70);
            this.ctrlUserDetails1.Name = "ctrlUserDetails1";
            this.ctrlUserDetails1.Size = new System.Drawing.Size(989, 419);
            this.ctrlUserDetails1.TabIndex = 16;
            // 
            // txtbConfirmePassword
            // 
            this.txtbConfirmePassword.Location = new System.Drawing.Point(281, 632);
            this.txtbConfirmePassword.Name = "txtbConfirmePassword";
            this.txtbConfirmePassword.Size = new System.Drawing.Size(228, 22);
            this.txtbConfirmePassword.TabIndex = 73;
            this.txtbConfirmePassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateConfirmPassword);
            // 
            // txtbNewPassword
            // 
            this.txtbNewPassword.Location = new System.Drawing.Point(281, 576);
            this.txtbNewPassword.Name = "txtbNewPassword";
            this.txtbNewPassword.Size = new System.Drawing.Size(228, 22);
            this.txtbNewPassword.TabIndex = 72;
            this.txtbNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 633);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Confirme Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 578);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "New Password :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_DVLD_Desktop.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(22, 623);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::My_DVLD_Desktop.Properties.Resources.Number_32;
            this.pictureBox6.Location = new System.Drawing.Point(22, 568);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 31);
            this.pictureBox6.TabIndex = 69;
            this.pictureBox6.TabStop = false;
            // 
            // txtbCurrentPass
            // 
            this.txtbCurrentPass.Location = new System.Drawing.Point(281, 522);
            this.txtbCurrentPass.Name = "txtbCurrentPass";
            this.txtbCurrentPass.Size = new System.Drawing.Size(228, 22);
            this.txtbCurrentPass.TabIndex = 76;
            this.txtbCurrentPass.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateCurrentPassword);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Current Password :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::My_DVLD_Desktop.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(22, 513);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 31);
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClose.Location = new System.Drawing.Point(695, 684);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 45);
            this.btnClose.TabIndex = 77;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.Location = new System.Drawing.Point(848, 684);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 45);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 760);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtbCurrentPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtbConfirmePassword);
            this.Controls.Add(this.txtbNewPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.ctrlUserDetails1);
            this.Controls.Add(this.label1);
            this.Name = "frmChangeUserPassword";
            this.Text = "frmChangeUserPassword";
            this.Load += new System.EventHandler(this.frmChangeUserPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlUserDetails ctrlUserDetails1;
        private System.Windows.Forms.TextBox txtbConfirmePassword;
        private System.Windows.Forms.TextBox txtbNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtbCurrentPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}