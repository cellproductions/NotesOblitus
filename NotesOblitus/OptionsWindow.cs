using System;
using System.Collections;
using System.Diagnostics;
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

		public void InitialiseSettings(Project defaultOptions, Project project)
		{
			_manager.RootSearchPath = project.LastSearchPath;
			_manager.AcceptedTypes = project.FileTypes;

			// general
			cGeneralDelete.Checked = GetBoolFromOption(defaultOptions, project, "DeleteFromSource");
			tbGeneralStart.Text = GetStringFromOption(defaultOptions, project, "NoteOpen");
			tbGeneralEnd.Text = GetStringFromOption(defaultOptions, project, "NoteClose");
			nGeneralDepth.Value = GetDecimalFromOption(defaultOptions, project, "SearchDepth", 2);
			nGeneralInterval.Value = GetDecimalFromOption(defaultOptions, project, "SearchInterval", 10);
			cbGeneralUpdate.SelectedIndex = ValidOption(project.UpdateMode)
				? (int)UpdateStyle.None.Parse(project.UpdateMode)
				: (ValidOption(defaultOptions.UpdateMode) ? (int)UpdateStyle.None.Parse(defaultOptions.UpdateMode) : (int)UpdateStyle.None);
			/** TODO(note) dont forget to change the update status button appropriately. should be disabled if Update is set to None (do not check) */

			// preview
			tbPreviewEditor.Text = GetStringFromOption(defaultOptions, project, "Editor");
			tbPreviewArgs.Text = GetStringFromOption(defaultOptions, project, "EditorArgs");
			nPreviewLineCount.Value = GetDecimalFromOption(defaultOptions, project, "PreviewLineCount", 20);
			foreach (var macropair in _manager.Macros)
			{
				cbPreviewMacros.Items.Add(new OptionsWindowManager.MacroDisplay
				{
					DisplayText = macropair.Key.PadRight(15) + macropair.Value,
					Macro = macropair.Value
				});
			}

			// filters
			if (ValidOption(project.FileTypes))
			{
				foreach (var filetype in project.FileTypes)
					cbFiltersTypes.Items.Add(filetype);
			}
			else if (ValidOption(defaultOptions.FileTypes))
			{
				foreach (var filetype in defaultOptions.FileTypes)
					cbFiltersTypes.Items.Add(filetype);
			}
			if (ValidOption(project.PathFilter))
				_manager.FilteredPaths.AddRange(project.PathFilter);
			else if (ValidOption(defaultOptions.PathFilter))
				_manager.FilteredPaths.AddRange(defaultOptions.PathFilter);
			cFiltersFilter.Checked = GetBoolFromOption(defaultOptions, project, "FilterTags");
			if (ValidOption(project.TagFilter))
			{
				foreach (var tag in project.TagFilter)
					cbFiltersTags.Items.Add(tag);
			}
			else if (ValidOption(defaultOptions.TagFilter))
			{
				foreach (var tag in defaultOptions.TagFilter)
					cbFiltersTags.Items.Add(tag);
			}
		}

		public Project RetrieveSettings()
		{
			var settings = new Project
			{
				// general
				DeleteFromSource = cGeneralDelete.Checked.ToString(),
				NoteOpen = tbGeneralStart.Text.Trim(),
				NoteClose = tbGeneralEnd.Text.Trim(),
				SearchDepth = nGeneralDepth.Value.ToString(CultureInfo.InvariantCulture),
				SearchInterval = nGeneralInterval.Value.ToString(CultureInfo.InvariantCulture),
				UpdateMode = UpdateStyleExtensions.FromInt(cbGeneralUpdate.SelectedIndex).ToString(),

				// preview
				Editor = tbPreviewEditor.Text,
				EditorArgs = tbPreviewArgs.Text,
				PreviewLineCount = nPreviewLineCount.Value.ToString(CultureInfo.InvariantCulture),

				// filters
				FileTypes = cbFiltersTypes.Items.OfType<string>().ToArray(),
				PathFilter = _manager.FilteredPaths.ToArray(),
				FilterTags = cFiltersFilter.Checked.ToString(),
				TagFilter = cbFiltersTypes.Items.OfType<string>().ToArray()
			};

			return settings;
		}

		private static bool GetBoolFromOption(Project defaultOptions, Project project, string member)
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
				? Boolean.Parse(pvalue)
				: (ValidOption(dvalue) && Boolean.Parse(dvalue));
		}

		private static string GetStringFromOption(Project defaultOptions, Project project, string member)
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

		private static decimal GetDecimalFromOption(Project defaultOptions, Project project, string member, decimal fallbackValue)
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
				? Decimal.Parse(pvalue)
				: (ValidOption(dvalue) ? Decimal.Parse(dvalue) : fallbackValue);
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
	}
}
