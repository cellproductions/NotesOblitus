using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
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

		public Updater(string downloadUrl)
		{
			_downloadPathUrl = downloadUrl;
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
							/** TODO(incomplete) add this: 
							 *	client.Proxy = new WebProxy("usrname:pswd@proxy:port"); 
							 *	first try without the proxy, then with the proxy. if still fails, err message
							 */
							client.DownloadFile(new Uri(downloadpath), savepath);
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
		
#if false
		public async Task DownloadUpdate(string savePath)
		{
			if (savePath[savePath.Length - 1] != '\\')
				savePath += '\\';
			var clientlist = new List<WebClient>();
			if (DownloadsStarted != null)
				DownloadsStarted(this, new DownloadEventArgs { FileCount = _manifestPaths.Count });
			foreach (var manifestPath in _manifestPaths)
			{
				var client = new WebClient();
				if (manifestPath.IsFile)
					client.DownloadFileAsync(new Uri(_downloadPathUrl + manifestPath.Path.Replace('\\', '/')),
						savePath + '\\' + manifestPath.Path);
				else
					Directory.CreateDirectory(savePath + '\\' + manifestPath.Path);
				clientlist.Add(client);
			}
			foreach (var client in clientlist)
			{
				while (client.IsBusy) { } /** TODO(note) maybe not the greatest way to wait for the end of the downloads, what if something froze for some reason? */
				if (DownloadComplete != null)
					DownloadComplete(this, new EventArgs());
			}
			if (savePath[savePath.Length - 1] != '\\')
				savePath += '\\';
			if (DownloadsStarted != null)
				DownloadsStarted(this, new DownloadEventArgs { FileCount = _manifestPaths.Count });
			await Task.WhenAll(_manifestPaths.Select(manifestpath => DownloadFile(manifestpath, savePath)));
		}

		private async Task DownloadFile(ManifestPath manifestPath, string savePath)
		{
			var client = new WebClient();
			client.DownloadFileCompleted += (sender, args) =>
			{
				if (DownloadComplete != null)
					DownloadComplete(this, new EventArgs());
			};
			if (manifestPath.IsFile)
				await client.DownloadFileTaskAsync(new Uri(_downloadPathUrl + manifestPath.Path.Replace('\\', '/')), savePath + '\\' + manifestPath.Path);
			else
				Directory.CreateDirectory(savePath + '\\' + manifestPath.Path);
		}
#endif
	}
}
