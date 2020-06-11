using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using Global;

namespace ManifestBuilder
{
	class Program
	{
		static void Main(string[] args) // args[0] should be path to files to build manifest from, manifest file will go there as well
        {
            string manifestpath;

            Console.WriteLine("Preparing manifest");
            switch (args.Length)
            {
                case 1:
                    manifestpath = args[0].Trim();
                    break;
                default:
                    DisplayUsage();
                    return;
            }
            if (manifestpath.Length <= 0)
            {
                Console.WriteLine("Invalid application path! Path cannot be empty.");
                return;
            }
            var now = DateTime.Now;
            var zipname = now.Day + "." + now.Month + "." + now.Year;
            manifestpath = GetFolderPath(manifestpath).Replace('/', '\\');
            
			var manifesttext = "Application:" + GlobalVars.ApplicationVersion + Environment.NewLine + 
                               "Manifest:" + GlobalVars.ManifestBuilderVersion + Environment.NewLine + 
                               "Patcher:" + GlobalVars.PatcherVersion + Environment.NewLine +
                               "Compressed:" + zipname + Environment.NewLine;

            var sortedentries = new List<string>(Directory.GetFileSystemEntries(manifestpath, "*", SearchOption.AllDirectories));
			sortedentries.Sort(); // keeps files after their respective directories
			foreach (var entry in sortedentries.Where(entry => !entry.EndsWith(GlobalVars.ManifestFileName))) /** TODO(refactor) should store file paths only and their hashes for comparison */
			{
                var shortpath = entry.Substring(manifestpath.Length + 1); // + 1 for last slash
				var isfile = !IsDirectory(entry);
				manifesttext += isfile ? "F" : "D";
				manifesttext += ' ' + shortpath + Environment.NewLine;
			}
			Console.WriteLine("Writing manifest");
            var manifestfilepath = Path.GetFullPath(Path.Combine(Path.Combine(manifestpath, ".."), GlobalVars.ManifestFileName));
            File.WriteAllText(manifestfilepath, manifesttext);
            Console.WriteLine("Manifest written to " + manifestfilepath);

            Console.WriteLine("Compressing directory");
            const string packagename = "NotesOblitusPackage.zip";
            var compressedpath = Path.GetFullPath(Path.Combine(Path.Combine(manifestpath, ".."), packagename));
            if (File.Exists(compressedpath))
                File.Delete(compressedpath);
            ZipFile.CreateFromDirectory(manifestpath, compressedpath, CompressionLevel.Optimal, false, Encoding.UTF8);
            Console.WriteLine("Compressed directory written to " + compressedpath);
        }

		private static string GetFolderPath(string path)
        {
            return IsDirectory(path) ? path : Path.GetDirectoryName(path);
        }

		private static bool IsDirectory(string path)
		{
			return Directory.Exists(path);
		}

        private static void DisplayUsage()
        {
            Console.WriteLine("Usage: ManifestBuilder.exe <Application_Directory>");
        }
	}
}
