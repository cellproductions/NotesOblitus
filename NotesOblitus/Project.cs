namespace NotesOblitus
{
	public class Project /** TODO(note) might be a good idea to add the app version as a setting as well so that old project files can be updated to a new format in the future */
	{
		/// <summary>
		/// Delete a note from its source folder.
		/// </summary>
		public string DeleteFromSource { get; set; }
		/// <summary>
		/// How many dirs to search through depth wise (0 means search top dir only).
		/// </summary>
		public string SearchDepth { get; set; }
		/// <summary>
		/// Last path searched (tbPath.Text).
		/// </summary>
		public string LastSearchPath { get; set; }
		/// <summary>
		/// How many seconds between each auto search.
		/// </summary>
		public string SearchInterval { get; set; }
		/// <summary>
		/// How many lines the preview dialog displays (or tries to).
		/// </summary>
		public string PreviewLineCount { get; set; }
		/// <summary>
		/// Open pattern for todos.
		/// </summary>
		public string NoteOpen { get; set; }
		/// <summary>
		/// Close pattern for todos.
		/// </summary>
		public string NoteClose { get; set; }
		/// <summary>
		/// Path to an external editing program.
		/// </summary>
		public string Editor { get; set; }
		/// <summary>
		/// Args for the editing program.
		/// </summary>
		public string EditorArgs { get; set; }
		/// <summary>
		/// Whether or not tags in the TagFilter should be excluded from view.
		/// </summary>
		public string FilterTags { get; set; }
		/// <summary>
		/// Tags that should not be shown in the main view.
		/// </summary>
		public string[] TagFilter { get; set; }
		/// <summary>
		/// File types to search through.
		/// </summary>
		public string[] FileTypes { get; set; }
		/// <summary>
		/// Folders and files that are not to be searched.
		/// </summary>
		public string[] PathFilter { get; set; }
		/// <summary>
		/// Type of updating to do on load.
		/// </summary>
		public string UpdateMode { get; set; }
	}

	public class DefaultProject : Project
	{
		/// <summary>
		/// Previous project loaded.
		/// </summary>
		public string LastProject { get; set; }
		
		/// <summary>
		/// Last five projects loaded.
		/// </summary>
		public string[] RecentProjects { get; set; }

		/// <summary>
		/// Last five paths searched.
		/// </summary>
		public string[] RecentSearchPaths { get; set; }

		/// <summary>
		/// Whether or not proxy settings should be used.
		/// </summary>
		public string UseProxy { get; set; }

		/// <summary>
		/// Whether or not to use default proxy settings.
		/// </summary>
		public string UseDefaultProxy { get; set; }

		/// <summary>
		/// Proxy address.
		/// </summary>
		public string ProxyAddress { get; set; }

		/// <summary>
		/// Proxy address' port.
		/// </summary>
		public string ProxyPort { get; set; }

		/// <summary>
		/// Whether or not to use default proxy credentials.
		/// </summary>
		public string UseDefaultCredentials { get; set; }

		/// <summary>
		/// Whether or not to show the password.
		/// </summary>
		public string ShowPassword { get; set; }

		/// <summary>
		/// Proxy username.
		/// </summary>
		public string ProxyUsername { get; set; }

		/// <summary>
		/// Proxy password.
		/// </summary>
		public string ProxyPassword { get; set; }
	}
}
