# svnbackup-winform
SVN 自动备份软件，备份 Windows 平台 SVN 的资料库

使用步骤：
1. 启动主程序 SvnBackup.exe
2. 点击设置按钮，
  -设置 svnadmin 工具的路径
  -设置资料库的根路径，  注意：这里是根路径，不是某个资料库；程序会扫描根下面所有的SVN资料库进行备份。
  -设置备份根路径
  -设置备份的时间点
  -设置备份保留多少份。
3. 启动计划任务，自动备份开始了。
