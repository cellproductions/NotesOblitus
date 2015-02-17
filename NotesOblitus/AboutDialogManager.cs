using System.IO;
using System.Windows.Forms;

namespace NotesOblitus
{
	class AboutDialogManager
	{
		public void LoadLicense(string licensePath, RichTextBox licenseBox)
		{
			licenseBox.Text = !File.Exists(licensePath) ? "License missing." : File.ReadAllText(licensePath);
		}
	}
}
