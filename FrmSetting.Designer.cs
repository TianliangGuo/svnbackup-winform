namespace SvnBackup
{
    partial class FrmSetting
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSvnAdminPath = new System.Windows.Forms.Label();
            this.lblRepoDir = new System.Windows.Forms.Label();
            this.txbSvnAdminPath = new System.Windows.Forms.TextBox();
            this.btnSvnAdminPath = new System.Windows.Forms.Button();
            this.txbRepoFolder = new System.Windows.Forms.TextBox();
            this.btnRepoFolder = new System.Windows.Forms.Button();
            this.lblBackupTime = new System.Windows.Forms.Label();
            this.lblBackup = new System.Windows.Forms.Label();
            this.txbBackupFolder = new System.Windows.Forms.TextBox();
            this.btnBackupFolder = new System.Windows.Forms.Button();
            this.lblBackupRetain = new System.Windows.Forms.Label();
            this.cmbRetain = new System.Windows.Forms.ComboBox();
            this.mtbBackupTime = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Controls.Add(this.lblSvnAdminPath, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRepoDir, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txbSvnAdminPath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSvnAdminPath, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbRepoFolder, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRepoFolder, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBackupTime, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblBackup, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txbBackupFolder, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnBackupFolder, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblBackupRetain, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbRetain, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.mtbBackupTime, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSvnAdminPath
            // 
            this.lblSvnAdminPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSvnAdminPath.AutoSize = true;
            this.lblSvnAdminPath.Location = new System.Drawing.Point(20, 26);
            this.lblSvnAdminPath.Name = "lblSvnAdminPath";
            this.lblSvnAdminPath.Size = new System.Drawing.Size(77, 12);
            this.lblSvnAdminPath.TabIndex = 0;
            this.lblSvnAdminPath.Text = "svnadmin路径";
            // 
            // lblRepoDir
            // 
            this.lblRepoDir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRepoDir.AutoSize = true;
            this.lblRepoDir.Location = new System.Drawing.Point(8, 61);
            this.lblRepoDir.Name = "lblRepoDir";
            this.lblRepoDir.Size = new System.Drawing.Size(89, 12);
            this.lblRepoDir.TabIndex = 1;
            this.lblRepoDir.Text = "Repository目录";
            // 
            // txbSvnAdminPath
            // 
            this.txbSvnAdminPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txbSvnAdminPath, 2);
            this.txbSvnAdminPath.Location = new System.Drawing.Point(103, 22);
            this.txbSvnAdminPath.Name = "txbSvnAdminPath";
            this.txbSvnAdminPath.Size = new System.Drawing.Size(342, 21);
            this.txbSvnAdminPath.TabIndex = 2;
            this.txbSvnAdminPath.Text = "C:\\Program Files (x86)\\VisualSVN Server\\bin\\svnadmin.exe";
            // 
            // btnSvnAdminPath
            // 
            this.btnSvnAdminPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSvnAdminPath.Location = new System.Drawing.Point(451, 21);
            this.btnSvnAdminPath.Name = "btnSvnAdminPath";
            this.btnSvnAdminPath.Size = new System.Drawing.Size(35, 22);
            this.btnSvnAdminPath.TabIndex = 3;
            this.btnSvnAdminPath.Text = "...";
            this.btnSvnAdminPath.UseVisualStyleBackColor = true;
            this.btnSvnAdminPath.Click += new System.EventHandler(this.btnSvnFolder_Click);
            // 
            // txbRepoFolder
            // 
            this.txbRepoFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txbRepoFolder, 2);
            this.txbRepoFolder.Location = new System.Drawing.Point(103, 57);
            this.txbRepoFolder.Name = "txbRepoFolder";
            this.txbRepoFolder.Size = new System.Drawing.Size(342, 21);
            this.txbRepoFolder.TabIndex = 5;
            this.txbRepoFolder.Text = "D:\\Repositories\\synclient";
            // 
            // btnRepoFolder
            // 
            this.btnRepoFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRepoFolder.Location = new System.Drawing.Point(451, 56);
            this.btnRepoFolder.Name = "btnRepoFolder";
            this.btnRepoFolder.Size = new System.Drawing.Size(35, 22);
            this.btnRepoFolder.TabIndex = 6;
            this.btnRepoFolder.Text = "...";
            this.btnRepoFolder.UseVisualStyleBackColor = true;
            this.btnRepoFolder.Click += new System.EventHandler(this.btnRepoFolder_Click);
            // 
            // lblBackupTime
            // 
            this.lblBackupTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBackupTime.AutoSize = true;
            this.lblBackupTime.Location = new System.Drawing.Point(44, 131);
            this.lblBackupTime.Name = "lblBackupTime";
            this.lblBackupTime.Size = new System.Drawing.Size(53, 12);
            this.lblBackupTime.TabIndex = 4;
            this.lblBackupTime.Text = "备份时间";
            // 
            // lblBackup
            // 
            this.lblBackup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBackup.AutoSize = true;
            this.lblBackup.Location = new System.Drawing.Point(44, 96);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(53, 12);
            this.lblBackup.TabIndex = 8;
            this.lblBackup.Text = "备份目录";
            // 
            // txbBackupFolder
            // 
            this.txbBackupFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txbBackupFolder, 2);
            this.txbBackupFolder.Location = new System.Drawing.Point(103, 92);
            this.txbBackupFolder.Name = "txbBackupFolder";
            this.txbBackupFolder.Size = new System.Drawing.Size(342, 21);
            this.txbBackupFolder.TabIndex = 9;
            this.txbBackupFolder.Text = "E:\\backup\\svn\\synclient";
            // 
            // btnBackupFolder
            // 
            this.btnBackupFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBackupFolder.Location = new System.Drawing.Point(451, 91);
            this.btnBackupFolder.Name = "btnBackupFolder";
            this.btnBackupFolder.Size = new System.Drawing.Size(35, 22);
            this.btnBackupFolder.TabIndex = 10;
            this.btnBackupFolder.Text = "...";
            this.btnBackupFolder.UseVisualStyleBackColor = true;
            this.btnBackupFolder.Click += new System.EventHandler(this.btnBackupFolder_Click);
            // 
            // lblBackupRetain
            // 
            this.lblBackupRetain.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBackupRetain.AutoSize = true;
            this.lblBackupRetain.Location = new System.Drawing.Point(44, 166);
            this.lblBackupRetain.Name = "lblBackupRetain";
            this.lblBackupRetain.Size = new System.Drawing.Size(53, 12);
            this.lblBackupRetain.TabIndex = 11;
            this.lblBackupRetain.Text = "保留天数";
            // 
            // cmbRetain
            // 
            this.cmbRetain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRetain.FormattingEnabled = true;
            this.cmbRetain.Location = new System.Drawing.Point(103, 162);
            this.cmbRetain.Name = "cmbRetain";
            this.cmbRetain.Size = new System.Drawing.Size(133, 20);
            this.cmbRetain.TabIndex = 12;
            // 
            // mtbBackupTime
            // 
            this.mtbBackupTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbBackupTime.Location = new System.Drawing.Point(103, 127);
            this.mtbBackupTime.Mask = "90:00";
            this.mtbBackupTime.Name = "mtbBackupTime";
            this.mtbBackupTime.Size = new System.Drawing.Size(133, 21);
            this.mtbBackupTime.TabIndex = 13;
            this.mtbBackupTime.Text = " 100";
            this.mtbBackupTime.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel1.Size = new System.Drawing.Size(504, 62);
            this.panel1.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(313, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 25);
            this.btnOK.TabIndex = 3;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(404, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(498, 1);
            this.label4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(242, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "备份时间，格式 1:00 ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(242, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "备份文件保留天数，默认保留 7 天";
            // 
            // FrmSetting
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(504, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "备份设置";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSvnAdminPath;
        private System.Windows.Forms.Label lblRepoDir;
        private System.Windows.Forms.TextBox txbSvnAdminPath;
        private System.Windows.Forms.Button btnSvnAdminPath;
        private System.Windows.Forms.Label lblBackupTime;
        private System.Windows.Forms.TextBox txbRepoFolder;
        private System.Windows.Forms.Button btnRepoFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.TextBox txbBackupFolder;
        private System.Windows.Forms.Button btnBackupFolder;
        private System.Windows.Forms.Label lblBackupRetain;
        private System.Windows.Forms.ComboBox cmbRetain;
        private System.Windows.Forms.MaskedTextBox mtbBackupTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}