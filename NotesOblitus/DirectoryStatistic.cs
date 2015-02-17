namespace NotesOblitus
{
	public class DirectoryStatistic
	{
		public string DirectoryName;
		public long FileCount;
		public long LineCount;
		public long EmptyLineCount;
		public long NoteCount;

		public static int FileCompare(DirectoryStatistic a, DirectoryStatistic b)
		{
			return a.FileCount > b.FileCount ? -1 : (a.FileCount == b.FileCount ? 0 : 1);
		}
	}
}
