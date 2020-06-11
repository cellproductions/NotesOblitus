using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;

namespace NotesOblitus
{
	class Updater
	{
		public class DownloadEventArgs : EventArgs
		{
			public int FileCount { get; set; }
		}

		public delegate void DownloadsStartedEvent(object sender, DownloadEventArgs args);
		public delegate void DownloadCompleteEvent(object sender, EventArgs args);

		public event DownloadsStartedEvent DownloadsStarted;
		public event DownloadCompleteEvent DownloadComplete;
		private readonly string _manifestPathUrl;
		private readonly string _packagePathUrl;
		private readonly bool _useProxy;
		private readonly WebProxy _proxy;

		public Updater(string manifestUrl, string packageUrl, bool useProxy, WebProxy proxy)
		{
            _manifestPathUrl = manifestUrl;
            _packagePathUrl = packageUrl;
			_useProxy = useProxy;
			_proxy = proxy;
		}

		public Dictionary<string, bool> AreUpdatesAvailable(Version localVersion, out Dictionary<string, Version> newVersions)
		{
			var updates = new Dictionary<string, bool>();
			newVersions = new Dictionary<string, Version>();
            using (var client = new WebClient())
            {
                Stream stream;
                try
                {
                    stream = client.OpenRead(_manifestPathUrl);
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
                            case 'F': // skip the manifest contents
                            case 'D':
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
            }

            return updates;
		}

		public void DownloadUpdate(string saveFilePath)
		{
			if (DownloadsStarted != null)
				DownloadsStarted(this, new DownloadEventArgs { FileCount = 1 });

            var thread = new Thread(() =>
            {
                var downloadpath = _packagePathUrl;
                try
                {
                    using (var client = new WebClient())
                    {
                        try
                        {
                            client.DownloadFile(new Uri(downloadpath), saveFilePath);
                        }
                        catch (WebException)
                        {
                            if (!_useProxy)
                                throw;

                            using (var proxyclient = new WebClient {Proxy = _proxy}) // reset internal stuff
                            {
                                proxyclient.DownloadFile(new Uri(downloadpath), saveFilePath); // first try failed. maybe a proxy is in place? try with the proxy set
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Logger.Log("Failed to download file! [file=" + downloadpath + ", savepath=" + saveFilePath + ']' + Environment.NewLine + e);
                }
            });
            thread.Start();
            thread.Join();
            if (DownloadComplete != null)
                DownloadComplete(this, new EventArgs());
		}
	}
}
