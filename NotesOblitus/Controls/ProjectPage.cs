using System.Windows.Forms;

namespace NotesOblitus.Controls
{
	public partial class ProjectPage : UserControl
	{
		public class SearchPathEventArgs
		{
			public string Path { get; set; }
		}

		public delegate void SearchPathChangedEvent(object sender, SearchPathEventArgs e);
		public delegate void SearchPathActivatedEvent(object sender, SearchPathEventArgs e);

		public Project2 ProjectOwner { get; internal set; }
		public string SearchPath
		{
			get { return tbInitialPath.Text;  }
			set
			{
				tbInitialPath.Text = value;
				if (SearchPathChanged != null)
					SearchPathChanged(tbInitialPath, new SearchPathEventArgs { Path = tbInitialPath.Text });
			}
		}
		public Control CurrentView { get; internal set; }
		public ViewMode CurrentMode
		{
			get { return CurrentView == dgListNotes ? ViewMode.ListView : ViewMode.TreeView; }
			set { htcMainView.SelectedIndex = value == ViewMode.ListView ? 0 : 1; }
		}

		public event SearchPathChangedEvent SearchPathChanged;
		public event SearchPathActivatedEvent SearchPathActivated;

		public ProjectPage()
		{
			InitializeComponent();

			tbInitialPath.KeyDown += (sender, args) =>
			{
				if (args.KeyCode != Keys.Enter)
					return;

				args.Handled = true;
				args.SuppressKeyPress = true;
			};

			tbInitialPath.KeyUp += (sender, args) =>
			{
				if (args.KeyCode != Keys.Enter)
					return;

				if (SearchPathActivated != null)
					SearchPathActivated(tbInitialPath, new SearchPathEventArgs { Path = tbInitialPath.Text });

				args.Handled = true;
				args.SuppressKeyPress = true;
			};

			htcMainView.SelectedIndexChanged += (sender, args) =>
			{
				CurrentView = htcMainView.SelectedIndex == 0 ? (Control)dgListNotes : tvListNotes;
			};
		}
	}
}
