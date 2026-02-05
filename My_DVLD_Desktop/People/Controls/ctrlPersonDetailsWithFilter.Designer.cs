namespace My_DVLD_Desktop
{
    partial class ctrlPersonDetailsWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonDetails1 = new My_DVLD_Desktop.ctrlPersonDetails();
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.btnAddPerson);
            this.gbFilters.Controls.Add(this.btnFindPerson);
            this.gbFilters.Controls.Add(this.txtSearch);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Controls.Add(this.cbFilters);
            this.gbFilters.Location = new System.Drawing.Point(3, 12);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(982, 64);
            this.gbFilters.TabIndex = 1;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackgroundImage = global::My_DVLD_Desktop.Properties.Resources.Add_Person_40;
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPerson.Location = new System.Drawing.Point(662, 17);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(42, 41);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.BackgroundImage = global::My_DVLD_Desktop.Properties.Resources.SearchPerson;
            this.btnFindPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindPerson.Location = new System.Drawing.Point(605, 16);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(42, 42);
            this.btnFindPerson.TabIndex = 3;
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(391, 24);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By :";
            // 
            // cbFilters
            // 
            this.cbFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "National No",
            "Person ID"});
            this.cbFilters.Location = new System.Drawing.Point(192, 23);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(180, 26);
            this.cbFilters.TabIndex = 0;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            this.cbFilters.Validating += new System.ComponentModel.CancelEventHandler(this.cbFilters_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonDetails1
            // 
            this.ctrlPersonDetails1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrlPersonDetails1.Location = new System.Drawing.Point(3, 82);
            this.ctrlPersonDetails1.Name = "ctrlPersonDetails1";
            this.ctrlPersonDetails1.Size = new System.Drawing.Size(982, 328);
            this.ctrlPersonDetails1.TabIndex = 0;
            this.ctrlPersonDetails1.Load += new System.EventHandler(this.ctrlPersonDetails1_Load);
            // 
            // ctrlPersonDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.ctrlPersonDetails1);
            this.Name = "ctrlPersonDetailsWithFilter";
            this.Size = new System.Drawing.Size(990, 419);
            this.Load += new System.EventHandler(this.ctrlPersonDetailsWithFilter_Load);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonDetails ctrlPersonDetails1;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
