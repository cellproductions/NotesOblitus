using NotesOblitus.Exporters;

namespace NotesOblitus
{
	class StatisticsDialogManager
	{
		public class Statistics
	    {
		    public class NoteSection
		    {
				public string Total { get; set; }
				public string ScanTime { get; set; }

		    }

		    public class DirectorySection
		    {
			    public class DirectoryRow
			    {
					public string DirectoryName { get; set; }
					public string FileCount { get; set; }
					public string LineCount { get; set; }
					public string NoteCount { get; set; }
					public string EmptyLineCount { get; set; }
			    }

				public string TotalDirectoryCount { get; set; }
				public string TotalFileAverage { get; set; }
				public string TotalNoteAverage { get; set; }
				public DirectoryRow[] Directories { get; set; }
		    }

		    public class FileSection
		    {
			    public class FileRow
			    {
					public string FileName { get; set; }
					public string LineCount { get; set; }
					public string CharacterCount { get; set; }
					public string NoteCount { get; set; }
					public string EmptyLineCount { get; set; }
			    }

				public string TotalFileCount { get; set; }
				public string TotalNoteAverage { get; set; }
				public string TotalLineCount { get; set; }
				public string TotalCharacterCount { get; set; }
				public string TotalEmptyLineCount { get; set; }
				public string TotalEmptyLineAverage { get; set; }
				public FileRow[] Files { get; set; }
		    }

		    public class TagSection
		    {
			    public class TagRow
			    {
					public string Name { get; set; }
					public string NoteCount { get; set; }
			    }

				public string TotalTagCount { get; set; }
				public TagRow[] Tags { get; set; }
		    }

			public string TimeStamp { get; set; }
			public NoteSection Note { get; set; }
			public DirectorySection Directory { get; set; }
			public FileSection File { get; set; }
			public TagSection Tag { get; set; }
	    }

		public void ExportStatistics(string filePath, Statistics statistics, IObjectExporter exporter)
		{
			exporter.ExportObject(filePath, statistics);
		}
	}
}
