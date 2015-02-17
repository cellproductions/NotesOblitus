using System.Windows.Forms;

namespace NotesOblitus
{
	public partial class AboutDialog : Form
	{
		public string Message { get; set; }
		public string LicensePath { get; set; }
		readonly AboutDialogManager _manager = new AboutDialogManager();

		public AboutDialog()
		{
			InitializeComponent();
			Shown += (sender, args) => { lMessage.Text = Message ?? ""; _manager.LoadLicense(LicensePath, rtbLicense); };
		}
	}
}
