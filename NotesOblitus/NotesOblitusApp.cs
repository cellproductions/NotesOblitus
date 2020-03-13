using System;
using System.Drawing;
using System.Windows.Forms;
using CellSharpControls;
using Global;
using NotesOblitus.Controls;
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
			_manager = new NotesOblitusManager(this, args);
			_manager.LoadAndSetupOptions(tcProjects);
			//var lastsearchpath = _manager.LoadAndSetupOptions();
			//tbInitialPath.Text = lastsearchpath;
		}

		public void UpdateView()
		{
			if (Visible)
				_manager.UpdateCurrentView(tcProjects.SelectedTab.Tag as Project2);
			//_manager.UpdateCurrentView(_manager.CurrentViewMode == ViewMode.ListView ? (Control)dgListNotes : tvListNotes);
		}

		private void NotesOblitusApp_VisibleChanged(object sender, EventArgs e)
		{
			UpdateView();
		}

		private void NotesOblitusApp_FormClosed(object sender, FormClosedEventArgs e)
		{
			niMainNotify.Dispose();
			_manager.ExitApplication(true);
		}

		private void NotesOblitusApp_Shown(object sender, EventArgs e)
		{
			_manager.CheckForUpdates(false, false, false);
			_manager.ScanAndCollectNotes(tcProjects.SelectedTab.Tag as Project2);
			UpdateView();
		}

		private void miFile_Click(object sender, EventArgs e)
		{
			_manager.UpdateRecentProjects(miFileRecentProjects, _manager.Settings.RecentProjects);
			_manager.UpdateRecentSearches(miFileRecentSearches, _manager.Settings.RecentSearchPaths, tcProjects.SelectedTab as ProjectPage);
			miFileRecentProjects.Invalidate();
			miFileRecentSearches.Invalidate();
		}

		private void miFileOpen_Click(object sender, EventArgs e)
		{
			_manager.OpenExistingProject(tcProjects);
			UpdateView();
		}

		private void miFileAutoRefresh_Click(object sender, EventArgs e)
		{
			//_manager.SetAutoScan(miFileAutoRefresh.Checked);
		}

		private void miFileExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void miEditPreview_Click(object sender, EventArgs e)
		{
			//_manager.OpenPreviewDialog(tcProjects.SelectedTab.Tag as Project2);
		}

		private void miEditEdit_Click(object sender, EventArgs e)
		{
			//_manager.RunEditor(tcProjects.SelectedTab.Tag as Project2);
		}

		private void miEditDelete_Click(object sender, EventArgs e)
		{
			//_manager.RemoveNoteFromSource(_manager.CurrentProject2);
		}

		private void miAboutHelp_Click(object sender, EventArgs e)
		{
			_manager.ShowHelpWindow();
		}

		private void miAboutAbout_Click(object sender, EventArgs e)
		{
			_manager.ShowAboutDialog();
		}

		private void tcProjects_TabMouseDown(object sender, TabMouseEventArgs e)
		{
			//_manager.CurrentProject2 = e.Page.Tag as Project2;
		}

#if false
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
			if (e.Button != MouseButtons.Left)
				return;
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
			if (e.Button != MouseButtons.Left)
				return;
			if (e.Node.Tag != null)
				_manager.OpenPreviewDialog(tvListNotes);
		}
#endif

		private void msNotifyMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//miNotifyAuto.Checked = miFileAutoRefresh.Checked;
		}

		private void miNotifyAuto_Click(object sender, EventArgs e)
		{
			//_manager.SetAutoScan(miNotifyAuto.Checked);
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

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (tcProjects.SelectedTab != null)
				_manager.SaveProject(tcProjects.SelectedTab.Tag as Project2);
		}

		private void miProjectSaveAs_Click(object sender, EventArgs e)
		{
			if (tcProjects.SelectedTab != null) 
				_manager.SaveProjectAs(tcProjects.SelectedTab.Tag as Project2);
		}

		private void miProjectExportXml_Click(object sender, EventArgs e)
		{
			if (tcProjects.SelectedTab == null)
				return;

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

			_manager.ExportProject(tcProjects.SelectedTab.Tag as Project2, dialog.FileName, new XmlObjectExporter());
		}

		private void miProjectExportJson_Click(object sender, EventArgs e)
		{
			if (tcProjects.SelectedTab == null)
				return;

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

			_manager.ExportProject(tcProjects.SelectedTab.Tag as Project2, dialog.FileName, new JsonObjectExporter());
		}

		private void miProjectScanDir_Click(object sender, EventArgs e)
		{
			if (tcProjects.SelectedTab == null)
				return;

			var lastsearchpath = _manager.ChooseScanDirectory(tcProjects.SelectedTab.Tag as Project2);
			if (lastsearchpath != null)
				((ProjectPage)tcProjects.SelectedTab).SearchPath = lastsearchpath;
			((ProjectPage)tcProjects.SelectedTab).ActivateSearchPath();
			_manager.ScanAndCollectNotes(tcProjects.SelectedTab.Tag as Project2);
			UpdateView();
		}

		private void miProjectRefresh_Click(object sender, EventArgs e)
		{
			if (tcProjects.SelectedTab == null)
				return;

			_manager.ScanAndCollectNotes(tcProjects.SelectedTab.Tag as Project2);
			UpdateView();
		}

		private void miProjectDisplayTable_Click(object sender, EventArgs e)
		{
			if (tcProjects.SelectedTab == null)
				return;

			((ProjectPage)tcProjects.SelectedTab).CurrentMode = ViewMode.ListView;
			_manager.UpdateCurrentView(tcProjects.SelectedTab.Tag as Project2);
		}

		private void miProjectDisplayTree_Click(object sender, EventArgs e)
		{
			if (tcProjects.SelectedTab == null)
				return;

			((ProjectPage)tcProjects.SelectedTab).CurrentMode = ViewMode.TreeView;
			_manager.UpdateCurrentView(tcProjects.SelectedTab.Tag as Project2);
		}

		private void miProjectOptions_Click(object sender, EventArgs e)
		{
			if (tcProjects.SelectedTab != null) 
				_manager.DisplayOptionsWindow(tcProjects.SelectedTab.Tag as Project2);
		}

		private void miProjectStatistics_Click(object sender, EventArgs e)
		{
			if (tcProjects.SelectedTab != null) 
				_manager.ShowStatistics(tcProjects.SelectedTab.Tag as Project2);
		}
	}
}
