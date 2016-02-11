using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace SvnBackup
{
    public partial class FrmMain : Form
    {
        private System.Timers.Timer timer1 = new System.Timers.Timer(2000);
        private BackupSetting backupSetting;
        private bool taskIsRuning;
        private int settingHour;
        private int settingMinute;

        public FrmMain()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.btnBackup.Enabled = false;
            this.rtbOutput.Text = "正在执行备份 ... " + Environment.NewLine;
            try
            {
                this.rtbOutput.Text += ExeBackup(backupSetting, false);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.btnBackup.Enabled = true;
            }
            this.rtbOutput.Text += "备份完成" + Environment.NewLine;
        }

        private string ExeBackup(BackupSetting setting, bool isTask)
        {
            StringBuilder output = new StringBuilder();

            var p = new Process();
            p.StartInfo.FileName = setting.SvnAdminCmd.FullName;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            //
            string backupPath;
            if (isTask)
            {
                backupPath = Path.Combine(setting.BackupHome.FullName, DateTime.Now.ToString("yyyyMMdd"));
            }
            else
            {
                backupPath = Path.Combine(setting.BackupHome.FullName, DateTime.Now.ToString("yyyyMMddHHmmss"));
            }

            var backupDir = new DirectoryInfo(backupPath);
            if (!backupDir.Exists)
            {
                backupDir.Create();
            }

            //
            foreach (var item in setting.RepositoryHome.GetDirectories())
            {
                if (item.GetFiles("format") != null && item.GetFiles("README.txt") != null)
                {
                    var repoFolder = item;
                    var repoBackupFolder = new DirectoryInfo(Path.Combine(backupDir.FullName, item.Name));
                    repoBackupFolder.Create();

                    p.StartInfo.Arguments = " hotcopy " + repoFolder.FullName + " " + repoBackupFolder.FullName;
                    try
                    {
                        p.Start();
                        p.WaitForExit();
                        p.Close();
                        output.AppendFormat("backup repository {0} to {1}", repoFolder.FullName, repoBackupFolder.FullName);
                    }
                    catch (Exception e)
                    {
                        output.Append(e.Message);
                    }
                }
                output.AppendLine("");
            }

            DeleteExpiredDir(setting);

            return output.ToString();
        }

        public void DeleteDirectory(string targetDir)
        {
            DirectoryInfo folder = new DirectoryInfo(targetDir);

            if (folder.Exists)
            {
                File.SetAttributes(targetDir, FileAttributes.Normal);

                var files = folder.GetFiles();
                var dirs = folder.GetDirectories();

                foreach (var file in files)
                {
                    File.SetAttributes(file.FullName, FileAttributes.Normal);
                    File.Delete(file.FullName);
                }

                foreach (var dir in dirs)
                {
                    DeleteDirectory(dir.FullName);
                }

                Directory.Delete(targetDir, true);
            }
        }

        private void SortAsFolderCreationTime(ref DirectoryInfo[] dirs)
        {
            Array.Sort(dirs, delegate(DirectoryInfo x, DirectoryInfo y) { return y.CreationTime.CompareTo(x.CreationTime); });
        }

        private void DeleteExpiredDir(BackupSetting setting)
        {
            var folders = setting.BackupHome.GetDirectories();
            if (folders.Length > setting.BackupRetain)
            {
                SortAsFolderCreationTime(ref folders);
                for (int i = setting.BackupRetain, c = folders.Length; i < c; i++)
                {
                    DeleteDirectory(folders[i].FullName);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (taskIsRuning == true)
            {
                var res = MessageBox.Show("你有备份任务在执行，是否要退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                {
                    return;
                }
            }

            this.Close();
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            taskIsRuning = true;
            SetButtonEnabled();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            var frmSetting = new FrmSetting();
            frmSetting.Setting = backupSetting;
            frmSetting.ShowDialog(this);
            this.backupSetting = frmSetting.Setting;

            // 修改计划任务的时间
            int index = backupSetting.BackupTime.IndexOf(":");
            settingHour = Convert.ToInt32(backupSetting.BackupTime.Substring(0, index));
            settingMinute = Convert.ToInt32(backupSetting.BackupTime.Substring(index + 1));

            // 保存配置文件
            File.WriteAllText(Program.ConfigFile, JsonHelp.ToJson(backupSetting));
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (backupSetting == null)
            {
                if (File.Exists(Program.ConfigFile))
                {
                    backupSetting = JsonHelp.FromJson<BackupSetting>(File.ReadAllText(Program.ConfigFile));
                }
                else
                {
                    BackupSetting defaultSetting = new BackupSetting();
                    defaultSetting.SvnAdminCmd = new FileInfo(@"C:\Program Files\TortoiseSVN\bin\svnadmin.exe");
                    defaultSetting.BackupHome = new DirectoryInfo(@"D:\backup\svn");
                    defaultSetting.RepositoryHome = new DirectoryInfo(@"D:\repositories");
                    defaultSetting.BackupTime = "01:00";
                    defaultSetting.BackupRetain = 7;
                    backupSetting = defaultSetting;
                    // 保存配置文件
                    File.WriteAllText(Program.ConfigFile, JsonHelp.ToJson(backupSetting));
                }
            }

            int index = backupSetting.BackupTime.IndexOf(":");
            settingHour = Convert.ToInt32(backupSetting.BackupTime.Substring(0, index));
            settingMinute = Convert.ToInt32(backupSetting.BackupTime.Substring(index + 1));

            // Hook up the Elapsed event for the timer.
            timer1.Elapsed += OnTimedEvent;
            timer1.AutoReset = true;

            taskIsRuning = true;
            SetButtonEnabled();

        }

        private void SetButtonEnabled()
        {
            this.btnStart.Enabled = !taskIsRuning;
            this.btnStop.Enabled = taskIsRuning;
            this.timer1.Enabled = taskIsRuning;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            taskIsRuning = false;
            SetButtonEnabled();
        }

        private void OnTimedEvent(object sender, EventArgs e)
        {
            var dateTime = DateTime.Now;
            var hour = dateTime.Hour;
            var minute = dateTime.Minute;

            if (hour == settingHour && minute == settingMinute)
            {
                this.timer1.Stop();
                this.Cursor = Cursors.WaitCursor;
                this.rtbOutput.Text = "正在执行备份 ... " + Environment.NewLine;
                try
                {
                    this.rtbOutput.Text += ExeBackup(backupSetting, true);
                    Thread.Sleep(60000);
                }
                finally
                {
                    this.timer1.Start();
                    this.Cursor = Cursors.Default;
                    this.rtbOutput.Text += "备份完成" + Environment.NewLine;
                }
            }
        }
    }
}