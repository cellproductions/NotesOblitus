using System.Windows.Forms;

namespace NotesOblitus
{
	public partial class ProgressWindow : Form
	{
		public string InitialStatus { get; set; }
		public string ProgressStatus { get; set; }
		private readonly ProgressWindowManager _manager;

		public ProgressWindow()
		{
			InitializeComponent();

			_manager = new ProgressWindowManager(this)
			{
				Status = lProgress,
				Progress = pbProgress
			};
			lProgress.Text = InitialStatus;
		}

		public void StartProgress(int maximum)
		{
			_manager.StartProgress(maximum);
		}

		public void IncrementProgress()
		{
			_manager.IncrementProgress();
		}
	}
}
