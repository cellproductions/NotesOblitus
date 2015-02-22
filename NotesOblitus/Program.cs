using System;
using System.Windows.Forms;

namespace NotesOblitus
{
	static class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
#if DEBUG
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new NotesOblitusApp(args.Length > 0 ? args[0] : ""));
#else
			try
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new NotesOblitusApp(args.Length > 0 ? args[0] : ""));
			}
			catch (Exception e)
			{
				Logger.Log("arg=" + (args.Length > 0 ? args[0] : "null") + Environment.NewLine + e);
			}
#endif
		}
	}
}
