using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Global;

namespace ManifestBuilder
{
	class Program
	{
		static void Main(string[] args) // args[0] should be path to files to build manifest from, manifest file will go there as well
		{
			Console.WriteLine("Preparing manifest");
			if (args.Length == 0 || args[0].Trim().Length <= 0)
			{
				Console.WriteLine("Invalid manifest path! [path=" + args[0] + ']');
				return;
			}
			args[0] = args[0].Trim();
			if (!IsDirectory(args[0]))
			{
				Console.WriteLine("Manifest path is not a directory! [path=" + args[0] + ']');
				return;
			}
			var manifesttext = "Application:" + GlobalVars.ApplicationVersion + Environment.NewLine + "Manifest:" + GlobalVars.ManifestBuilderVersion + 
				Environment.NewLine + "Updater:" + GlobalVars.PatcherVersion + Environment.NewLine;
			var manifestpath = args[0][args[0].Length - 1] != '/' && args[0][args[0].Length - 1] != '\\'
				? args[0] + '\\'
				: args[0];
			manifestpath = manifestpath.Replace('/', '\\');
			var startpath = GetFolderName(args[0]);

			var sortedentries = new List<string>(Directory.GetFileSystemEntries(manifestpath, "*", SearchOption.AllDirectories));
			sortedentries.Sort(); // keeps files after their respective directories
			foreach (var entry in sortedentries.Where(entry => !entry.EndsWith(GlobalVars.ManifestFileName)))
			{
				var shortpath = entry.Substring(entry.LastIndexOf(startpath, StringComparison.Ordinal) + startpath.Length + 1);
				var isfile = !IsDirectory(entry);
				manifesttext += (isfile ? "F" : "D");
				manifesttext += ' ' + shortpath + Environment.NewLine;
			}
			Console.WriteLine("Writing manifest");
			File.WriteAllText(manifestpath + GlobalVars.ManifestFileName, manifesttext);
			Console.WriteLine("Manifest written to " + manifestpath + GlobalVars.ManifestFileName);
		}

		private static string GetFolderName(string path)
		{
			var index = path.LastIndexOf('\\', path.Length - 2); // skip the first backslash
			return index >= 0 && index + 1 < path.Length ? path.Substring(index + 1) : path;
		}

		private static bool IsDirectory(string path)
		{
			return Directory.Exists(path);
		}
	}
}
