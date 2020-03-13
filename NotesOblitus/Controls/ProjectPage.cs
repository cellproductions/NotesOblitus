using System;
using System.Drawing;
using System.Windows.Forms;

namespace NotesOblitus.Controls
{
	public partial class ProjectPage : TabPage
	{
		public class SearchPathEventArgs
		{
			public string Path { get; set; }
		}

		public class NoteClickedEventArgs
		{
			public MouseButtons Button;
			public Point Location;
		}

		public delegate void SearchPathChangedEvent(object sender, SearchPathEventArgs e);
		public delegate void SearchPathActivatedEvent(object sender, SearchPathEventArgs e);
		public delegate void NoteClickedEvent(object sender, NoteClickedEventArgs e);

		//public Project2 ProjectOwner { get; internal set; }
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
			get { return htcMainView.SelectedIndex == 0 ? ViewMode.ListView : ViewMode.TreeView; }
			set { htcMainView.SelectedIndex = value == ViewMode.ListView ? 0 : 1; }
		}
		public Note CurrentNote { get; internal set; }

		public event SearchPathChangedEvent SearchPathChanged;
		public event SearchPathActivatedEvent SearchPathActivated;
		public event NoteClickedEvent NoteClicked;
		public event NoteClickedEvent NoteDoubleClicked;

		public ProjectPage()
		{
			InitializeComponent();
			CurrentMode = ViewMode.ListView;
			CurrentView = dgListNotes;
		}

		private void tbInitialPath_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
				return;

			e.Handled = true;
			e.SuppressKeyPress = true;
		}

		private void tbInitialPath_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
				return;

			if (SearchPathActivated != null)
				SearchPathActivated(tbInitialPath, new SearchPathEventArgs { Path = tbInitialPath.Text });

			e.Handled = true;
			e.SuppressKeyPress = true;
		}

		private void htcMainView_SelectedIndexChanged(object sender, EventArgs e)
		{
			CurrentView = htcMainView.SelectedIndex == 0 ? (Control)dgListNotes : tvListNotes;
		}

		private void dgListNotes_SelectionChanged(object sender, EventArgs e)
		{
			if (CurrentMode != ViewMode.ListView)
				return;
			CurrentNote = dgListNotes.CurrentCell == null ? null : (Note)dgListNotes.CurrentCell.OwningRow.Tag;
		}

		private void dgListNotes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button != MouseButtons.Right)
				return;
			dgListNotes.CurrentCell = dgListNotes.Rows[e.RowIndex].Cells[e.ColumnIndex];
			dgListNotes.Rows[e.RowIndex].Selected = true;
			CurrentNote = (Note)dgListNotes.Rows[e.RowIndex].Tag;

			if (NoteClicked == null)
				return;

			var cellloc = dgListNotes.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
			NoteClicked(dgListNotes, new NoteClickedEventArgs
			{
				Button = e.Button,
				Location = dgListNotes.PointToScreen(new Point(cellloc.X + e.Location.X, cellloc.Y + e.Location.Y))
			});
		}

		private void dgListNotes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;
			if (NoteDoubleClicked == null)
				return;

			var cellloc = dgListNotes.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
			NoteDoubleClicked(dgListNotes, new NoteClickedEventArgs
			{
				Button = e.Button,
				Location = dgListNotes.PointToScreen(new Point(cellloc.X + e.Location.X, cellloc.Y + e.Location.Y))
			});
		}

		private void tvListNotes_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (CurrentMode != ViewMode.TreeView)
				return;
			CurrentNote = tvListNotes.SelectedNode == null ? null : (Note)tvListNotes.SelectedNode.Tag;
		}

		private void tvListNotes_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Button != MouseButtons.Right)
				return;

			tvListNotes.SelectedNode = e.Node;
			if (NoteClicked != null)
				NoteClicked(tvListNotes, new NoteClickedEventArgs
				{
					Button = e.Button, 
					Location = tvListNotes.PointToScreen(e.Location)
				});
		}

		private void tvListNotes_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
				return;
			if (e.Node.Tag != null && NoteDoubleClicked != null)
				NoteDoubleClicked(tvListNotes, new NoteClickedEventArgs
				{
					Button = e.Button, 
					Location = tvListNotes.PointToScreen(e.Location)
				});
		}

		public void ActivateSearchPath()
		{
			if (SearchPathActivated != null)
				SearchPathActivated(this, new SearchPathEventArgs { Path = SearchPath });
		}
	}
}
