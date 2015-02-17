using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace NotesOblitus.Controls
{
	[Designer("System.Windows.Forms.Design.TabControlDesigner, System.Design", typeof(IDesigner))]
	public class HiddenTabControl : TabControl
	{
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 0x1328 && !DesignMode) // 0x1328 = TCM_ADJUSTRECT
			{
				m.Result = (IntPtr) 1;
				return;
			}

			base.WndProc(ref m);
		}
	}
}
