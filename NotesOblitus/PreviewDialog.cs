using System;
using System.Windows.Forms;

namespace NotesOblitus
{
	public delegate void ButtonClickedEvent(object sender, EventArgs args);

    public partial class PreviewDialog : Form
    {
        [System.Runtime.InteropServices.DllImport("User32.dll")]
        public extern static int GetScrollPos(IntPtr hWnd, int nBar);

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        public extern static int SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

		public int LineCount { get; set; }
		public Note NotePreview { get; set; }
	    readonly PreviewDialogManager _manager;

	    public event ButtonClickedEvent OpenClicked;
	    public event ButtonClickedEvent RemoveClicked;

        public PreviewDialog()
        {
            InitializeComponent();
	        _manager = new PreviewDialogManager();
        }

		public new DialogResult ShowDialog(IWin32Window parent)
        {
			Text = @"Preview - " + NotePreview.FileName + @" (line " + NotePreview.Line + ')';

			string selectedtext;
			int startline;

			_manager.GetPreviewTextAndLine(NotePreview, LineCount, out selectedtext, out startline);
			
			rtbPreview.Text = selectedtext;

			_manager.SetLineNumbers(rtbPreview, rtbLines, startline);
			_manager.ReadSyntaxFile(NotesOblitusManager.SyntaxFileName);
			_manager.ApplySyntaxColouring(rtbPreview, NotePreview);

            return base.ShowDialog(parent);
        }

		private void bOpen_Click(object sender, EventArgs e)
		{
			if (OpenClicked != null)
				OpenClicked(bOpen, new EventArgs());
		}

		private void bRemove_Click(object sender, EventArgs e)
		{
			if (RemoveClicked != null)
				RemoveClicked(bRemove, new EventArgs());
		}

		private void rtbPreview_VScroll(object sender, EventArgs e) /** TODO(incomplete) may also have to override WndProc for smoother scroll */
		{
			var npos = GetScrollPos(rtbPreview.Handle, 1); // 1 = SB_VERT
			npos <<= 16;
			var wparam = 4 | npos; // 4 = SB_THUMBPOSITION
			SendMessage(rtbLines.Handle, 0x0115, new IntPtr(wparam), new IntPtr(0)); // 0x0115 = WM_VSCROLL
		}
    }
}
