using System.Windows.Forms;

namespace NotesOblitus
{
	public partial class ProgressWindow : Form
	{
		private readonly ProgressWindowManager _manager;

		public ProgressWindow()
		{
			InitializeComponent();

			_manager = new ProgressWindowManager
			{
				Status = lProgress,
				Progress = pbProgress
			};
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
