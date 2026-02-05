namespace My_DVLD_Desktop.Users
{
    partial class frmAddEditNewUser
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
            this.tpAddEditUsers = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtbConfirmePassword = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAddOrEdit = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonDetailsWithFilter1 = new My_DVLD_Desktop.ctrlPersonDetailsWithFilter();
            this.tpAddEditUsers.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tpAddEditUsers
            // 
            this.tpAddEditUsers.Controls.Add(this.tpPersonInfo);
            this.tpAddEditUsers.Controls.Add(this.tpLoginInfo);
            this.tpAddEditUsers.Location = new System.Drawing.Point(12, 132);
            this.tpAddEditUsers.Name = "tpAddEditUsers";
            this.tpAddEditUsers.SelectedIndex = 0;
            this.tpAddEditUsers.Size = new System.Drawing.Size(1012, 517);
            this.tpAddEditUsers.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.ctrlPersonDetailsWithFilter1);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(1004, 488);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Person Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Silver;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNext.Location = new System.Drawing.Point(901, 425);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(97, 35);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.Controls.Add(this.cbIsActive);
            this.tpLoginInfo.Controls.Add(this.lblUserID);
            this.tpLoginInfo.Controls.Add(this.txtbConfirmePassword);
            this.tpLoginInfo.Controls.Add(this.txtbPassword);
            this.tpLoginInfo.Controls.Add(this.txtbUsername);
            this.tpLoginInfo.Controls.Add(this.label5);
            this.tpLoginInfo.Controls.Add(this.label4);
            this.tpLoginInfo.Controls.Add(this.label2);
            this.tpLoginInfo.Controls.Add(this.label3);
            this.tpLoginInfo.Controls.Add(this.pictureBox2);
            this.tpLoginInfo.Controls.Add(this.pictureBox1);
            this.tpLoginInfo.Controls.Add(this.pictureBox6);
            this.tpLoginInfo.Controls.Add(this.pictureBox4);
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(1004, 488);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "Login Info";
            this.tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Location = new System.Drawing.Point(288, 197);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(79, 20);
            this.cbIsActive.TabIndex = 69;
            this.cbIsActive.Text = "Is Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(284, 37);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(49, 20);
            this.lblUserID.TabIndex = 68;
            this.lblUserID.Text = "????";
            // 
            // txtbConfirmePassword
            // 
            this.txtbConfirmePassword.Location = new System.Drawing.Point(288, 145);
            this.txtbConfirmePassword.Name = "txtbConfirmePassword";
            this.txtbConfirmePassword.Size = new System.Drawing.Size(228, 22);
            this.txtbConfirmePassword.TabIndex = 67;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(288, 107);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(228, 22);
            this.txtbPassword.TabIndex = 66;
            this.txtbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtbUsername
            // 
            this.txtbUsername.Location = new System.Drawing.Point(288, 71);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(228, 22);
            this.txtbUsername.TabIndex = 65;
            this.txtbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateUsername);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "UserID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Confirme Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Password :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::My_DVLD_Desktop.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(29, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 31);
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_DVLD_Desktop.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(29, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::My_DVLD_Desktop.Properties.Resources.Number_32;
            this.pictureBox6.Location = new System.Drawing.Point(29, 100);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 31);
            this.pictureBox6.TabIndex = 52;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::My_DVLD_Desktop.Properties.Resources.Person_32;
            this.pictureBox4.Location = new System.Drawing.Point(29, 64);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 31);
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClose.Location = new System.Drawing.Point(788, 669);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.Location = new System.Drawing.Point(917, 669);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAddOrEdit
            // 
            this.lblAddOrEdit.AutoSize = true;
            this.lblAddOrEdit.BackColor = System.Drawing.Color.Transparent;
            this.lblAddOrEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddOrEdit.ForeColor = System.Drawing.Color.Brown;
            this.lblAddOrEdit.Location = new System.Drawing.Point(393, 49);
            this.lblAddOrEdit.Name = "lblAddOrEdit";
            this.lblAddOrEdit.Size = new System.Drawing.Size(241, 38);
            this.lblAddOrEdit.TabIndex = 4;
            this.lblAddOrEdit.Text = "Add New User";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonDetailsWithFilter1
            // 
            this.ctrlPersonDetailsWithFilter1.Location = new System.Drawing.Point(9, 0);
            this.ctrlPersonDetailsWithFilter1.Name = "ctrlPersonDetailsWithFilter1";
            this.ctrlPersonDetailsWithFilter1.ShowAddPerson = false;
            this.ctrlPersonDetailsWithFilter1.ShowFilterBox = false;
            this.ctrlPersonDetailsWithFilter1.Size = new System.Drawing.Size(995, 419);
            this.ctrlPersonDetailsWithFilter1.TabIndex = 0;
            // 
            // frmAddEditNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 741);
            this.Controls.Add(this.lblAddOrEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tpAddEditUsers);
            this.Name = "frmAddEditNewUser";
            this.Text = "frmAddEditUser";
            this.Load += new System.EventHandler(this.frmAddEditNewUser_Load);
            this.tpAddEditUsers.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tpAddEditUsers;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.Button btnNext;
        private ctrlPersonDetailsWithFilter ctrlPersonDetailsWithFilter1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAddOrEdit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtbConfirmePassword;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}