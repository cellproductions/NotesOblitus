using System.Windows.Forms;

namespace NotesOblitus
{
	class ProgressWindowManager
	{
		public Label Status { get; set; }
		public ProgressBar Progress { get; set; }

		public void StartProgress(int maximum)
		{
			Progress.Maximum = maximum;
			Status.Text = @"Reading 0/" + Progress.Maximum + @" files...";
			Status.Refresh();
			Progress.Refresh();
		}

		public void IncrementProgress()
		{
			Progress.PerformStep();
			Status.Text = @"Reading " + Progress.Value + @"/" + Progress.Maximum + @" files...";
			Status.Refresh();
			Progress.Refresh();
		}
	}
}
