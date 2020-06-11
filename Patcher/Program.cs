using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Global;

namespace Patcher
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				if (!CheckArgs(args))
					return;

				CloseAllRunningApps();
				if (Process.GetProcessesByName(GlobalVars.ApplicationExeName).Length > 0)
				{
					MessageBox.Show("Please close all instances of " + GlobalVars.ApplicationExeName + " before patching.", "Patch Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				var localpath = Path.GetFullPath(args[0].Trim()); // the path that ApplicationExeName comes from
				var packagepath = Path.GetFullPath(args[1].Trim()); // the path that the downloaded zip is stored at

                const int sleeptime = 100;
                for (var i = 0; i < sleeptime && IsFileLocked(new FileInfo(packagepath)); ++i) // give zip file 10 seconds to be unlocked
                    Thread.Sleep(sleeptime);

                var excludedpaths = new HashSet<string> {packagepath, Application.ExecutablePath};
                var tempdir = Path.Combine(localpath, "unpack");
                CreateBackups(tempdir, localpath, excludedpaths);
                var startedwrite = false;

                try
                {
                    using (var stream = File.OpenRead(packagepath)) // if the file is still locked, chances are the user is using it for something, so crash
                    {
                        var archive = new ZipArchive(stream, ZipArchiveMode.Read);
                        foreach (var entry in archive.Entries)
                        {
                            var writepath = Path.Combine(localpath, entry.FullName);
                            if (excludedpaths.Contains(writepath))
                                continue;
                            if (entry.FullName.EndsWith("\\"))
                            {
                                // is empty directory
                                if (!Directory.Exists(writepath))
                                    Directory.CreateDirectory(writepath);
                                continue;
                            }

                            using (var filestream = File.Open(writepath, FileMode.Create, FileAccess.Write))
                            {
                                using (var entrystream = entry.Open())
                                {
                                    startedwrite = true;
                                    entrystream.CopyTo(filestream);
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    if (startedwrite) // restore from backup
                        CopyDirectory(tempdir, localpath, excludedpaths);
                    throw;
                }
                finally
                {
                    File.Delete(packagepath);
                    RemoveDirectory(tempdir);
                }

                var process = new ProcessStartInfo(args[2], args[3])
				{
					UseShellExecute = true
				};
				Process.Start(process);
			}
			catch (Exception e)
			{
				MessageBox.Show("An exception occured while patching!" + Environment.NewLine + e, "Patch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private static bool CheckArgs(IReadOnlyList<string> args)
		{
			if (args.Count != 4)
			{
				MessageBox.Show("Invalid arguments! Usage:" + Environment.NewLine + 
					"Patcher.exe [path to patch to] [path to patch from] [executable path] [executable arguments]", "Patch Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (!Directory.Exists(args[0]))
			{
				MessageBox.Show("Invalid \"patch to\" path! [path=" + args[0] + ']', "Patch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (!File.Exists(args[1]))
			{
				MessageBox.Show("Invalid \"patch from\" path! [path=" + args[1] + ']', "Patch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (File.Exists(args[2])) 
				return true;

			MessageBox.Show("Invalid executable path! [path=" + args[2] + ']', "Patch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}

		private static void CloseAllRunningApps()
		{
			foreach (var process in Process.GetProcessesByName(GlobalVars.ApplicationExeName).Where(process => !process.HasExited))
			{
				process.Kill();
				for (var i = 0; i < 100 && !process.HasExited; ++i) // give each app 10 seconds to close
					Thread.Sleep(100);
			}
		}

		private static bool IsFileLocked(FileInfo file)
		{
			FileStream stream = null;

			try
			{
				stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
			}
			catch (IOException)
			{
				return true;
			}
			finally
			{
				if (stream != null)
					stream.Close();
			}

			return false;
		}

        private static void RemoveDirectory(string path)
        {
            if (Directory.Exists(path))
                Directory.Delete(path, true);
        }

        private static void CreateBackups(string backupPath, string originalPath, ICollection<string> excludedPaths)
        {
            RemoveDirectory(backupPath);
            Directory.CreateDirectory(backupPath);
            CopyDirectory(originalPath, backupPath, excludedPaths);
        }

        private static void CopyDirectory(string fromPath, string toPath, ICollection<string> excludedPaths)
        {
            foreach (var filepath in Directory.EnumerateFiles(fromPath))
                if (!excludedPaths.Contains(filepath)) // dont copy the package file if it is in this folder
                {
                    var path = Path.Combine(toPath, filepath.Substring(fromPath.Length + 1)); // + 1 to remove slash
                    File.Copy(filepath, path, true);
                }
        }
	}
}
