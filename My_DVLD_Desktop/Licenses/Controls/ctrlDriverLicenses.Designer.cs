namespace My_DVLD_Desktop.Drivers.Controls
{
    partial class ctrlDriverLicenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabLocal = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.driverLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCountLocal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabInternational = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvInternational = new System.Windows.Forms.DataGridView();
            this.lblCountInternational = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TabControl);
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1229, 358);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabLocal);
            this.TabControl.Controls.Add(this.tabInternational);
            this.TabControl.Location = new System.Drawing.Point(6, 21);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1217, 332);
            this.TabControl.TabIndex = 0;
            // 
            // tabLocal
            // 
            this.tabLocal.Controls.Add(this.label5);
            this.tabLocal.Controls.Add(this.dgvLocal);
            this.tabLocal.Controls.Add(this.lblCountLocal);
            this.tabLocal.Controls.Add(this.label2);
            this.tabLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLocal.Location = new System.Drawing.Point(4, 25);
            this.tabLocal.Name = "tabLocal";
            this.tabLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocal.Size = new System.Drawing.Size(1209, 303);
            this.tabLocal.TabIndex = 0;
            this.tabLocal.Text = "Local";
            this.tabLocal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Local License History:";
            // 
            // dgvLocal
            // 
            this.dgvLocal.AllowUserToAddRows = false;
            this.dgvLocal.AllowUserToDeleteRows = false;
            this.dgvLocal.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocal.Location = new System.Drawing.Point(6, 46);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLocal.RowHeadersWidth = 51;
            this.dgvLocal.RowTemplate.Height = 24;
            this.dgvLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocal.Size = new System.Drawing.Size(1197, 229);
            this.dgvLocal.TabIndex = 22;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driverLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 28);
            // 
            // driverLicenseToolStripMenuItem
            // 
            this.driverLicenseToolStripMenuItem.Name = "driverLicenseToolStripMenuItem";
            this.driverLicenseToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.driverLicenseToolStripMenuItem.Text = "Driver License";
            this.driverLicenseToolStripMenuItem.Click += new System.EventHandler(this.driverLicenseToolStripMenuItem_Click);
            // 
            // lblCountLocal
            // 
            this.lblCountLocal.AutoSize = true;
            this.lblCountLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountLocal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCountLocal.Location = new System.Drawing.Point(81, 281);
            this.lblCountLocal.Name = "lblCountLocal";
            this.lblCountLocal.Size = new System.Drawing.Size(35, 18);
            this.lblCountLocal.TabIndex = 21;
            this.lblCountLocal.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Count:";
            // 
            // tabInternational
            // 
            this.tabInternational.Controls.Add(this.label4);
            this.tabInternational.Controls.Add(this.dgvInternational);
            this.tabInternational.Controls.Add(this.lblCountInternational);
            this.tabInternational.Controls.Add(this.label3);
            this.tabInternational.Location = new System.Drawing.Point(4, 25);
            this.tabInternational.Name = "tabInternational";
            this.tabInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tabInternational.Size = new System.Drawing.Size(1209, 303);
            this.tabInternational.TabIndex = 1;
            this.tabInternational.Text = "International";
            this.tabInternational.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "International License History:";
            // 
            // dgvInternational
            // 
            this.dgvInternational.AllowUserToAddRows = false;
            this.dgvInternational.AllowUserToDeleteRows = false;
            this.dgvInternational.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvInternational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternational.ContextMenuStrip = this.contextMenuStrip2;
            this.dgvInternational.Location = new System.Drawing.Point(6, 46);
            this.dgvInternational.Name = "dgvInternational";
            this.dgvInternational.ReadOnly = true;
            this.dgvInternational.RowHeadersWidth = 51;
            this.dgvInternational.RowTemplate.Height = 24;
            this.dgvInternational.Size = new System.Drawing.Size(1147, 229);
            this.dgvInternational.TabIndex = 21;
            // 
            // lblCountInternational
            // 
            this.lblCountInternational.AutoSize = true;
            this.lblCountInternational.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountInternational.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCountInternational.Location = new System.Drawing.Point(81, 281);
            this.lblCountInternational.Name = "lblCountInternational";
            this.lblCountInternational.Size = new System.Drawing.Size(35, 18);
            this.lblCountInternational.TabIndex = 20;
            this.lblCountInternational.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Count:";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(211, 56);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem1.Text = "Int Driver License";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(1235, 384);
            this.groupBox1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabLocal.ResumeLayout(false);
            this.tabLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabInternational.ResumeLayout(false);
            this.tabInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabLocal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.Label lblCountLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabInternational;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvInternational;
        private System.Windows.Forms.Label lblCountInternational;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem driverLicenseToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
