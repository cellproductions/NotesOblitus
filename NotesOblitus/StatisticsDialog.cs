using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using NotesOblitus.Exporters;

namespace NotesOblitus
{
	public partial class StatisticsDialog : Form
	{
		public StatisticsData Statistics { get; set; }
		private StatisticsDialogManager _manager = new StatisticsDialogManager();

		public StatisticsDialog()
		{
			InitializeComponent();
			Shown += (sender, args) => SetupStatistics();
		}

		private void SetupStatistics()
		{
			Statistics.FileStatistics.Sort(FileStatistic.LineCompare);
			Statistics.DirectoryStatistics.Sort(DirectoryStatistic.FileCompare);

			// notes
			lNotesNoteCount.Text = Statistics.TotalNoteCount.ToString();
			lNotesScanTime.Text = Statistics.TimeElapsed.ToString(CultureInfo.InvariantCulture) + @" seconds";

			// directories
			lDirsDirCount.Text = Statistics.DirectoryStatistics.Count.ToString();
			lDirsAvgFile.Text = ((float)Statistics.FileStatistics.Count / Statistics.DirectoryStatistics.Count).ToString(CultureInfo.InvariantCulture);
			lDirsAvgNote.Text = ((float)Statistics.TotalNoteCount / Statistics.DirectoryStatistics.Count).ToString(CultureInfo.InvariantCulture);
			foreach (var dirstat in Statistics.DirectoryStatistics)
			{
				dgDirsView.Rows.Add(
					dirstat.DirectoryName,
					dirstat.FileCount,
					dirstat.LineCount,
					dirstat.NoteCount,
					dirstat.EmptyLineCount
				);
				dgDirsView.Rows[dgDirsView.Rows.Count - 1].Cells[0].ToolTipText = dirstat.DirectoryName;
			}

			// files
			lFilesFileCount.Text = Statistics.FileStatistics.Count.ToString();
			lFilesAvgNote.Text = ((float)Statistics.TotalNoteCount / Statistics.FileStatistics.Count).ToString(CultureInfo.InvariantCulture);

			long totallines = 0;
			long totalchars = 0;
			long totalempty = 0;
			foreach (var filestat in Statistics.FileStatistics)
			{
				dgFilesView.Rows.Add(
                    filestat.FileName,
                    filestat.LineCount,
                    filestat.CharCount,
                    filestat.NoteCount,
					filestat.EmptyLineCount
                );
				dgFilesView.Rows[dgFilesView.Rows.Count - 1].Cells[0].ToolTipText = filestat.FileName;
				totallines += filestat.LineCount;
				totalchars += filestat.CharCount;
				totalempty += filestat.EmptyLineCount;
			}
			lFilesLineCount.Text = totallines.ToString();
			lFilesCharCount.Text = totalchars.ToString();
			lFilesEmptyCount.Text = totalempty.ToString();
			lFilesAvgEmptyCount.Text = ((float)totalempty / Statistics.FileStatistics.Count).ToString(CultureInfo.InvariantCulture);

			// tags
			lTagsTagCount.Text = Statistics.TagStatistics.Count.ToString();
			foreach (var tagstat in Statistics.TagStatistics)
			{
				dgTagsView.Rows.Add(
                    tagstat.Value.TagName,
                    tagstat.Value.TagCount
                );
			}
		}

		private void miExportXml_Click(object sender, EventArgs e)
		{
			var dialog = new SaveFileDialog
			{
				CheckPathExists = true,
				AddExtension = true,
				OverwritePrompt = true,
				DefaultExt = ".xml",
				Filter = @"XML files (*.xml)|",
				Title = @"Export as XML"
			};

			var result = dialog.ShowDialog(this);
			if (result != DialogResult.OK)
				return;

			_manager.ExportStatistics(dialog.FileName, ConvertStatistics(), new XmlObjectExporter());
		}

		private void miExportJson_Click(object sender, EventArgs e)
		{
			var dialog = new SaveFileDialog
			{
				CheckPathExists = true,
				AddExtension = true,
				OverwritePrompt = true,
				DefaultExt = ".json",
				Filter = @"JSON files (*.json)|",
				Title = @"Export as JSON"
			};

			var result = dialog.ShowDialog(this);
			if (result != DialogResult.OK)
				return;

			_manager.ExportStatistics(dialog.FileName, ConvertStatistics(), new JsonObjectExporter());
		}

		private StatisticsDialogManager.Statistics ConvertStatistics()
		{
			var directories = (from DataGridViewRow row in dgDirsView.Rows
							   select new StatisticsDialogManager.Statistics.DirectorySection.DirectoryRow
							   {
								   DirectoryName = row.Cells[0].Value.ToString(),
								   FileCount = row.Cells[1].Value.ToString(),
								   LineCount = row.Cells[2].Value.ToString(),
								   NoteCount = row.Cells[3].Value.ToString(),
								   EmptyLineCount = row.Cells[4].Value.ToString()
							   });
			var files = (from DataGridViewRow row in dgFilesView.Rows
						 select new StatisticsDialogManager.Statistics.FileSection.FileRow
						 {
							 FileName = row.Cells[0].Value.ToString(),
							 LineCount = row.Cells[1].Value.ToString(),
							 CharacterCount = row.Cells[2].Value.ToString(),
							 NoteCount = row.Cells[3].Value.ToString(),
							 EmptyLineCount = row.Cells[4].Value.ToString()
						 });
			var tags = (from DataGridViewRow row in dgTagsView.Rows
						select new StatisticsDialogManager.Statistics.TagSection.TagRow
						{
							Name = row.Cells[0].Value.ToString(),
							NoteCount = row.Cells[1].Value.ToString()
						});

			return new StatisticsDialogManager.Statistics
			{
				TimeStamp = DateTime.Now.ToString(CultureInfo.InvariantCulture),
				Note = new StatisticsDialogManager.Statistics.NoteSection
				{
					Total = lNotesNoteCount.Text,
					ScanTime = lNotesScanTime.Text
				},
				Directory = new StatisticsDialogManager.Statistics.DirectorySection
				{
					TotalDirectoryCount = lDirsDirCount.Text,
					TotalFileAverage = lDirsAvgFile.Text,
					TotalNoteAverage = lDirsAvgNote.Text,
					Directories = directories.ToArray()
				},
				File = new StatisticsDialogManager.Statistics.FileSection
				{
					TotalFileCount = lFilesFileCount.Text,
					TotalNoteAverage = lFilesAvgNote.Text,
					TotalLineCount = lFilesLineCount.Text,
					TotalCharacterCount = lFilesCharCount.Text,
					TotalEmptyLineCount = lFilesEmptyCount.Text,
					TotalEmptyLineAverage = lFilesAvgEmptyCount.Text,
					Files = files.ToArray()
				},
				Tag = new StatisticsDialogManager.Statistics.TagSection
				{
					TotalTagCount = lTagsTagCount.Text,
					Tags = tags.ToArray()
				}
			};
		}
	}
}
