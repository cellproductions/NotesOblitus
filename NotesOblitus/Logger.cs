using System;
using System.Globalization;
using System.IO;

namespace NotesOblitus
{
	public class Logger
	{
		public const string LogFile = "log.txt";
		private static bool _firstLog = true;
		private static readonly object LogFileLock = new object();

		public static void Log(string message)
		{
			lock (LogFileLock)
			{
				using (var writer = new StreamWriter(LogFile, !_firstLog))
				{
					writer.WriteLine(DateTime.UtcNow.ToString(CultureInfo.InvariantCulture));
					writer.WriteLine(message);
				}
			}

			_firstLog = false;
		}

		public static void Log(Exception e)
		{
			lock (LogFileLock)
			{
				using (var writer = new StreamWriter(LogFile, !_firstLog))
				{
					writer.WriteLine(DateTime.UtcNow.ToString(CultureInfo.InvariantCulture));
					writer.WriteLine(e.ToString());
				}
			}

			_firstLog = false;
		}
	}
}
