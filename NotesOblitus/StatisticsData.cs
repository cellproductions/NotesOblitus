using System.Collections.Generic;

namespace NotesOblitus
{
	public class StatisticsData
	{
		public long TotalNoteCount { get; set; }
		public float TimeElapsed { get; set; }
		public List<FileStatistic> FileStatistics { get; set; }
		public List<DirectoryStatistic> DirectoryStatistics { get; set; }
		public Dictionary<string, TagStatistic> TagStatistics { get; set; }

		public StatisticsData()
		{
			FileStatistics = new List<FileStatistic>();
			DirectoryStatistics = new List<DirectoryStatistic>();
			TagStatistics = new Dictionary<string, TagStatistic>();
		}

		public void Clear()
		{
			FileStatistics.Clear();
			DirectoryStatistics.Clear();
			TagStatistics.Clear();
		}
	}
}
