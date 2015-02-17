using System.Windows.Forms;

namespace NotesOblitus
{
	public partial class HelpWindow : Form
	{
		public string IndexPath { get; set; }

		public HelpWindow()
		{
			InitializeComponent();
			Shown += (sender, args) => { if (!string.IsNullOrEmpty(IndexPath)) wbDisplay.Navigate(IndexPath); };
		}
	}
}
