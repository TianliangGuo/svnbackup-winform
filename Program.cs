using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SvnBackup
{
    static class Program
    {
        public const string ConfigFile = "conf.json";

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
