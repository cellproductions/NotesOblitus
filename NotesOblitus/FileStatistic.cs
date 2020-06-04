namespace NotesOblitus
{
	public class FileStatistic
	{
		public string FileName;
		public long CharCount;
		public long LineCount;
		public long EmptyLineCount;
		public long NoteCount;

        public FileStatistic(string fileName)
        {
            FileName = fileName;
        }

		public static int LineCompare(FileStatistic a, FileStatistic b)
		{
			return a.LineCount > b.LineCount ? -1 : (a.LineCount == b.LineCount ? 0 : 1);
		}
	}
}
