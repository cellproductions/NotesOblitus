namespace NotesOblitus
{
	public class AppSettings
	{
		/// <summary>
		/// The last project that the user was looking at.
		/// </summary>
		public string LastProject { get; set; }

		/// <summary>
		/// The projects that were open before the app was last closed.
		/// </summary>
		public string[] OpenProjects { get; set; }

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

		/// <summary>
		/// Type of updating to do on load.
		/// </summary>
		public string UpdateMode { get; set; }
	}
}
