using System;
using System.Drawing;
using System.Windows.Forms;
using Global;
using NotesOblitus.Exporters;

namespace NotesOblitus
{
	public partial class NotesOblitusApp : Form
	{
		readonly NotesOblitusManager _manager;

		public NotesOblitusApp(string[] args)
		{
			InitializeComponent();
			niMainNotify.Text = GlobalVars.ApplicationTitle + ' ' + GlobalVars.ApplicationVersion;
			_manager = new NotesOblitusManager(this, entryPath);
			var lastsearchpath = _manager.LoadAndSetupOptions();
			tbInitialPath.Text = lastsearchpath;
		}

		public void UpdateView()
		{
			if (Visible)
				_manager.UpdateCurrentView(_manager.CurrentViewMode == ViewMode.ListView ? (Control)dgListNotes : tvListNotes);
		}

		private void NotesOblitusApp_VisibleChanged(object sender, EventArgs e)
		{
			UpdateView();
		}

		private void NotesOblitusApp_FormClosed(object sender, FormClosedEventArgs e)
		{
			_manager.ExitApplication(true);
			niMainNotify.Dispose();
		}

		private void NotesOblitusApp_Shown(object sender, EventArgs e)
		{
			_manager.CheckForUpdates(false, false, false);
			_manager.ScanAndCollectNotes();
			UpdateView();
		}

		private void miFile_Click(object sender, EventArgs e)
		{
			_manager.UpdateRecentProjects(miFileRecentProjects, _manager.DefaultProject.RecentProjects);
			_manager.UpdateRecentSearches(miFileRecentSearches, _manager.DefaultProject.RecentSearchPaths, tbInitialPath);
			miFileRecentProjects.Invalidate();
			miFileRecentSearches.Invalidate();
		}

		private void miFileOpen_Click(object sender, EventArgs e)
		{
			var lastsearchpath = _manager.OpenProject();
			if (lastsearchpath != null)
				tbInitialPath.Text = lastsearchpath;
			UpdateView();
		}

		private void miFileSave_Click(object sender, EventArgs e)
		{
			_manager.SaveProject();
		}

		private void miFileSaveAs_Click(object sender, EventArgs e)
		{
			_manager.SaveProjectAs();
		}

		private void miFileRead_Click(object sender, EventArgs e)
		{
			var lastsearchpath = _manager.ChooseScanDirectory();
			if (lastsearchpath != null)
				tbInitialPath.Text = lastsearchpath;

			if (_manager.AutoScan) 
				return;
			_manager.ScanAndCollectNotes();
			UpdateView();
		}

		private void miFileRefresh_Click(object sender, EventArgs e)
		{
			_manager.ScanAndCollectNotes();
			UpdateView();
		}

		private void miFileAutoRefresh_Click(object sender, EventArgs e)
		{
			_manager.SetAutoScan(miFileAutoRefresh.Checked);
		}

		private void miExportXml_Click(object sender, EventArgs e)
		{
			var dialog = new SaveFileDialog
			{
				CheckPathExists = true,
				AddExtension = true,
				OverwritePrompt = true,
				DefaultExt = ".xml",
				Filter = @"XML files (*.xml)|",
				Title = @"Export as XML"
			};

			var result = dialog.ShowDialog(this);
			if (result != DialogResult.OK)
				return;

			_manager.ExportProject(dialog.FileName, new XmlObjectExporter());
		}

		private void miExportJson_Click(object sender, EventArgs e)
		{
			var dialog = new SaveFileDialog
			{
				CheckPathExists = true,
				AddExtension = true,
				OverwritePrompt = true,
				DefaultExt = ".json",
				Filter = @"JSON files (*.json)|",
				Title = @"Export as JSON"
			};

			var result = dialog.ShowDialog(this);
			if (result != DialogResult.OK)
				return;

			_manager.ExportProject(dialog.FileName, new JsonObjectExporter());
		}

		private void miFileExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void miViewTable_Click(object sender, EventArgs e)
		{
			htcMainView.SelectedIndex = 0;
			_manager.UpdateCurrentView(dgListNotes);
		}

		private void miViewTree_Click(object sender, EventArgs e)
		{
			htcMainView.SelectedIndex = 1;
			_manager.UpdateCurrentView(tvListNotes);
		}

		private void miViewStatistics_Click(object sender, EventArgs e)
		{
			_manager.ShowStatistics();
		}

