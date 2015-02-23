using System;
using System.IO;

namespace VersionUpdater
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length != 2 || args[0].Trim().Length <= 0 || args[1].Trim().Length <= 0)
			{
				Console.WriteLine("Error: Invalid arguments! Usage:");
				Console.WriteLine("\tVersionUpdater.exe [file containing the versionname] [version name]");
				return;
			}

			var filepath = args[0].Trim();
			var versionname = args[1].Trim();

			if (!File.Exists(filepath))
			{
				Console.WriteLine("Error: File does not exist! [path=" + filepath + ']');
				return;
			}

			var lines = File.ReadAllLines(filepath);
			var found = false;
			for (var i = 0; i < lines.Length; ++i)
			{
				var line = lines[i];
				var index = line.IndexOf(versionname, StringComparison.Ordinal);
				if (index < 0) 
					continue;

				found = true;
				var split = line.Split('"');
				index = split[0].Length + 1;
				var version = split[1].Split('.');
				index += version[0].Length + 1 + version[1].Length + 1;
				var build = version[2].Trim();
				var ibuild = long.Parse(build);
				++ibuild;
				var newbuild = ibuild.ToString();
				var newlines = lines;
				newlines[i] = newlines[i].Substring(0, index) + newbuild + newlines[i].Substring(index + build.Length);
				File.WriteAllLines(filepath, newlines);
				Console.WriteLine(versionname + " version " + build + " successfuly updated to " + newbuild + ".");
				break;
			}
			if (!found)
				Console.WriteLine("Error: Failed to find version name inside file! [path=" + filepath + ", name=" + versionname + ']');
		}
	}
}
