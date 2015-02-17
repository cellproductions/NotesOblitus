using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NotesOblitus.Controls
{
	[Designer("System.Windows.Forms.Design.TextBoxDesigner, System.Design", typeof(IDesigner))]
	public class TextBoxPlaceHolder : TextBox
	{
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

		[
			Category("Appearance"),
			Description("Placeholder text appears while an empty text box does not have focus.")
		]
		public string PlaceHolder { get; set; }


		public TextBoxPlaceHolder()
		{
			PlaceHolder = "";
		}

		protected override void OnHandleCreated(EventArgs e)
		{
			SendPlaceHolderMessage();

			base.OnHandleCreated(e);
		}

		protected override void OnLeave(EventArgs e)
		{
			SendPlaceHolderMessage();

			base.OnLeave(e);
		}

		private void SendPlaceHolderMessage()
		{
			if (string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(PlaceHolder))
				SendMessage(Handle, 0x1501, 0, PlaceHolder); // 0x1501 = EM_SETCUEBANNER
		}
	}
}
