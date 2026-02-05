namespace My_DVLD_Desktop
{
    partial class frmEditApplicationType
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbAppTitle = new System.Windows.Forms.TextBox();
            this.txtbAppFees = new System.Windows.Forms.TextBox();
            this.lblAppID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Edit Application Types";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Application Title :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Application Fees :";
            // 
            // txtbAppTitle
            // 
            this.txtbAppTitle.Location = new System.Drawing.Point(193, 146);
            this.txtbAppTitle.Name = "txtbAppTitle";
            this.txtbAppTitle.Size = new System.Drawing.Size(333, 22);
            this.txtbAppTitle.TabIndex = 21;
            this.txtbAppTitle.Validating += new System.ComponentModel.CancelEventHandler(this.ApplicationType_Validate);
            // 
            // txtbAppFees
            // 
            this.txtbAppFees.Location = new System.Drawing.Point(193, 198);
            this.txtbAppFees.Name = "txtbAppFees";
            this.txtbAppFees.Size = new System.Drawing.Size(333, 22);
            this.txtbAppFees.TabIndex = 22;
            this.txtbAppFees.Validating += new System.ComponentModel.CancelEventHandler(this.ApplicationTypeFees_Validate);
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppID.ForeColor = System.Drawing.Color.Red;
            this.lblAppID.Location = new System.Drawing.Point(204, 92);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(53, 18);
            this.lblAppID.TabIndex = 23;
            this.lblAppID.Text = "?????";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::My_DVLD_Desktop.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(425, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 33);
            this.btnSave.TabIndex = 75;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::My_DVLD_Desktop.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(296, 266);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 33);
            this.btnClose.TabIndex = 74;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEditApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 311);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAppID);
            this.Controls.Add(this.txtbAppFees);
            this.Controls.Add(this.txtbAppTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditApplicationType";
            this.Text = "frmEditApplicationType";
            this.Load += new System.EventHandler(this.frmEditApplicationType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbAppTitle;
        private System.Windows.Forms.TextBox txtbAppFees;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}