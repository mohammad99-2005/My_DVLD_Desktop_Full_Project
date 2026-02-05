namespace My_DVLD_Desktop
{
    partial class PeopleManagment
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
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.cmsPerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.txtbFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.cmsPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.cmsPerson;
            this.dgvPeople.Location = new System.Drawing.Point(1, 322);
            this.dgvPeople.MultiSelect = false;
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersWidth = 30;
            this.dgvPeople.RowTemplate.Height = 24;
            this.dgvPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeople.Size = new System.Drawing.Size(1455, 394);
            this.dgvPeople.TabIndex = 0;
            this.dgvPeople.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPeople_MouseDoubleClick);
            // 
            // cmsPerson
            // 
            this.cmsPerson.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addPersonToolStripMenuItem,
            this.editeToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.emailToolStripMenuItem,
            this.phoneToolStripMenuItem});
            this.cmsPerson.Name = "contextMenuStrip1";
            this.cmsPerson.Size = new System.Drawing.Size(169, 166);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.PersonDetails_321;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Add_Person_401;
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.addPersonToolStripMenuItem.Text = "Add Person";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.addPersonToolStripMenuItem_Click);
            // 
            // editeToolStripMenuItem
            // 
            this.editeToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.edit_32;
            this.editeToolStripMenuItem.Name = "editeToolStripMenuItem";
            this.editeToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.editeToolStripMenuItem.Text = "Edite";
            this.editeToolStripMenuItem.Click += new System.EventHandler(this.editeToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.send_email_32;
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.emailToolStripMenuItem.Text = "Email";
            this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
            // 
            // phoneToolStripMenuItem
            // 
            this.phoneToolStripMenuItem.Image = global::My_DVLD_Desktop.Properties.Resources.call_32;
            this.phoneToolStripMenuItem.Name = "phoneToolStripMenuItem";
            this.phoneToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.phoneToolStripMenuItem.Text = "Phone";
            this.phoneToolStripMenuItem.Click += new System.EventHandler(this.phoneToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(621, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "People Managments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter By : ";
            // 
            // cbFilters
            // 
            this.cbFilters.DisplayMember = "0";
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "GendorCaption",
            "Phone",
            "Email",
            "CountryName"});
            this.cbFilters.Location = new System.Drawing.Point(156, 292);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(177, 24);
            this.cbFilters.TabIndex = 6;
            this.cbFilters.Tag = "0";
            this.cbFilters.ValueMember = "0";
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // txtbFilter
            // 
            this.txtbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFilter.Location = new System.Drawing.Point(354, 292);
            this.txtbFilter.Name = "txtbFilter";
            this.txtbFilter.Size = new System.Drawing.Size(195, 24);
            this.txtbFilter.TabIndex = 7;
            this.txtbFilter.TextChanged += new System.EventHandler(this.txtbFilter_TextChanged);
            this.txtbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFilter_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 721);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "#Count:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblCount.Location = new System.Drawing.Point(107, 721);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(45, 25);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "???";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = global::My_DVLD_Desktop.Properties.Resources.Add_Person_40;
            this.btnAddNew.Location = new System.Drawing.Point(1372, 236);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(84, 80);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::My_DVLD_Desktop.Properties.Resources.People_400;
            this.pictureBox1.Location = new System.Drawing.Point(641, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PeopleManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1459, 755);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbFilter);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPeople);
            this.Name = "PeopleManagment";
            this.Text = "PeopleManagment";
            this.Load += new System.EventHandler(this.PeopleManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.cmsPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.ContextMenuStrip cmsPerson;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox txtbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCount;
    }
}