namespace My_DVLD_Desktop.Applications.Licenses.Controls
{
    partial class ctrlLicenseInfoWithFilter
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
            this.gbFilterbox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbLicenseID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlLicenseInfo2 = new My_DVLD_Desktop.Applications.Licenses.Controls.ctrlLicenseInfo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilterbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilterbox
            // 
            this.gbFilterbox.Controls.Add(this.button1);
            this.gbFilterbox.Controls.Add(this.txtbLicenseID);
            this.gbFilterbox.Controls.Add(this.label1);
            this.gbFilterbox.Location = new System.Drawing.Point(3, 3);
            this.gbFilterbox.Name = "gbFilterbox";
            this.gbFilterbox.Size = new System.Drawing.Size(451, 81);
            this.gbFilterbox.TabIndex = 1;
            this.gbFilterbox.TabStop = false;
            this.gbFilterbox.Text = "Find License";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::My_DVLD_Desktop.Properties.Resources.License_View_321;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(381, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 49);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbLicenseID
            // 
            this.txtbLicenseID.BackColor = System.Drawing.SystemColors.Info;
            this.txtbLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLicenseID.Location = new System.Drawing.Point(107, 29);
            this.txtbLicenseID.Name = "txtbLicenseID";
            this.txtbLicenseID.Size = new System.Drawing.Size(254, 24);
            this.txtbLicenseID.TabIndex = 1;
            this.txtbLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbLicenseID_KeyPress);
            this.txtbLicenseID.Validating += new System.ComponentModel.CancelEventHandler(this.txtbLicenseID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID:";
            // 
            // ctrlLicenseInfo2
            // 
            this.ctrlLicenseInfo2.Location = new System.Drawing.Point(3, 90);
            this.ctrlLicenseInfo2.Name = "ctrlLicenseInfo2";
            this.ctrlLicenseInfo2.Size = new System.Drawing.Size(1144, 373);
            this.ctrlLicenseInfo2.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlLicenseInfo2);
            this.Controls.Add(this.gbFilterbox);
            this.Name = "ctrlLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(1148, 471);
            this.gbFilterbox.ResumeLayout(false);
            this.gbFilterbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLicenseInfo ctrlLicenseInfo1;
        private System.Windows.Forms.GroupBox gbFilterbox;
        private System.Windows.Forms.TextBox txtbLicenseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private ctrlLicenseInfo ctrlLicenseInfo2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
