using System.Drawing;
using System.Windows.Forms;

namespace NotesOblitus
{
	public partial class ReplaceNotesDialog : Form
	{
		public string NoteStart { get { return tbNoteStart.Text; } }
		public string NoteEnd { get { return tbNoteEnd.Text; } }

		public ReplaceNotesDialog()
		{
			InitializeComponent();
			Icon = SystemIcons.Question;
		}
	}
}
