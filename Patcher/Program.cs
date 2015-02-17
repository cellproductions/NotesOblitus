using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using Global;

namespace Patcher
{
	class Program
	{
		static void Main(string[] args)
		{
			if (!CheckArgs(args))
				return;

			CloseAllRunningApps();
			if (Process.GetProcessesByName(GlobalVars.ApplicationExeName).Length > 0)
			{
				Console.WriteLine("Error: Please close all instances of " + GlobalVars.ApplicationExeName + " before patching.");
				return;
			}

			var localpath = args[0].Trim(); // the path that ApplicationExeName comes from 
			var temppath = args[1].Trim(); // the temp path that the downloaded files are stored
			var tempdirectories = Directory.GetDirectories(temppath, "*", SearchOption.AllDirectories);
			foreach (var newpath in tempdirectories.
				Select(dirpath => dirpath.Substring(dirpath.IndexOf(temppath, StringComparison.Ordinal) + temppath.Length)).
				Select(shortenedpath => localpath + shortenedpath).
				Where(newpath => !Directory.Exists(newpath)))
			{
				Directory.CreateDirectory(newpath);
			}
			foreach (var filepath in Directory.GetFiles(temppath, "*", SearchOption.AllDirectories))
			{
				var shortenedpath = filepath.Substring(filepath.IndexOf(temppath, StringComparison.Ordinal) + temppath.Length);
				var newpath = localpath + shortenedpath;
				File.Copy(filepath, newpath, true);

				File.Delete(filepath);
			}
			foreach (var dirpath in tempdirectories)
				Directory.Delete(dirpath);
			Directory.Delete(temppath);

			Process.Start(args[2], args[3]);
		}

		private static bool CheckArgs(IReadOnlyList<string> args)
		{
			if (args.Count != 4)
			{
				Console.WriteLine("Error: Invalid arguments! Usage:");
				Console.WriteLine("Patcher.exe [path to patch to] [path to patch from] [executable path] [executable arguments]");
				return false;
			}

			if (!Directory.Exists(args[0]))
			{
				Console.WriteLine("Error: Invalid \"patch to\" path! [path=" + args[0] + ']');
				return false;
			}
			if (!Directory.Exists(args[1]))
			{
				Console.WriteLine("Error: Invalid \"patch from\" path! [path=" + args[1] + ']');
				return false;
			}
			if (File.Exists(args[2])) 
				return true;

			Console.WriteLine("Error: Invalid executable path! [path=" + args[0] + ']');
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
	}
}
