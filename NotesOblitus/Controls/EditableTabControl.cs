using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NotesOblitus.Controls
{
	[Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
	public partial class EditableTabControl : TabControl
	{
		public delegate void TabEvent(object sender, TabEventArgs e);
		public delegate void TabMouseEvent(object sender, TabMouseEventArgs e);

		private TabPage _heldTab;

		[Category("Behavior"), Description("Called after a tab page was removed.")]
		public event TabEvent TabRemoved;
		[Category("Behavior"), Description("Called after a tab page was added.")]
		public event TabEvent TabAdded;
		[Category("Mouse"), Description("Called after a mouse button is pressed over a tab.")]
		public event TabMouseEvent TabMouseDown;
		[Category("Mouse"), Description("Called after a mouse button is released over a tab.")]
		public event TabMouseEvent TabMouseUp;

		public EditableTabControl()
		{
			InitializeComponent();

			MouseDown += OnMouseDown;
			MouseUp += OnMouseUp;
			MouseMove += OnMouseMove;
		}

		private TabPage TabAtPoint(Point point)
		{
			for (var i = 0; i < TabPages.Count; ++i)
				if (GetTabRect(i).Contains(point))
					return TabPages[i];
			return null;
		}

		private void OnMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Middle)
			{
				var tab = TabAtPoint(e.Location);
				if (tab == null) 
					return;
				TabPages.Remove(tab);
				if (TabRemoved != null)
					TabRemoved(this, new TabEventArgs { Page = tab });
				return;
			}
			_heldTab = TabAtPoint(e.Location);
			if (_heldTab != null && TabMouseDown != null)
				TabMouseDown(this, new TabMouseEventArgs { Button = e.Button, Page = _heldTab });
		}

		private void OnMouseUp(object sender, MouseEventArgs e)
		{
			_heldTab = TabAtPoint(e.Location);
			if (_heldTab != null && TabMouseUp != null)
				TabMouseUp(this, new TabMouseEventArgs { Button = e.Button, Page = _heldTab });
		}

		private void OnMouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left || _heldTab == null)
				return;

			var tab = TabAtPoint(e.Location);
			if (tab == null || tab == _heldTab)
				return;

			SwapTabs(_heldTab, tab);
			SelectedTab = _heldTab;
		}

		private void SwapTabs(TabPage a, TabPage b)
		{
			var i = TabPages.IndexOf(a);
			var j = TabPages.IndexOf(b);
			TabPages[i] = b;
			TabPages[j] = a;
		}

		public void ClearTabs()
		{
			while (TabPages.Count > 0)
			{
				var index = TabPages.Count - 1;
				var page = TabPages[index];
				TabPages.RemoveAt(index);
				if (TabRemoved != null)
					TabRemoved(this, new TabEventArgs { Page = page });
			}
		}

		public void AddTab(TabPage page)
		{
			if (page == null)
				throw new ArgumentNullException("page");
			TabPages.Add(page);
			if (TabAdded != null)
				TabAdded(this, new TabEventArgs{ Page = page });
		}

		public void InsertTab(TabPage page, int index)
		{
			if (page == null)
				throw new ArgumentNullException("page");
			if (index < 0 || index > TabPages.Count)
				throw new IndexOutOfRangeException("Index out of range! [index=" + index + ", range=" + TabPages.Count + ']');
			TabPages.Insert(index, page);
			if (TabAdded != null)
				TabAdded(this, new TabEventArgs { Page = page });
		}

		public void AddTabRange(TabPage[] pages)
		{
			if (pages == null)
				throw new ArgumentNullException("pages");
			TabPages.AddRange(pages.ToArray());
			if (TabAdded == null) 
				return;
			foreach (var page in pages)
				TabAdded(this, new TabEventArgs { Page = page });
		}

		public void RemoveTab(TabPage page)
		{
			if (page == null)
				throw new ArgumentNullException("page");
			TabPages.Remove(page);
			if (TabRemoved != null)
				TabRemoved(this, new TabEventArgs { Page = page });
		}

		public void RemoveTabAt(int index)
		{
			if (index < 0 || index >= TabPages.Count)
				throw new IndexOutOfRangeException("Index out of range! [index=" + index + ", range=" + TabPages.Count + ']');
			var page = TabPages[index];
			TabPages.RemoveAt(index);
			if (TabRemoved != null)
				TabRemoved(this, new TabEventArgs { Page = page });
		}

		public void RemoveTabByKey(string key)
		{
			if (key == null)
				throw new ArgumentNullException("key");
			var page = TabPages[key];
			TabPages.RemoveByKey(key);
			if (TabRemoved != null)
				TabRemoved(this, new TabEventArgs { Page = page });
		}
	}

	public class TabEventArgs : EventArgs
	{
		public TabPage Page { get; set; }
	}

	public class TabMouseEventArgs : TabEventArgs
	{
		public MouseButtons Button { get; set; }
	}
}
