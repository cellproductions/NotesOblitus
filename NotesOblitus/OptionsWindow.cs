using System;
using System.Collections;
using System.Collections.Generic;
#if DEBUG
using System.Diagnostics;
#endif
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace NotesOblitus
{
	public partial class OptionsWindow : Form
	{
		public class ReplaceClickedEventArgs : EventArgs
		{
			public string NoteOpen { get; set; }
			public string NoteClose { get; set; }
		}

		public delegate void ReplaceClickedEvent(object sender, ReplaceClickedEventArgs args);

		public event ReplaceClickedEvent ReplaceClicked;
		private readonly OptionsWindowManager _manager;

		public OptionsWindow()
		{
			InitializeComponent();
			_manager = new OptionsWindowManager(this);
		}

		public void InitialiseSettings(ProjectSettings defaultSettings, ProjectSettings projectSettings, List<string> foundTags, bool updateAvailable)
		{
			_manager.RootSearchPath = projectSettings.LastSearchPath;
			_manager.AcceptedTypes = projectSettings.FileTypes;

			// general
			cGeneralDelete.Checked = GetBoolFromOption(defaultSettings, projectSettings, "DeleteFromSource");
			tbGeneralStart.Text = GetStringFromOption(defaultSettings, projectSettings, "NoteOpen");
			tbGeneralEnd.Text = GetStringFromOption(defaultSettings, projectSettings, "NoteClose");
			nGeneralDepth.Value = GetDecimalFromOption(defaultSettings, projectSettings, "SearchDepth", 2);
			nGeneralInterval.Value = GetDecimalFromOption(defaultSettings, projectSettings, "SearchInterval", 10);

			// preview
			tbPreviewEditor.Text = GetStringFromOption(defaultSettings, projectSettings, "Editor");
			tbPreviewArgs.Text = GetStringFromOption(defaultSettings, projectSettings, "EditorArgs");
			nPreviewLineCount.Value = GetDecimalFromOption(defaultSettings, projectSettings, "PreviewLineCount", 20);
			foreach (var macropair in _manager.Macros)
			{
				cbPreviewMacros.Items.Add(new OptionsWindowManager.MacroDisplay
				{
					DisplayText = macropair.Key.PadRight(15) + macropair.Value,
					Macro = macropair.Value
				});
			}

			// filters
			if (ValidOption(projectSettings.FileTypes))
			{
				foreach (var filetype in projectSettings.FileTypes)
					cbFiltersTypes.Items.Add(filetype);
			}
			else if (ValidOption(defaultSettings.FileTypes))
			{
				foreach (var filetype in defaultSettings.FileTypes)
					cbFiltersTypes.Items.Add(filetype);
			}
			if (ValidOption(projectSettings.PathFilter))
				_manager.FilteredPaths.AddRange(projectSettings.PathFilter);
			else if (ValidOption(defaultSettings.PathFilter))
				_manager.FilteredPaths.AddRange(defaultSettings.PathFilter);
			cFiltersFilter.Checked = GetBoolFromOption(defaultSettings, projectSettings, "FilterTags");
			if (ValidOption(projectSettings.TagFilter))
			{
				_manager.FilteredTags = new List<string>(foundTags);
				foreach (var tag in projectSettings.TagFilter)
					cbFiltersTags.Items.Add(tag);
			}
			else if (ValidOption(defaultSettings.TagFilter))
			{
				_manager.FilteredTags = new List<string>(foundTags);
				foreach (var tag in defaultSettings.TagFilter)
					cbFiltersTags.Items.Add(tag);
			}

			//InitialiseDefaultSettings(defaultSettings);
		}

		public ProjectSettings RetrieveSettings()
		{
			var settings = new ProjectSettings
			{
				// general
				DeleteFromSource = cGeneralDelete.Checked.ToString(),
				NoteOpen = tbGeneralStart.Text.Trim(),
				NoteClose = tbGeneralEnd.Text.Trim(),
				SearchDepth = nGeneralDepth.Value.ToString(CultureInfo.InvariantCulture),
				SearchInterval = nGeneralInterval.Value.ToString(CultureInfo.InvariantCulture),

				// preview
				Editor = tbPreviewEditor.Text,
				EditorArgs = tbPreviewArgs.Text,
				PreviewLineCount = nPreviewLineCount.Value.ToString(CultureInfo.InvariantCulture),

				// filters
				FileTypes = cbFiltersTypes.Items.OfType<string>().ToArray(),
				PathFilter = _manager.FilteredPaths.ToArray(),
				FilterTags = cFiltersFilter.Checked.ToString(),
				TagFilter = cbFiltersTags.Items.OfType<string>().ToArray()
			};

			return settings;
		}

		private static bool GetBoolFromOption(ProjectSettings defaultOptions, ProjectSettings project, string member)
		{
#if DEBUG
			string pvalue = null;
			string dvalue = null;
			try
			{
				pvalue = (string)project.GetType().GetProperty(member).GetValue(project);
				dvalue = (string)defaultOptions.GetType().GetProperty(member).GetValue(project);
			}
			catch (Exception e)
			{
				Debug.Fail(e.ToString());
			}
#else
			var pvalue = (string)project.GetType().GetProperty(member).GetValue(project);
			var dvalue = (string)defaultOptions.GetType().GetProperty(member).GetValue(project);
#endif

			return ValidOption(pvalue)
				? bool.Parse(pvalue)
				: (ValidOption(dvalue) && bool.Parse(dvalue));
		}

		private static string GetStringFromOption(ProjectSettings defaultOptions, ProjectSettings project, string member)
		{
#if DEBUG
			string pvalue = null;
			string dvalue = null;
			try
			{
				pvalue = (string)project.GetType().GetProperty(member).GetValue(project);
				dvalue = (string)defaultOptions.GetType().GetProperty(member).GetValue(project);
			}
			catch (Exception e)
			{
				Debug.Fail(e.ToString());
			}
#else
			var pvalue = (string)project.GetType().GetProperty(member).GetValue(project);
			var dvalue = (string)defaultOptions.GetType().GetProperty(member).GetValue(project);
#endif

			return ValidOption(pvalue)
				? pvalue
				: (ValidOption(dvalue) ? dvalue : "");
		}

		private static decimal GetDecimalFromOption(ProjectSettings defaultOptions, ProjectSettings project, string member, decimal fallbackValue)
		{
#if DEBUG
			string pvalue = null;
			string dvalue = null;
			try
			{
				pvalue = (string)project.GetType().GetProperty(member).GetValue(project);
				dvalue = (string)defaultOptions.GetType().GetProperty(member).GetValue(project);
			}
			catch (Exception e)
			{
				Debug.Fail(e.ToString());
			}
#else
			var pvalue = (string)project.GetType().GetProperty(member).GetValue(project);
			var dvalue = (string)defaultOptions.GetType().GetProperty(member).GetValue(project);
#endif

			return ValidOption(pvalue)
				? decimal.Parse(pvalue)
				: (ValidOption(dvalue) ? decimal.Parse(dvalue) : fallbackValue);
		}

		private static bool ValidOption(string value)
		{
			return !string.IsNullOrEmpty(value);
		}

		private static bool ValidOption(IEnumerable value)
		{
			return value != null;
		}

		private void cGeneralDelete_CheckedChanged(object sender, EventArgs e)
		{
			cGeneralDelete.Text = cGeneralDelete.Checked ? "On" : "Off";
		}

		private void bGeneralReplace_Click(object sender, EventArgs e)
		{
			if (ReplaceClicked != null)
				ReplaceClicked(bGeneralReplace, new ReplaceClickedEventArgs { NoteOpen = tbGeneralStart.Text.Trim(), NoteClose = tbGeneralEnd.Text.Trim() });
		}

		private void bPreviewEditor_Click(object sender, EventArgs e)
		{
			_manager.SetPreviewEditorTarget(tbPreviewEditor);
		}

		private void cbPreviewMacros_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbPreviewMacros.SelectedIndex >= 0)
				_manager.InsertMacro(tbPreviewArgs, cbPreviewMacros.SelectedItem as OptionsWindowManager.MacroDisplay);
		}

		private void cbFiltersTypes_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
				return;

			e.Handled = true;
			e.SuppressKeyPress = true;
		}

		private void cbFiltersTypes_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) 
				return;

			bFiltersAddType_Click(sender, e);
			cbFiltersTypes.Text = "";
			e.Handled = true;
			e.SuppressKeyPress = true;
		}

		private void bFiltersAddType_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(cbFiltersTypes.Text) && !cbFiltersTypes.Items.Contains(cbFiltersTypes.Text.Trim()))
				cbFiltersTypes.Items.Add(cbFiltersTypes.Text);
		}

		private void bFiltersRemoveType_Click(object sender, EventArgs e)
		{
			if (cbFiltersTypes.SelectedItem != null)
				cbFiltersTypes.Items.Remove(cbFiltersTypes.SelectedItem);
		}

		private void bFiltersAcceptPaths_Click(object sender, EventArgs e)
		{
			_manager.SetupAndDisplayPaths(Decimal.ToInt32(nGeneralDepth.Value));
		}

		private void cbFiltersTags_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
				return;

			e.Handled = true;
			e.SuppressKeyPress = true;
		}

		private void cbFiltersTags_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) 
				return;

			bFiltersAddTag_Click(sender, e);
			cbFiltersTags.Text = "";
			e.Handled = true;
			e.SuppressKeyPress = true;
		}

		private void bFiltersAddTag_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(cbFiltersTags.Text) && !cbFiltersTags.Items.Contains(cbFiltersTags.Text.Trim()))
				cbFiltersTags.Items.Add(cbFiltersTags.Text);
		}

		private void bFiltersRemoveTag_Click(object sender, EventArgs e)
		{
			if (cbFiltersTags.SelectedItem != null)
				cbFiltersTags.Items.Remove(cbFiltersTags.SelectedItem);
		}

		private void bFiltersInvert_Click(object sender, EventArgs e)
		{
			var newtags = _manager.InvertTagFilter(cbFiltersTags.Items);
			cbFiltersTags.Items.Clear();
			cbFiltersTags.Items.AddRange(newtags.ToArray<object>());
		}
	}
}
