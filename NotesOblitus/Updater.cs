using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Global;

namespace NotesOblitus
{
	public delegate void DownloadEvent(object sender, DownloadProgressChangedEventArgs args);

	class Updater
	{
		private class ManifestPath
		{
			public bool IsFile { get; set; }
			public string Path { get; set; }
		}

		public event DownloadEvent DownloadProgressChanged;
		private readonly string _downloadPathUrl;
		private readonly List<ManifestPath> _manifestPaths = new List<ManifestPath>();

		public Updater(string downloadUrl)
		{
			_downloadPathUrl = downloadUrl;
		}

		public Dictionary<string, bool> AreUpdatesAvailable(Version localVersion, out Dictionary<string, Version> newVersions)
		{
			var updates = new Dictionary<string, bool>();
			newVersions = new Dictionary<string, Version>();
			var client = new WebClient();
			try
			{
				Stream stream;
				try
				{
					stream = client.OpenRead(_downloadPathUrl + GlobalVars.ManifestFileName);
					if (stream == null)
						return updates;
				}
				catch (Exception)
				{
					return updates;
				}

				using (var reader = new StreamReader(stream))
				{
					while (!reader.EndOfStream)
					{
						var line = reader.ReadLine();
						if (string.IsNullOrEmpty(line))
							continue;

						switch (line[0])
						{
							case 'F':
								_manifestPaths.Add(new ManifestPath { IsFile = true, Path = line.Substring(2) }); // 2 skips the type and the space
								break;
							case 'D':
								_manifestPaths.Add(new ManifestPath { IsFile = false, Path = line.Substring(2) });
								break;
							default:
								var linesplit = line.Split(':');

								var version = Version.Parse(linesplit[0]);
								var updateAvailable = version.CompareTo(localVersion) > 0;
								updates.Add(linesplit[0], updateAvailable);
								if (updateAvailable)
									newVersions.Add(linesplit[0], version);
								break;
						}
					}
				}
			}
			catch (Exception)
			{
				client.Dispose();
				throw;
			}
			
			client.Dispose();
			return updates;
		}

		public void DownloadUpdate(string savePath)
		{
			var client = new WebClient();
			if (DownloadProgressChanged != null)
				client.DownloadProgressChanged += (sender, args) => DownloadProgressChanged(sender, args);

			if (savePath[savePath.Length - 1] != '\\')
				savePath += '\\';
			try
			{
				foreach (var manifestPath in _manifestPaths)
				{
					if (manifestPath.IsFile)
						client.DownloadFileAsync(new Uri(_downloadPathUrl + manifestPath.Path.Replace('\\', '/')),
							savePath + '\\' + manifestPath.Path);
					else
						Directory.CreateDirectory(savePath + '\\' + manifestPath.Path);
				}
			}
			catch (Exception)
			{
				client.Dispose();
				throw;
			}
			client.Dispose();
		}
	}
}
