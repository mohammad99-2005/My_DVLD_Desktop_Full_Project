namespace My_DVLD_Desktop.Applications.Test_Types
{
    partial class EditTestTypes
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTestID = new System.Windows.Forms.Label();
            this.txtbTestDesc = new System.Windows.Forms.TextBox();
            this.txtbTestTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbTestFees = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::My_DVLD_Desktop.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(412, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 33);
            this.btnSave.TabIndex = 84;
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
            this.btnClose.Location = new System.Drawing.Point(296, 325);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 33);
            this.btnClose.TabIndex = 83;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTestID
            // 
            this.lblTestID.AutoSize = true;
            this.lblTestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestID.ForeColor = System.Drawing.Color.Red;
            this.lblTestID.Location = new System.Drawing.Point(191, 92);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(53, 18);
            this.lblTestID.TabIndex = 82;
            this.lblTestID.Text = "?????";
            // 
            // txtbTestDesc
            // 
            this.txtbTestDesc.Location = new System.Drawing.Point(180, 161);
            this.txtbTestDesc.Multiline = true;
            this.txtbTestDesc.Name = "txtbTestDesc";
            this.txtbTestDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbTestDesc.Size = new System.Drawing.Size(333, 94);
            this.txtbTestDesc.TabIndex = 81;
            // 
            // txtbTestTitle
            // 
            this.txtbTestTitle.Location = new System.Drawing.Point(180, 123);
            this.txtbTestTitle.Name = "txtbTestTitle";
            this.txtbTestTitle.Size = new System.Drawing.Size(333, 22);
            this.txtbTestTitle.TabIndex = 80;
            this.txtbTestTitle.Validating += new System.ComponentModel.CancelEventHandler(this.TestTypeTitle_Validate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 79;
            this.label4.Text = "Test Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "Test Title :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 77;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 36);
            this.label1.TabIndex = 76;
            this.label1.Text = "Edit Test Type";
            // 
            // txtbTestFees
            // 
            this.txtbTestFees.Location = new System.Drawing.Point(180, 270);
            this.txtbTestFees.Name = "txtbTestFees";
            this.txtbTestFees.Size = new System.Drawing.Size(158, 22);
            this.txtbTestFees.TabIndex = 86;
            this.txtbTestFees.Validating += new System.ComponentModel.CancelEventHandler(this.TestTypeFees_Validate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 85;
            this.label5.Text = "Test Fees :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 370);
            this.Controls.Add(this.txtbTestFees);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTestID);
            this.Controls.Add(this.txtbTestDesc);
            this.Controls.Add(this.txtbTestTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditTestTypes";
            this.Text = "EditTestTypes";
            this.Load += new System.EventHandler(this.EditTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTestID;
        private System.Windows.Forms.TextBox txtbTestDesc;
        private System.Windows.Forms.TextBox txtbTestTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbTestFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}