namespace NotesOblitus
{
	public class FileStatistic
	{
		public string FileName;
		public long CharCount;
		public long LineCount;
		public long EmptyLineCount;
		public long NoteCount;

		public static int LineCompare(FileStatistic a, FileStatistic b)
		{
			return a.LineCount > b.LineCount ? -1 : (a.LineCount == b.LineCount ? 0 : 1);
		}
	}
}
