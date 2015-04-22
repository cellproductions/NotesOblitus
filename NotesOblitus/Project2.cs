using System.Collections.Generic;
using System.IO;
using NotesOblitus.Controls;

namespace NotesOblitus
{
	public class Project2
	{
		public ProjectSettings Settings { get; internal set; }
		public ProjectPage Page { get; internal set; }
		public FileSystemWatcher PathWatcher { get; internal set; }
		public bool IsProjectFile { get; set; }
		public List<Note> Notes { get; internal set; }
		public HashSet<string> Tags { get; internal set; }
		public StatisticsData AllStatisticsData { get; internal set; }
		public object AutoLock { get; internal set; } /** TODO(threading) not sure if this is the right way to go about this */

		public Project2(ProjectSettings settings, ProjectPage view)
		{
			Settings = settings;
			Page = view;
			PathWatcher = new FileSystemWatcher();
			Notes = new List<Note>();
			Tags = new HashSet<string>();
			AllStatisticsData = new StatisticsData();
			AutoLock = new object();
		}
	}
}
