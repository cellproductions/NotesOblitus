using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using Global;

namespace NotesOblitus
{
	class Updater
	{
		public class DownloadEventArgs : EventArgs
		{
			public int FileCount { get; set; }
		}

		private class ManifestPath
		{
			public bool IsFile { get; set; }
			public string Path { get; set; }
		}

		private class ManifestPathComparer : IComparer<ManifestPath>
		{
			public int Compare(ManifestPath x, ManifestPath y)
			{
				return x.IsFile ? 1 : (!x.IsFile ? -1 : 0);
			}
		}

		public delegate void DownloadsStartedEvent(object sender, DownloadEventArgs args);
		public delegate void DownloadCompleteEvent(object sender, EventArgs args);

		public event DownloadsStartedEvent DownloadsStarted;
		public event DownloadCompleteEvent DownloadComplete;
		private readonly string _downloadPathUrl;
		private readonly List<ManifestPath> _manifestPaths = new List<ManifestPath>();
		private readonly bool _useProxy;
		private readonly WebProxy _proxy;

		public Updater(string downloadUrl, bool useProxy, WebProxy proxy)
		{
			_downloadPathUrl = downloadUrl;
			_useProxy = useProxy;
			_proxy = proxy;
		}

		public Dictionary<string, bool> AreUpdatesAvailable(Version localVersion, out Dictionary<string, Version> newVersions)
		{
			var updates = new Dictionary<string, bool>();
			newVersions = new Dictionary<string, Version>();
			var client = new WebClient();
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

							var version = Version.Parse(linesplit[1]);
							var updateAvailable = version.CompareTo(localVersion) > 0;
							updates.Add(linesplit[0], updateAvailable);
							if (updateAvailable)
								newVersions.Add(linesplit[0], version);
							break;
					}
				}
			}
			_manifestPaths.Sort(new ManifestPathComparer());

			return updates;
		}

		public void DownloadUpdate(string savePath)
		{
			if (savePath[savePath.Length - 1] != '\\')
				savePath += '\\';
			if (DownloadsStarted != null)
				DownloadsStarted(this, new DownloadEventArgs { FileCount = _manifestPaths.Count });

			var pool = new List<Thread>(_manifestPaths.Count);
			foreach (var manifestPath in _manifestPaths)
			{
				if (!manifestPath.IsFile)
					Directory.CreateDirectory(savePath + manifestPath.Path);
				else
				{
					var manifestpath = manifestPath;
					var thread = new Thread(() =>
					{
						var downloadpath = _downloadPathUrl + manifestpath.Path.Replace('\\', '/');
						var savepath = savePath + manifestpath.Path;
						try
						{
							var client = new WebClient();
							try
							{
								client.DownloadFile(new Uri(downloadpath), savepath);
							}
							catch (WebException)
							{
								if (!_useProxy)
									throw;

								client = new WebClient
								{
									Proxy = _proxy
								}; // reset internal stuff

								client.DownloadFile(new Uri(downloadpath), savepath); // first try failed. maybe a proxy is in place? try with the proxy set
							}
						}
						catch (Exception e)
						{
							Logger.Log("Failed to download file! [file=" + manifestpath + ", savepath=" + savepath + ']' + Environment.NewLine + e);
						}
					});
					pool.Add(thread);
				}
			}
			foreach (var thread in pool)
				thread.Start();
			foreach (var thread in pool.Where(thread => thread.IsAlive))
			{
				thread.Join();
				if (DownloadComplete != null)
					DownloadComplete(this, new EventArgs());
			}
		}
	}
}
