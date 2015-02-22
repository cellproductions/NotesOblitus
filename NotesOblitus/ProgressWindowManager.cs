using System.Windows.Forms;

namespace NotesOblitus
{
	class ProgressWindowManager
	{
		public ProgressWindow Owner { get; internal set; }
		public Label Status { get; set; }
		public ProgressBar Progress { get; set; }

		public ProgressWindowManager(ProgressWindow owner)
		{
			Owner = owner;
		}

		public void StartProgress(int maximum)
		{
			Progress.Maximum = maximum;
			//Status.Text = @"Reading 0/" + Progress.Maximum + @" files...";
			UpdateControls();
		}

		public void IncrementProgress()
		{
			Progress.PerformStep();
			UpdateControls();
		}

		private void UpdateControls()
		{
			Status.Text = Owner.ProgressStatus.Replace("%val", Progress.Value.ToString()).Replace("%max", Progress.Maximum.ToString());
			//Status.Text = @"Reading " + Progress.Value + @"/" + Progress.Maximum + @" files...";
			Status.Refresh();
			Progress.Refresh();
		}
	}
}
