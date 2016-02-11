using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SvnBackup
{
    public partial class FrmSetting : Form
    {
        public BackupSetting Setting { get; set; }

        public FrmSetting()
        {
            InitializeComponent();

            //
            this.cmbRetain.Items.Clear();
            for (int i = 1; i < 31; i++)
            {
                this.cmbRetain.Items.Add(i);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Setting.SvnAdminCmd = new FileInfo(this.txbSvnAdminPath.Text);
            Setting.BackupHome = new DirectoryInfo(this.txbBackupFolder.Text);
            Setting.RepositoryHome = new DirectoryInfo(this.txbRepoFolder.Text);
            Setting.BackupTime = this.mtbBackupTime.Text;
            Setting.BackupRetain = this.cmbRetain.SelectedIndex + 1;
            this.DialogResult = DialogResult.OK;
        }

        private void btnSvnFolder_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\Program Files (x86)\VisualSVN Server\bin";
            dialog.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.CheckFileExists = true;
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.txbSvnAdminPath.Text = dialog.FileName;
            }
        }

        private void btnRepoFolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txbRepoFolder.Text = dialog.SelectedPath;
            }
        }

        private void btnBackupFolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txbBackupFolder.Text = dialog.SelectedPath;
            }
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            this.txbSvnAdminPath.Text = Setting.SvnAdminCmd.FullName;
            this.txbRepoFolder.Text = Setting.RepositoryHome.FullName;
            this.txbBackupFolder.Text = Setting.BackupHome.FullName;
            this.mtbBackupTime.Text = Setting.BackupTime;
            this.cmbRetain.Text = Setting.BackupRetain.ToString();
        }
    }
}
