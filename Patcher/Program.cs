using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Global;

namespace Patcher
{
	class Program
	{
		static void Main(string[] args) /** TODO(change) some of the substrings arents needed due to Infos having the shortened paths already */
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

				var localpath = args[0].Trim(); // the path that ApplicationExeName comes from 
				var temppath = args[1].Trim(); // the temp path that the downloaded files are stored
				var tempdirectory = new DirectoryInfo(temppath);
				foreach (var newpath in tempdirectory.GetDirectories("*", SearchOption.AllDirectories).
					Select(dirpath => dirpath.FullName.Substring(dirpath.FullName.IndexOf(temppath, StringComparison.Ordinal) + temppath.Length)).
					Select(shortenedpath => localpath + shortenedpath).
					Where(newpath => !Directory.Exists(newpath)))
				{
					Directory.CreateDirectory(newpath);
				}
				foreach (var filepath in tempdirectory.GetFiles("*", SearchOption.AllDirectories))
				{
					var shortenedpath = filepath.FullName.Substring(filepath.FullName.IndexOf(temppath, StringComparison.Ordinal) + temppath.Length);
					var newpath = localpath + shortenedpath;

					for (var i = 0; i < 100 && IsFileLocked(new FileInfo(newpath)); ++i) // give each file 10 seconds to be unlocked
						Thread.Sleep(100);
					File.Copy(filepath.FullName, newpath, true); // if the file is still locked, chances are the user is using it for something, so crash

					filepath.Delete();
				}
				tempdirectory.Delete(true);

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
			if (!Directory.Exists(args[1]))
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
				stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
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
	}
}
