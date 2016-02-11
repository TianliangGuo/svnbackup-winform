using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace SvnBackup
{
    public class BackupSetting
    {
        public FileInfo SvnAdminCmd { get; set; }

        public DirectoryInfo BackupHome { get; set; }

        public DirectoryInfo RepositoryHome { get; set; }

        public string BackupTime { get; set; }

        public int BackupRetain { get; set; }
    }


}