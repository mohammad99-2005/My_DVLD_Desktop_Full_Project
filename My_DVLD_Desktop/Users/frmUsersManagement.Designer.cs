namespace My_DVLD_Desktop.Users
{
    partial class frmUsersManagement
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cmUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.cmUser;
            this.dgvUsers.Location = new System.Drawing.Point(47, 339);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 30;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1103, 405);
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentDoubleClick);
            // 
            // cmUser
            // 
            this.cmUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addPersonToolStripMenuItem,
            this.editeToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.ChangePasswordStripMenuItem1,
            this.toolStripSeparator1,
            this.emailToolStripMenuItem,
            this.phoneToolStripMenuItem});
            this.cmUser.Name = "contextMenuStrip1";
            this.cmUser.Size = new System.Drawing.Size(198, 192);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.PersonDetails_321;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Add_Person_401;
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.addPersonToolStripMenuItem.Text = "Add Person";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.addPersonToolStripMenuItem_Click);
            // 
            // editeToolStripMenuItem
            // 
            this.editeToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.edit_32;
            this.editeToolStripMenuItem.Name = "editeToolStripMenuItem";
            this.editeToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.editeToolStripMenuItem.Text = "Edite";
            this.editeToolStripMenuItem.Click += new System.EventHandler(this.editeToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ChangePasswordStripMenuItem1
            // 
            this.ChangePasswordStripMenuItem1.Image = global::My_DVLD_Desktop.Properties.Resources.Password_32;
            this.ChangePasswordStripMenuItem1.Name = "ChangePasswordStripMenuItem1";
            this.ChangePasswordStripMenuItem1.Size = new System.Drawing.Size(197, 26);
            this.ChangePasswordStripMenuItem1.Text = "Change Password";
            this.ChangePasswordStripMenuItem1.Click += new System.EventHandler(this.ChangePasswordStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.send_email_32;
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // phoneToolStripMenuItem
            // 
            this.phoneToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.call_32;
            this.phoneToolStripMenuItem.Name = "phoneToolStripMenuItem";
            this.phoneToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.phoneToolStripMenuItem.Text = "Phone";
            // 
            // txtbFilterValue
            // 
            this.txtbFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFilterValue.Location = new System.Drawing.Point(358, 309);
            this.txtbFilterValue.Name = "txtbFilterValue";
            this.txtbFilterValue.Size = new System.Drawing.Size(253, 24);
            this.txtbFilterValue.TabIndex = 10;
            this.txtbFilterValue.TextChanged += new System.EventHandler(this.txtbFilterValue_TextChanged);
            this.txtbFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFilterValue_KeyPress);
            // 
            // cbFilters
            // 
            this.cbFilters.DisplayMember = "0";
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "UserID",
            "UserName",
            "PersonID",
            "FullName",
            "IsActive"});
            this.cbFilters.Location = new System.Drawing.Point(160, 309);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(177, 24);
            this.cbFilters.TabIndex = 9;
            this.cbFilters.Tag = "0";
            this.cbFilters.ValueMember = "0";
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filter By : ";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblCount.Location = new System.Drawing.Point(122, 747);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(45, 25);
            this.lblCount.TabIndex = 12;
            this.lblCount.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 747);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "#Count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(441, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Users Managments";
            // 
            // cbIsActive
            // 
            this.cbIsActive.DisplayMember = "0";
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(358, 309);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(103, 24);
            this.cbIsActive.TabIndex = 16;
            this.cbIsActive.Tag = "0";
            this.cbIsActive.ValueMember = "0";
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Image = global::My_DVLD_Desktop.Properties.Resources.Add_New_User_72;
            this.btnAddNew.Location = new System.Drawing.Point(1070, 256);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(80, 77);
            this.btnAddNew.TabIndex = 15;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::My_DVLD_Desktop.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(461, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1192, 782);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbFilterValue);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvUsers);
            this.Name = "frmUsersManagement";
            this.Text = "frmUsersManagement";
            this.Load += new System.EventHandler(this.frmUsersManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtbFilterValue;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ContextMenuStrip cmUser;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordStripMenuItem1;
    }
}