		private void miEditPreview_Click(object sender, EventArgs e)
		{
			_manager.OpenPreviewDialog(_manager.CurrentViewMode == ViewMode.ListView ? (Control)dgListNotes : tvListNotes);
		}

		private void miEditEdit_Click(object sender, EventArgs e)
		{
			_manager.RunEditor();
		}

		private void miEditDelete_Click(object sender, EventArgs e)
		{
			_manager.RemoveNoteFromSource(_manager.CurrentViewMode == ViewMode.ListView ? (Control)dgListNotes : tvListNotes);
		}

		private void miEditOptions_Click(object sender, EventArgs e)
		{
			_manager.DisplayOptionsWindow();
		}

		private void miAboutHelp_Click(object sender, EventArgs e)
		{
			_manager.ShowHelpWindow();
		}

		private void miAboutAbout_Click(object sender, EventArgs e)
		{
			_manager.ShowAboutDialog();
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

			if (!_manager.AutoScan)
			{
				_manager.ScanAndCollectNotes();
				UpdateView();
			}

			e.Handled = true;
			e.SuppressKeyPress = true;
		}

		private void tbInitialPath_TextChanged(object sender, EventArgs e)
		{
			_manager.CurrentProject.LastSearchPath = tbInitialPath.Text.Trim();
		}

		private void htcMainView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (htcMainView.SelectedIndex == 0)
			{
				_manager.CurrentViewMode = ViewMode.ListView;
				dgListNotes_SelectionChanged(null, null);
			}
			else
			{
				_manager.CurrentViewMode = ViewMode.TreeView;
				tvListNotes_AfterSelect(null, null);
			}
		}

		private void dgListNotes_SelectionChanged(object sender, EventArgs e)
		{
			if (_manager.CurrentViewMode != ViewMode.ListView)
				return;
			_manager.SelectedNote = dgListNotes.CurrentCell == null ? null : (Note)dgListNotes.CurrentCell.OwningRow.Tag;
		}

		private void dgListNotes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button != MouseButtons.Right)
				return;
			dgListNotes.CurrentCell = dgListNotes.Rows[e.RowIndex].Cells[e.ColumnIndex];
			dgListNotes.Rows[e.RowIndex].Selected = true;
			_manager.SelectedNote = (Note)dgListNotes.Rows[e.RowIndex].Tag;

			var cellloc = dgListNotes.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
			ShowViewMenu(dgListNotes.PointToScreen(new Point(cellloc.X + e.Location.X, cellloc.Y + e.Location.Y)));
		}

		private void dgListNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			_manager.OpenPreviewDialog(dgListNotes);
		}

		private void tvListNotes_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (_manager.CurrentViewMode != ViewMode.TreeView)
				return;
			_manager.SelectedNote = tvListNotes.SelectedNode == null ? null : (Note)tvListNotes.SelectedNode.Tag;
		}

		private void tvListNotes_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Button != MouseButtons.Right)
				return;

			tvListNotes.SelectedNode = e.Node;
			ShowViewMenu(tvListNotes.PointToScreen(e.Location));
		}

		private void tvListNotes_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Node.Tag != null)
				_manager.OpenPreviewDialog(tvListNotes);
		}

		private void msNotifyMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			miNotifyAuto.Checked = miFileAutoRefresh.Checked;
		}

		private void miNotifyAuto_Click(object sender, EventArgs e)
		{
			_manager.SetAutoScan(miNotifyAuto.Checked);
		}

		private void miNotifyAbout_Click(object sender, EventArgs e)
		{
			niMainNotify.ShowBalloonTip(
				5000,
				"About",
				GlobalVars.ApplicationTitle + "\nby Callum Nichols \u24B8 2014\n\nVersion " + GlobalVars.ApplicationVersion,
				new ToolTipIcon()
				);
		}

		private void miNotifyExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ShowViewMenu(Point location)
		{
			var menu = new ContextMenuStrip();
			var previewItem = new ToolStripMenuItem("Preview");
			var editItem = new ToolStripMenuItem("Edit");
			var deleteItem = new ToolStripMenuItem("Delete");

			previewItem.Click += miEditPreview_Click;
			editItem.Click += miEditEdit_Click;
			deleteItem.Click += miEditDelete_Click;

			menu.Items.Add(previewItem);
			menu.Items.Add(editItem);
			menu.Items.Add(deleteItem);

			menu.Show(location);
		}
	}
}
