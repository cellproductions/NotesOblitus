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
					SearchPathChanged(tbInitialPath, new SearchPathEventArgs 
					{ Path = tbInitialPath.Text });
			}
		}

		public event SearchPathChangedEvent SearchPathChanged;
		public event SearchPathActivatedEvent SearchPathActivated;

		public ProjectPage()
		{
			InitializeComponent();

			tbInitialPath.KeyUp += (sender, args) =>
			{
				if (SearchPathActivated != null)
					SearchPathActivated(tbInitialPath, new SearchPathEventArgs 
					{ Path = tbInitialPath.Text });
			};
		}
	}
}
