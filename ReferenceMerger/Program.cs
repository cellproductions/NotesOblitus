using System;
using System.Collections;
using System.Linq;

namespace ReferenceMerger
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				if (args.Length != 1)
				{
					Console.WriteLine("Usage: HTMerge directoryName");
					return;
				}

				var strDir = args[0];

				var exeFiles = System.IO.Directory.GetFiles(strDir, "*.exe");
				var dllFiles = System.IO.Directory.GetFiles(strDir, "*.dll");

				var ar = new ArrayList();

				var bAdded = false;

				//there might be more than 1 exe file, 
				//we go for the first one that isn't the vshost exe
				foreach (var strExe in exeFiles.Where(strExe => !strExe.Contains("vshost")))
				{
					ar.Add(strExe);
					bAdded = true;
					break;
				}

				if (!bAdded)
				{
					Console.WriteLine("Error: No exe could be found");
					//I know multiple returns are bad…
					return;
				}

				bAdded = false;

				foreach (var strDll in dllFiles)
				{
					ar.Add(strDll);
					bAdded = true;
				}

				//no point merging if nothing to merge with!
				if (!bAdded)
				{
					Console.WriteLine("Error: No DLLs could be found");
					//I know multiple returns are bad…
					return;
				}


				//You will need to add a reference to ILMerge.exe from Microsoft
				//See http://research.microsoft.com/~mbarnett/ILMerge.aspx
				var myMerge = new ILMerging.ILMerge();

				var files = (String[])ar.ToArray(typeof(string));

				var strTargetDir = strDir + "\\Merged";

				try
				{
					System.IO.Directory.CreateDirectory(strTargetDir);
				}
				catch (Exception e)
				{
					Console.WriteLine("Error :{0}", e.Message);
				}

				//Here we get the first file name 
				//(which was the .exe file) and use that
				// as the output
				var strOutputFile = System.IO.Path.GetFileName(files[0]);

				myMerge.OutputFile = strTargetDir + "\\" + strOutputFile;
				myMerge.SetInputAssemblies(files);

				myMerge.Merge();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error :{0}", ex.Message);
			}
		}
	}
}
