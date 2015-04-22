using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Global;
using Newtonsoft.Json;
using NotesOblitus.Controls;
using NotesOblitus.Exporters;
using NotesOblitus.ResourceDefaults;
//using Timer = System.Timers.Timer;

namespace NotesOblitus
{
	class NotesOblitusManager /** TODO(threading) accessing Settings from Project2's while auto is on may cause issues */
	{
		// Filesystem paths are more likely to be different starting from the end of their strings.
		public class PathComparer : IEqualityComparer<string>
		{
			public bool Equals(string x, string y)
			{
				var length = x.Length;
				if (length != y.Length)
					return false;

				while (--length >= 0)
					if (x[length] != y[length])
						return false;
				return true;
			}

			public int GetHashCode(string obj)
			{
				return obj.GetHashCode();
			}
		}

		public class FileInfo
		{
			public string FilePath { get; set; }
			public DirectoryStatistic DirectoryData { get; set; }
		}

		private class ParsedArg
		{
			public string Path { get; set; }
			public bool IsProjectFile { get; set; }

			public override int GetHashCode()
			{
				unchecked
				{
					return ((Path != null ? Path.GetHashCode() : 0) * 397) ^ IsProjectFile.GetHashCode();
				}
			}

			public override bool Equals(object obj)
			{
				var arg = obj as ParsedArg;
				return arg != null && (Path.Equals(arg.Path) && IsProjectFile == arg.IsProjectFile);
			}
		}

		private class SearchPath
		{
			public string Path { get; set; }
			public int Depth { get; set; }
		}

		public const string SyntaxFileName = "syntax.json";
		public static readonly string ProjectDirectory = Application.StartupPath + "\\Projects";
		public static readonly string HelpDirectory = Application.StartupPath + "\\Help";
		private const string LicenseFileName = "license.txt";
		private const string HelpIndexFileName = "index.html";
		private const string AppSettingsFileName = "config.cgf";
		//private const string DefaultPrjFileName = "default.noprj";
		private const string ProjectExtension = ".noprj";
		private const int RecentItemsLimit = 5;

		public NotesOblitusApp Owner { get; internal set; }
		//public ViewMode CurrentViewMode { get; set; }
		public AppSettings Settings { get; set; }
		public List<Project2> OpenProjects { get; set; }
		//public Project2 CurrentProject2 { get; set; } /** TODO(refactor) remove the 2 from this */
		//public DefaultProject DefaultProject { get; set; }
		//public Project CurrentProject { get; internal set; }
		//public Note SelectedNote { get; set; }
		//public bool AutoScan { get; internal set; }
		public bool IsScanning { get; internal set; }
		public bool IsUpdatingView { get; internal set; }
		public string[] EntryArgs { get; internal set; }
		//private readonly List<Note> _notes = new List<Note>();
		//private readonly HashSet<string> _tags = new HashSet<string>();
		//private readonly StatisticsData _allStatisticsData = new StatisticsData();
		//private bool _defaultPrjLoaded = true;
		//private readonly object _autoLock = new object();
		//private readonly Timer _autoTimer = new Timer();
		private readonly AutoScanScheduler _autoScheduler;
		private Thread _updateThread; // this thread is kept alive on close so it can finish the update
		private bool _updateAvailable;

		public NotesOblitusManager(NotesOblitusApp owner, string[] entryArgs) /** TODO(change) should add default constants for some options, then replace those values */
		{
			Owner = owner;
			OpenProjects = new List<Project2>();
			//CurrentViewMode = ViewMode.ListView;
			EntryArgs = entryArgs;
#if false
			_autoTimer.Elapsed += (sender, args) => /** TODO(refactor) this needs to exist for each project really  */
			{
				if (!AutoScan)
					return;
				if (string.IsNullOrEmpty(CurrentProject.LastSearchPath))
					return;
				if (!Owner.IsDisposed) /** TODO(bug) this doesnt work. still throws exception when Owner has been closed */
				{
					Owner.Invoke(new MethodInvoker(() =>
					{
						try
						{
							ScanAndCollectNotes(false);
							Owner.UpdateView();
						}
						catch (Exception e)
						{
							Logger.Log(e);
						}
					}));
				}
			};
#endif
			_autoScheduler = new AutoScanScheduler(Owner);
		}

		private void CreateDefaultPaths()
		{
			try
			{
				var test = Application.StartupPath + "\\test";
				File.Create(test).Close(); /** TODO(note) pretty grub way of finding out if we have permission to write in this folder */
				File.Delete(test);
			}
			catch (UnauthorizedAccessException)
			{
				if (MessageBox.Show(Owner,
					@"Notes Oblitus does not have permission to read/write its files! Would you like to restart in elevated mode?",
					@"Permissions",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					var info = new ProcessStartInfo(Application.ExecutablePath)
					{
						UseShellExecute = true,
						Verb = "runas"
					};
					try
					{
						Process.Start(info);
					}
					catch (Win32Exception ex)
					{
						if (ex.NativeErrorCode == 1223) // 1223 = ERROR_CANCELLED
							MessageBox.Show(Owner, @"Failed to read/write from/to configuration files! Please run in elevated mode or move Notes Oblitus to a location that requires less privileges.", 
							@"Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show(Owner, @"Failed to read/write from/to configuration files! Please run in elevated mode or move Notes Oblitus to a location that requires less privileges.",
						@"Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				Owner.Load += (sender, args) => ExitApplication(false);
			}

			if (!Directory.Exists(ProjectDirectory))
				Directory.CreateDirectory(ProjectDirectory);
			if (!Directory.Exists(HelpDirectory))
				Directory.CreateDirectory(HelpDirectory);
			if (!File.Exists(LicenseFileName))
				File.WriteAllText(LicenseFileName, MissingResources.GetLicenseFileAsString());
			if (!File.Exists(SyntaxFileName))
				File.WriteAllText(SyntaxFileName, MissingResources.GetSyntaxFileAsString());
			//if (!File.Exists(DefaultPrjFileName))
			//	File.WriteAllText(DefaultPrjFileName, MissingResources.GetDefaultPrjAsString());
		}

		private static IEnumerable<ParsedArg> ParseArgs(IList<string> args)
		{

#if DEBUG
			Debug.Assert(args != null);
#endif
			var errlist = new List<Exception>();
			var arglist = new List<ParsedArg>();
			for (var i = 0; i < args.Count; ++i)
			{
				args[i] = args[i].Trim();
				if (args[i].Length <= 0)
					continue;

				args[i] = args[i].Replace('/', '\\');
				if (args[i][args[i].Length - 1] == '\\' || args[i][args[i].Length - 1] == '"') // '"' common mistake when passing path wrapped in quotation marks
					args[i] = args[i].Substring(0, args[i].Length - 1).Trim();

				try
				{
					args[i] = Path.GetFullPath(args[i]);
					var attributes = File.GetAttributes(args[i]);

					arglist.Add(new ParsedArg
					{
						Path = args[i],
						IsProjectFile = (attributes & FileAttributes.Directory) != FileAttributes.Directory
					});
				}
				catch (Exception e)
				{
					errlist.Add(e);
				}
			}

			if (errlist.Count <= 0) 
				return arglist;

			var output = "Errors were found in the arguments:" + Environment.NewLine;
			output += errlist.Aggregate(output, (current, exception) => current + 
				(exception.Message + Environment.NewLine));
			MessageBox.Show(output, @"Argument Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			return arglist;
#if false
#if DEBUG
			Debug.Assert(entryPath != null);
#endif
			entryPath = entryPath.Trim();
			if (entryPath.Length <= 0)
				return OpenMode.Invalid;

			if (entryPath.EndsWith(@"\") || entryPath[entryPath.Length - 1] == '"') // '"' common mistake when passing path wrapped in quotation marks
				entryPath = entryPath.Substring(0, entryPath.Length - 1).Trim();

			if (!entryPath.EndsWith(ProjectExtension))
				return Directory.Exists(entryPath) ? OpenMode.FromPath : OpenMode.Invalid;

			if (!entryPath.Contains("\\"))
				entryPath = ProjectDirectory + '\\' + entryPath;
			return File.Exists(entryPath) ? OpenMode.FromProject : OpenMode.Invalid;
#endif
		}

		public void LoadAndSetupOptions(TabControl projectsControl)
		{
			CreateDefaultPaths();
			Settings = JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText(AppSettingsFileName));

			var args = ParseArgs(EntryArgs);

			if (Settings.OpenProjects != null)
			{
				var prevopen = ParseArgs(Settings.OpenProjects);
				foreach (var arg in prevopen.Where(arg => !args.Contains(arg)))
					((List<ParsedArg>)args).Add(arg);
			}

			AddProjectsFromArgs(projectsControl, args);
#if false
			CreateDefaultPaths();
			DefaultProject = JsonConvert.DeserializeObject<DefaultProject>(File.ReadAllText(DefaultPrjFileName));

			var entryPath = EntryArgs;
			var openmode = ParseArgs(ref entryPath);
			switch (openmode)
			{
				case OpenMode.FromPath:
					DefaultProject.LastSearchPath = entryPath;
					CurrentProject = DefaultProject;
					break;
				case OpenMode.FromProject:
					CurrentProject = JsonConvert.DeserializeObject<Project>(File.ReadAllText(entryPath));
					_defaultPrjLoaded = false;
					break;
				case OpenMode.Invalid:
					CurrentProject = DefaultProject;
					if (entryPath.Length > 0) // something went wrong
						MessageBox.Show(Owner,
							@"Failed to load project from argument! Make sure that the path exists before trying again." + Environment.NewLine + entryPath,
							@"Project Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else // default load (loading without args)
					{
						if (!string.IsNullOrEmpty(DefaultProject.LastProject) && File.Exists(DefaultProject.LastProject))
						{
							CurrentProject = JsonConvert.DeserializeObject<Project>(File.ReadAllText(DefaultProject.LastProject));
							_defaultPrjLoaded = false;
						}
						else
							DefaultProject.LastProject = ""; // something was wrong with the last project (or it was empty), so clear it
					}
					break;
				default:
					throw new Exception("Invalid OpenMode! [openmode=" + openmode + ']');
			}

			if (string.IsNullOrEmpty(CurrentProject.LastSearchPath))
				CurrentProject.LastSearchPath = Application.StartupPath;

			Owner.Text = GlobalVars.ApplicationTitle + ' ' + GlobalVars.ApplicationVersion;
			ResetAutoTimer();
			if (_defaultPrjLoaded) 
				return CurrentProject.LastSearchPath;

			Owner.Text += @" - " + GetFolderName(DefaultProject.LastProject);

			return CurrentProject.LastSearchPath;
#endif
		}

		private void AddProjectsFromArgs(TabControl projectsControl, IEnumerable<ParsedArg> args)
		{
			foreach (var arg in args)
				CreateAndAddProject(projectsControl, arg);
		}

		private Project2 CreateAndAddProject(TabControl projectsControl, ParsedArg arg)
		{
			var prjsettings = CreateProjectSettings(arg);
			var view = CreateProjectView(prjsettings);
			var project = CreateProject(prjsettings, view, arg);

			OpenProjects.Add(project);
			projectsControl.TabPages.Add(view);

			return project;
		}

		private Project2 CreateProject(ProjectSettings settings, ProjectPage view, ParsedArg arg)
		{
			var project = new Project2(settings, view) { IsProjectFile = arg.IsProjectFile };
			if (!string.IsNullOrEmpty(settings.AutoScan) && !string.IsNullOrEmpty(settings.SearchInterval) && bool.Parse(settings.AutoScan))
				_autoScheduler.AddTime(int.Parse(settings.SearchInterval) * 1000, (sender, eventArgs) =>
				{
					if (string.IsNullOrEmpty(settings.LastSearchPath))
						return;
					try
					{
						ScanAndCollectNotes(project, false);
						UpdateCurrentView(project);
					}
					catch (Exception e)
					{
						Logger.Log(e);
					}
				});

			project.PathWatcher.Path = arg.Path;
			project.PathWatcher.Changed += (sender, args) =>
			{
				/** TODO(incomplete) ask the user to refresh the project (or do it automatically, maybe a "dont ask again" button) */
			};
			project.PathWatcher.Deleted += (sender, args) =>
			{
				/** TODO(incomplete) notify the user, ask if they plan on keeping the project open (if so, dont allow updates, only refreshes (to the view that is)) set IsProjectFile to false */
			};
			project.PathWatcher.Renamed += (sender, args) =>
			{
				/** TODO(incomplete) same as Deleted probably */
			};
			project.PathWatcher.Error += (sender, args) =>
			{
				/** TODO(incomplete) same as Deleted but also log the error */
			};

			//var page = new TabPage(GetFolderName(arg.Path)) { Tag = project };
			//page.Controls.Add(view);
			view.Text = GetFolderName(arg.Path);
			view.Tag = project;

			return project;
		}

		private static ProjectSettings CreateProjectSettings(ParsedArg arg)
		{
			return arg.IsProjectFile ? JsonConvert.DeserializeObject<ProjectSettings>(File.ReadAllText(arg.Path)) :
					CreateSettingsFromTemplate(new ProjectSettings { LastSearchPath = arg.Path });
		}

		private static ProjectSettings CreateSettingsFromTemplate(ProjectSettings copy)
		{
			var project = CreateDefaultSettings();

			if (copy == null)
				return project;

			foreach (var property in copy.GetType().GetProperties())
			{
				var value = property.GetValue(copy);
				if (value == null)
					continue;

				if (value is string)
				{
					if ((value as string).Length > 0)
						property.SetValue(project, value);
				}
				else
					property.SetValue(project, value);
			}

			return project;
		}

		private static ProjectSettings CreateDefaultSettings()
		{
			return new ProjectSettings
			{
				DeleteFromSource = "False",
				AutoScan = "False",
				SearchDepth = "2",
				LastSearchPath = "",
				SearchInterval = "10",
				PreviewLineCount = "20",
				NoteOpen = "/** TODO",
				NoteClose = "*/",
				Editor = "",
				EditorArgs = "",
				FilterTags = "False",
				TagFilter = null,
				FileTypes = null,
				PathFilter = null
			};
		}

		private ProjectPage CreateProjectView(ProjectSettings settings)
		{
			var view = new ProjectPage /** TODO(refactor) move view creation into a private function */
			{
				SearchPath = string.IsNullOrEmpty(settings.LastSearchPath) ? string.Empty : settings.LastSearchPath,
				Dock = DockStyle.Fill
			};

			view.SearchPathChanged += (sender, eventArgs) => settings.LastSearchPath = eventArgs.Path.Trim();
			view.SearchPathActivated += (sender, eventArgs) =>
			{
				if (!string.IsNullOrEmpty(settings.AutoScan) && bool.Parse(settings.AutoScan))
					return;

				ScanAndCollectNotes(view.Tag as Project2);
				if (view.Visible)
					UpdateCurrentView(view.Tag as Project2);
			};
			view.NoteClicked += (sender, eventArgs) => ShowViewMenu(eventArgs.Location, view.Tag as Project2);
			view.NoteDoubleClicked += (sender, eventArgs) => OpenPreviewDialog(view.Tag as Project2);

			if (!string.IsNullOrEmpty(settings.LastSearchPath))
				view.SearchPath = settings.LastSearchPath;

			return view;
		}

		public void CheckForUpdates(bool manualCheck, bool notify, bool wait)
		{
			/** TODO(incomplete) this should be done on another thread. if the mode is set to none, dont check. otherwise, ask or auto update (still on another thread) */
			if (!manualCheck && String.IsNullOrEmpty(Settings.UpdateMode))
			{
				Settings.UpdateMode = UpdateStyle.None.ToString();
				return;
			}

			if (_updateThread != null && _updateThread.IsAlive)
				_updateThread.Abort(); // destroy the process and start again
			_updateThread = new Thread(RunUpdater);
			_updateThread.Start(new object[] { manualCheck, notify });
			if (wait)
				_updateThread.Join();
		}

		private void RunUpdater(object param)
		{
			try
			{
				var manualcheck = (bool)((object[])param)[0];
				var notify = (bool)((object[])param)[1];

				var update = UpdateStyle.None.Parse(Settings.UpdateMode);
				if (!manualcheck && update == UpdateStyle.None)
					return;

				var updater = CreateUpdater(!string.IsNullOrEmpty(Settings.UseProxy) && Boolean.Parse(Settings.UseProxy));
				Dictionary<string, Version> newversions;
				var updates = updater.AreUpdatesAvailable(Version.Parse(GlobalVars.ApplicationVersion), out newversions);
				if (!updates["Application"]) /** TODO(incomplete) if the patcher/manifest needs updating, request a manual download */
				{
					if (notify)
						MessageBox.Show(Owner, @"There are no updates available.", @"Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				if (manualcheck)
				{
					if (MessageBox.Show(Owner, @"A new update is available (version " + newversions["Application"] +
					                           @"). Would you like to update now (this will restart the application)?",
						@"Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
					    != DialogResult.Yes)
					{
						_updateAvailable = true;
						return;
					}
				}
				else if (update == UpdateStyle.Notify)
				{
					if (MessageBox.Show(Owner, @"A new update is available (version " + newversions["Application"] +
											   @"). Would you like to update now (this will restart the application)?",
						@"Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
						!= DialogResult.Yes)
					{
						_updateAvailable = true;
						return;
					}
				}

				const string patcherFileName = "Patcher.exe"; /** TODO(change) .exe name might change, so might have to use a GUID or something */
				foreach (var process in Process.GetProcessesByName(patcherFileName).Where(process => !process.HasExited))
				{
					process.Kill();
					for (var i = 0; i < 100 && !process.HasExited; ++i)
						Thread.Sleep(100);
				}
				if (Process.GetProcessesByName(patcherFileName).Length > 0)
				{
					MessageBox.Show(Owner, @"Please close all instances of " + patcherFileName + @" before trying to update.", @"Update Error", MessageBoxButtons.OK,
						MessageBoxIcon.Exclamation);
					return;
				}

				var temppath = Application.StartupPath + "\\temp";
				if (!Directory.Exists(temppath))
					Directory.CreateDirectory(temppath);
				else
				{
					var directory = new DirectoryInfo(temppath);
					foreach (var file in directory.GetFiles("*", SearchOption.AllDirectories))
						file.Delete();
					foreach (var dir in directory.GetDirectories())
						dir.Delete(true);
				}

				var progresswindow = new ProgressWindow
				{
					Text = @"Updating",
					ProgressStatus = "Downloading files %val/%max"
				};
				updater.DownloadsStarted += (sender, args) =>
				{
					progresswindow.Show(Owner);
					progresswindow.StartProgress(args.FileCount);
					progresswindow.Update();
				};
				updater.DownloadComplete += (sender, args) =>
				{
					progresswindow.IncrementProgress();
				};

				updater.DownloadUpdate(temppath);

				progresswindow.Close();

				Owner.FormClosed += (sender, args) =>
				{
					var process = new ProcessStartInfo(Application.StartupPath + '\\' + patcherFileName,
						'"' + Application.StartupPath + "\" \"" +
						temppath + "\" " +
						GlobalVars.ApplicationExeName + " \"" +
						EntryArgs + '"')
					{
						UseShellExecute = true
					};
					Process.Start(process);
				};
				//_defaultPrjLoaded = false;
				// this will stop this instance of the app from saving the default settings (will get saved on restart)
				ExitApplication(true);
			}
			catch (Exception e)
			{
				MessageBox.Show(Owner, @"An exception was encounted while updating!" + Environment.NewLine + e, @"Update Error", MessageBoxButtons.OK,
						MessageBoxIcon.Exclamation);
				Logger.Log(e);
			}
		}

		private Updater CreateUpdater(bool useProxy) /** TODO(change) this path should be hashed */
		{
			return new Updater("https://dl.dropboxusercontent.com/u/28551411/NotesOblitus/", useProxy, !useProxy ? null :
					(!string.IsNullOrEmpty(Settings.UseDefaultProxy) && Boolean.Parse(Settings.UseDefaultProxy) ? (WebProxy)WebRequest.DefaultWebProxy :
					new WebProxy
					{
						Address = new Uri(Settings.ProxyAddress + ':' + Settings.ProxyPort),
						UseDefaultCredentials = !string.IsNullOrEmpty(Settings.UseDefaultCredentials) && bool.Parse(Settings.UseDefaultCredentials),
						Credentials = new NetworkCredential(
							!string.IsNullOrEmpty(Settings.ProxyUsername) ? Settings.ProxyUsername : "",
							!string.IsNullOrEmpty(Settings.ProxyPassword) ? Settings.ProxyPassword : ""),
						BypassProxyOnLocal = false
					}));
		}

		public void OpenExistingProject(TabControl projectControl)
		{
			var projectpath = ShowOpenDialog();
			if (projectpath == null)
				return;

			var project = CreateAndAddProject(projectControl, new ParsedArg { Path = projectpath, IsProjectFile = true });
			RunProjectScan(project);
		}

		public string ShowOpenDialog()
		{
			var dialog = new OpenFileDialog
			{
				CheckFileExists = true,
				CheckPathExists = true,
				InitialDirectory = ProjectDirectory,
				Title = @"Open project",
				Filter = @"Project files (*" + ProjectExtension + @")|*" + ProjectExtension
			};

			return dialog.ShowDialog(Owner) == DialogResult.OK ? dialog.FileName : null;
		}

		private void RunProjectScan(Project2 project)
		{
			var recentprojects = Settings.RecentProjects;
			AddToRecents(Settings.LastProject, ref recentprojects, RecentItemsLimit);
			Settings.RecentProjects = recentprojects;

			//ResetAutoTimer();

			if (!string.IsNullOrEmpty(project.Settings.AutoScan) && !bool.Parse(project.Settings.AutoScan))
				ScanAndCollectNotes(project);
		}

		public void SaveProject(Project2 project)
		{
			if (project.IsProjectFile)
				WriteSettings(project, project.PathWatcher.Path);
			else
				SaveProjectAs(project);
		}

		public void SaveProjectAs(Project2 project)
		{
			var projectpath = ShowSaveDialog();
			if (projectpath == null)
				return;

			WriteSettings(project, projectpath);
			project.PathWatcher.Path = projectpath;

			var recentprojects = Settings.RecentProjects;
			AddToRecents(projectpath, ref recentprojects, RecentItemsLimit);
			Settings.RecentProjects = recentprojects;
		}

		private string ShowSaveDialog()
		{
			var dialog = new SaveFileDialog
			{
				FileName = '*' + ProjectExtension,
				CheckPathExists = true,
				OverwritePrompt = true,
				InitialDirectory = ProjectDirectory,
				Title = @"Save project",
				Filter = @"Project files (*" + ProjectExtension + @")|*" + ProjectExtension,
				AddExtension = true
			};

			return dialog.ShowDialog(Owner) == DialogResult.OK ? dialog.FileName : null;
		}

		private static void WriteSettings(object settings, string projectFilePath)
		{
			File.WriteAllText(projectFilePath, JsonConvert.SerializeObject(settings, Formatting.Indented));
		}

		/** TODO(specific) specific to each project */
#if false
		public string OpenProject()
		{
			var dialog = new OpenFileDialog
			{
				CheckFileExists = true,
				CheckPathExists = true,
				InitialDirectory = ProjectDirectory,
				Title = @"Open project",
				Filter = @"Project files (*" + ProjectExtension + @")|*" + ProjectExtension
			};

			if (dialog.ShowDialog(Owner) != DialogResult.OK)
				return null;

			RunProject(dialog.FileName);
			
			return CurrentProject.LastSearchPath;
		}

		private void RunProject(string projectPath)
		{
			DefaultProject.LastProject = projectPath;
			CurrentProject = JsonConvert.DeserializeObject<Project>(File.ReadAllText(DefaultProject.LastProject));
			_defaultPrjLoaded = false;
			Owner.Text = GlobalVars.ApplicationTitle + ' ' + GlobalVars.ApplicationVersion + @" - " + GetFolderName(DefaultProject.LastProject);

			var recentprojects = DefaultProject.RecentProjects;
			AddToRecents(DefaultProject.LastProject, ref recentprojects, RecentItemsLimit);
			DefaultProject.RecentProjects = recentprojects;

			ResetAutoTimer();

			if (!AutoScan)
				ScanAndCollectNotes();
		}

		public void SaveProject()
		{
			if (_defaultPrjLoaded)
				SaveProjectAs();
			else
				WriteProject(SaveMode.ProjectOnly);
		}

		public void SaveProjectAs()
		{
			var filename = ShowSaveProjectDialog();
			if (filename == null)
				return;

			DefaultProject.LastProject = filename;
			Owner.Text = GlobalVars.ApplicationTitle + ' ' + GlobalVars.ApplicationVersion + @" - " + GetFolderName(DefaultProject.LastProject);
			_defaultPrjLoaded = false;

			var recentprojects = DefaultProject.RecentProjects;
			AddToRecents(DefaultProject.LastProject, ref recentprojects, RecentItemsLimit);
			DefaultProject.RecentProjects = recentprojects;

			WriteProject(SaveMode.ProjectOnly);
		}

		private string ShowSaveProjectDialog()
		{
			var dialog = new SaveFileDialog
			{
				FileName = '*' + ProjectExtension,
				CheckPathExists = true,
				OverwritePrompt = true,
				InitialDirectory = ProjectDirectory,
				Title = @"Save project",
				Filter = @"Project files (*" + ProjectExtension + @")|*" + ProjectExtension,
				AddExtension = true
			};

			return dialog.ShowDialog(Owner) == DialogResult.OK ? dialog.FileName : null;
		}

		private void WriteProject(SaveMode saveMode)
		{
			switch (saveMode)
			{
				case SaveMode.DefaultOnly:
					{
						var defaultserialized = JsonConvert.SerializeObject(DefaultProject, Formatting.Indented);
						File.WriteAllText(DefaultPrjFileName, defaultserialized);
					}
					break;
				case SaveMode.ProjectOnly:
					{
						var currentserialized = JsonConvert.SerializeObject(CurrentProject, Formatting.Indented);
						File.WriteAllText(DefaultProject.LastProject, currentserialized);
					}
					break;
				case SaveMode.Both:
					{
						var defaultserialized = JsonConvert.SerializeObject(DefaultProject, Formatting.Indented);
						var currentserialized = JsonConvert.SerializeObject(CurrentProject, Formatting.Indented);
						File.WriteAllText(DefaultPrjFileName, defaultserialized);
						File.WriteAllText(DefaultProject.LastProject, currentserialized);
					}
					break;
				default:
					throw new Exception("Invalid SaveMode! [savemode=" + saveMode + ']');
			}
		}
#endif

		public string ChooseScanDirectory(Project2 project)
		{
			var dialog = new FolderBrowserDialog
			{
				SelectedPath = project.Settings.LastSearchPath,
				ShowNewFolderButton = true,
				Description = @"Select a folder to scan from:"
			};
			if (project.Settings.LastSearchPath.Trim().Length > 0)
				if (Directory.Exists(project.Settings.LastSearchPath))
					dialog.SelectedPath = project.Settings.LastSearchPath;

			if (dialog.ShowDialog(Owner) != DialogResult.OK)
				return null;

			project.Settings.LastSearchPath = dialog.SelectedPath;
			return project.Settings.LastSearchPath;
		}
#if false
		public void SetAutoScan(bool autoScan)
		{
			AutoScan = autoScan;
		}

		private void ResetAutoTimer()
		{
			if (_autoTimer == null)
				throw new Exception("_autoTimer");
			if (CurrentProject == null)
				throw new Exception("CurrentProject");
			if (CurrentProject.SearchInterval == null)
				throw new Exception("SearchInterval");
			int interval;
			if (!Int32.TryParse(CurrentProject.SearchInterval, out interval))
				interval = 10;
			_autoTimer.Interval = interval * 1000;

			if (!_autoTimer.Enabled)
				_autoTimer.Start();
		}
#endif
		public void ExportProject(Project2 project, string filePath, IObjectExporter exporter)
		{
			lock (project.AutoLock)
			{
				exporter.ExportObject(filePath, project.Notes);
			}
		}

		public void UpdateRecentProjects(ToolStripMenuItem projectsView, string[] recentProjects)
		{
			projectsView.DropDownItems.Clear();
			UpdateRecentItems(projectsView, recentProjects, (sender, args) =>
			{
				var menuview = (ToolStripMenuItem)sender;
				//RunProject(menuview.Tag as string); /** TODO(refactor) this should open a project file (if it still exists). if it's currently open, select that page */
			});
		}

		public void UpdateRecentSearches(ToolStripMenuItem searchesView, string[] recentSearchPaths, ProjectPage searchPathPage)
		{
			searchesView.DropDownItems.Clear();
			UpdateRecentItems(searchesView, recentSearchPaths, (sender, args) =>
			{
				var menuview = (ToolStripMenuItem)sender;
				searchPathPage.SearchPath = menuview.Tag as string;
				//ScanAndCollectNotes(); /** TODO(refactor) this should also open a new project (if it still exists). if it's currently open, select that page */
			});
		}

		private void UpdateRecentItems(ToolStripDropDownItem itemView, IEnumerable<string> recentItems, EventHandler clickHandler)
		{
			foreach (var item in recentItems)
			{
				var newitem = new ToolStripMenuItem
				{
					Size = new Size(195, 22),
					Tag = item
				};
				newitem.Click += clickHandler;
				newitem.Text = GetShorterPath(item, newitem.Font, newitem.ContentRectangle.Width);

				itemView.DropDownItems.Add(newitem);
			}
		}

		private string GetShorterPath(string path, Font font, int width)
		{
			var fititem = path.Trim();
			var graphics = Owner.CreateGraphics();

			var splitqueue = new Queue<string>(fititem.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries));
			var drive = splitqueue.Dequeue();

			do
			{
				var check = "";
				var enumerator = splitqueue.GetEnumerator();
				for (var i = 0; i < splitqueue.Count && enumerator.MoveNext(); ++i)
					check += '\\' + enumerator.Current;

				check = drive + "\\..." + check;
				var size = graphics.MeasureString(check, font).ToSize();

				if (size.Width >= width)
				{
					splitqueue.Dequeue();

					if (splitqueue.Count <= 0)
						break;
				}
				else
					return check;

			} while (true);

			return fititem;
		}

		public void ExitApplication(bool save)
		{
			/*
			AutoScan = false;
			if (_autoTimer.Enabled)
				_autoTimer.Stop();
			 * */
			if (_autoScheduler.IsRunning())
				_autoScheduler.StopScheduler();

			if (save)
				WriteSettings(Settings, AppSettingsFileName);
				//WriteProject(SaveMode.DefaultOnly);

			if (Application.OpenForms.OfType<NotesOblitusApp>().Any())
				Owner.Close();
		}

		public void ShowStatistics(Project2 project)
		{
			new StatisticsDialog
			{
				Statistics = project.AllStatisticsData
			}.ShowDialog(Owner);
		}

		public List<FileInfo> GetScannableFilePaths(Project2 project, string startPathName)
		{
			var searchfiles = new List<FileInfo>();
			var currdepth = 1;
			var searchdepth = int.Parse(project.Settings.SearchDepth);
			var paths = new List<SearchPath>(1) { new SearchPath { Path = project.Settings.LastSearchPath, Depth = currdepth } };
			var fileTypes = new List<string>(project.Settings.FileTypes == null ? 1 : project.Settings.FileTypes.Length);
			if (project.Settings.FileTypes != null)
				fileTypes.AddRange(project.Settings.FileTypes.Select(filetype => '.' + filetype));

			while (paths.Count > 0)
			{
				var currpath = paths[0];
				paths.RemoveAt(0);

				if (currpath.Depth > searchdepth)
					continue;
				currdepth = currpath.Depth;

				if (!Directory.Exists(currpath.Path))
				{
					MessageBox.Show(Owner, @"Path " + currpath.Path + @" was not found!", @"Search Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					continue;
				}

				if (IsDirectoryFiltered(project.Settings, currpath.Path))
					continue;

				var subdirs = Directory.GetDirectories(currpath.Path);
				if (subdirs.Length > 0 && currdepth < searchdepth)
					paths.AddRange(subdirs.Select(subdir => new SearchPath { Path = subdir, Depth = currdepth + 1 }));

				var dirStatistic = new DirectoryStatistic
				{
					DirectoryName = currpath.Path.Substring(currpath.Path.LastIndexOf(startPathName, StringComparison.Ordinal))
				};
				project.AllStatisticsData.DirectoryStatistics.Add(dirStatistic);

				var fileEnumerable = (from filepath in Directory.GetFiles(currpath.Path)
									  where !IsFileFiltered(project.Settings, filepath, fileTypes)
									  select 
									  new FileInfo { FilePath = filepath, DirectoryData = dirStatistic });
				var fileInfos = fileEnumerable as FileInfo[] ?? fileEnumerable.ToArray();
				dirStatistic.FileCount = fileInfos.Length; /** TODO(note) should this be the number of files with notes in them or the total number of files? */

				searchfiles.AddRange(fileInfos);
			}

			return searchfiles;
		}

		private static bool IsDirectoryFiltered(ProjectSettings settings, string path) /** TODO(performance) this could be sped up by passing a list of directories only and searching through that instead */
		{
			return settings.PathFilter != null && settings.PathFilter.Contains(path, new PathComparer());
		}

		private static bool IsPathFiltered(ProjectSettings settings, string path)
		{
			return settings.PathFilter != null && settings.PathFilter.Contains(path, new PathComparer());
		}

		private static bool IsFileFiltered(ProjectSettings settings, string path, IEnumerable<string> fileTypes)
		{
			if (settings.FileTypes == null)
				return IsPathFiltered(settings, path);
			return !fileTypes.Any(path.EndsWith) || IsPathFiltered(settings, path);
		}

		public void ScanAndCollectNotes(Project2 project, bool showProgress = true)
		{
			lock (project.AutoLock)
			{
				if (IsScanning)
					return;
				IsScanning = true;

				project.Notes.Clear();
				project.Tags.Clear();
				project.AllStatisticsData.Clear();

				if (string.IsNullOrEmpty(project.Settings.LastSearchPath))
					return;

				var recentsearches = Settings.RecentSearchPaths;
				AddToRecents(project.Settings.LastSearchPath, ref recentsearches, RecentItemsLimit);
				Settings.RecentSearchPaths = recentsearches;

				ProgressWindow progresswindow = null;
				if (showProgress)
				{
					progresswindow = new ProgressWindow
					{
						Text = @"Reading Files",
						InitialStatus = @"Scanning...",
						ProgressStatus = @"Reading %val/%max files..."
					};
					progresswindow.Show(Owner);
					progresswindow.Update();
				}

				var timer = Stopwatch.StartNew();
				var startpathname = GetFolderName(project.Settings.LastSearchPath);
				var files = GetScannableFilePaths(project, startpathname);
				if (showProgress)
					progresswindow.StartProgress(files.Count);

				var regex = new Regex("(^\\s*$)|(" + Regex.Escape(project.Settings.NoteOpen) + "((.|\n)*?)" + Regex.Escape(project.Settings.NoteClose) + ')',
									RegexOptions.Multiline); // finds empty lines as well as notes

				CollectNotesAndStats(project, progresswindow, files, regex, startpathname);
				timer.Stop();
				if (showProgress)
				{
					progresswindow.IncrementProgress();
					progresswindow.Close();
				}
				project.AllStatisticsData.TimeElapsed = (timer.ElapsedMilliseconds / 1000.0f);

				IsScanning = false;
			}
		}

		public static string GetFolderName(string path)
		{
			var index = path.LastIndexOf('\\');
			return index >= 0 && index + 1 < path.Length ? path.Substring(index + 1) : path;
		}

		public static string GetFileExtension(string path)
		{
			var index = path.LastIndexOf('.');
			return index >= 0 && index + 1 < path.Length ? path.Substring(index + 1) : path;
		}

		private void CollectNotesAndStats(Project2 project, ProgressWindow progressWindow, IEnumerable<FileInfo> filePaths, Regex searchRegex, string startPathName)
		{
			try
			{
				foreach (var fileinfo in filePaths)
				{
					if (progressWindow != null)
						progressWindow.IncrementProgress(); // dont like this being here but ok

					var filepath = fileinfo.FilePath;
					var filename = filepath.Substring(filepath.IndexOf(startPathName, StringComparison.Ordinal));

					var currstat = new FileStatistic
					{
						FileName = filename,
						CharCount = 0,
						LineCount = 0,
						NoteCount = 0
					};
					project.AllStatisticsData.FileStatistics.Add(currstat); // add a new statistic

					var text = File.ReadAllText(filepath);
					currstat.CharCount = text.Length;
					ReadMatches(project, text, searchRegex, filepath, filename, currstat);

					fileinfo.DirectoryData.LineCount += currstat.LineCount; // update directory statistics based on file data
					fileinfo.DirectoryData.NoteCount += currstat.NoteCount;
					fileinfo.DirectoryData.EmptyLineCount += currstat.EmptyLineCount;
				}
			}
			catch (Exception e)
			{
				Logger.Log(e);
			}
		}

		private void ReadMatches(Project2 project, string text, Regex searchRegex, string filePath, string fileName, FileStatistic currStatistic)
		{
			var lastindex = 0;
			var currline = 1;

			foreach (Match match in searchRegex.Matches(text))
			{
				if (match.Value.Trim().Length == 0)
				{
					++currStatistic.EmptyLineCount;
					continue;
				}

				var trimmed = match.Value.Trim();
				var len = project.Settings.NoteOpen.Length;
				trimmed = trimmed.Substring(len, trimmed.LastIndexOf(project.Settings.NoteClose, StringComparison.Ordinal) - len).Trim();
				currline += IndexToLine(text, match.Index, lastindex);
				lastindex = match.Index;

				if (trimmed[0] == '(')
				{
					var notesection = trimmed.Substring(1, trimmed.IndexOf(')') - 1);
					foreach (var column in notesection.Split(','))
					{
						var tag = column.Trim().ToLower();
						if (tag.Length <= 0)
							continue;

						var note = new Note
						{
							FilePath = filePath,
							FileName = fileName,
							Tag = tag,
							Message = trimmed.Substring(trimmed.IndexOf(')') + 1).Trim(),
							Line = currline,
							All = match.Value.Trim()
						};

						project.Tags.Add(tag);
						if (!project.AllStatisticsData.TagStatistics.ContainsKey(tag)) // update the tag count statistics
							project.AllStatisticsData.TagStatistics.Add(tag, new TagStatistic { TagName = tag, TagCount = 1 });
						else
							++project.AllStatisticsData.TagStatistics[tag].TagCount;

						project.Notes.Add(note);
					}
				}
				else
				{
					if (!project.AllStatisticsData.TagStatistics.ContainsKey("none")) // update the no tag count statistics
						project.AllStatisticsData.TagStatistics.Add("none", new TagStatistic { TagName = "none", TagCount = 1 });
					else
						++project.AllStatisticsData.TagStatistics["none"].TagCount;

					project.Notes.Add(new Note
					{
						FilePath = filePath,
						FileName = fileName,
						Message = trimmed,
						Line = currline,
						All = match.Value.Trim()
					});
				}

				++currStatistic.NoteCount; // update note count for statistics
			}

			currStatistic.LineCount = currline + IndexToLine(text, text.Length, lastindex); // update line count for statistics
			project.AllStatisticsData.TotalNoteCount += currStatistic.NoteCount;
		}

		private static int IndexToLine(string text, int index, int lastIndex)
		{
			var line = 0;
			for (var i = lastIndex; i < text.Length && i < index; ++i)
				if (text[i] == '\n')
					++line;
			return line;
		}

		private static void AddToRecents(string item, ref string[] recentItems, int itemLimit)
		{
			var recentlist = new List<string>(recentItems);

			var comparer = new PathComparer();
			var index = 0;
			for (; index < recentlist.Count; ++index)
			{
				if (comparer.Equals(recentlist[index], item))
					break;
			}

			if (index >= recentlist.Count)
				recentlist.Insert(0, item);
			else
			{
				recentlist.RemoveAt(index);
				recentlist.Insert(0, item);
			}

			recentItems = recentlist.GetRange(0, Math.Min(recentlist.Count, itemLimit)).ToArray();
		}

		public void UpdateCurrentView(Project2 project)
		{
			if (Owner.IsDisposed || IsUpdatingView)
				return;
			IsUpdatingView = true;

			var filterTags = bool.Parse(project.Settings.FilterTags);
			if (project.Settings.TagFilter == null)
				filterTags = false;

			lock (project.AutoLock)
			{
				if (project.Page.CurrentMode == ViewMode.ListView)
				{
					var listView = project.Page.CurrentView as DataGridView;
#if DEBUG
					Debug.Assert(listView != null);
#else
					if (listView == null)
					{
						IsUpdatingView = false;
						return;
					}
#endif
					listView.Rows.Clear();

					if (filterTags)
					{
						foreach (var note in project.Notes.Where(note => !project.Settings.TagFilter.Contains(note.Tag)))
							AddToList(listView, note);
					}
					else
					{
						foreach (var note in project.Notes)
							AddToList(listView, note);
					}

					// try and select the first note, unless a note is already selected
					if (project.Page.CurrentNote == null)
						project.Page.CurrentNote = listView.CurrentCell == null
							? (listView.Rows.Count > 0 ? (Note)listView.Rows[0].Tag : null)
							: (Note)listView.CurrentCell.OwningRow.Tag;
				}
				else
				{
					var treeView = project.Page.CurrentView as TreeView;
#if DEBUG
					Debug.Assert(treeView != null);
#else
					if (treeView == null)
					{
						IsUpdatingView = false;
						return;
					}
#endif
					var startindex = project.Settings.LastSearchPath.Length + 1; // + 1 to skip the last backslash
					treeView.Nodes.Clear();
					treeView.Nodes.Add(GetFolderName(project.Settings.LastSearchPath));
					var curr = treeView.Nodes[0];
					curr.ToolTipText = @"Found: " + project.Notes.Count;

					if (filterTags)
					{
						foreach (var note in project.Notes.Where(note => !project.Settings.TagFilter.Contains(note.Tag)))
							AddToTree(note, curr, startindex);
					}
					else
					{
						foreach (var note in project.Notes)
							AddToTree(note, curr, startindex);
					}

					treeView.ExpandAll();

					// try and select the first note, unless a note is already selected
					if (project.Page.CurrentNote == null)
					{
						if (treeView.SelectedNode != null)
							project.Page.CurrentNote = (Note)treeView.SelectedNode.Tag;
						else if (treeView.Nodes[0].Nodes.Count > 0)
						{
							var currnode = treeView.Nodes[0].Nodes[0];
							while (currnode.Nodes.Count > 0)
								currnode = currnode.Nodes[0];
							project.Page.CurrentNote = (Note)currnode.Tag;
						}
					}
				}
			}

			IsUpdatingView = false;
		}

		private static void AddToList(DataGridView view, Note note)
		{
			view.Rows.Add(note.FileName, note.Line, note.Tag.ToUpper(), note.Message);
			view.Rows[view.Rows.Count - 1].Tag = note;
		}

		private static void AddToTree(Note note, TreeNode currNode, int startPathIndex) /** TODO(note) maybe there could be some colour coding for this */
		{
			var path = note.FilePath.Substring(startPathIndex);
			var splitpath = path.Split('\\');
			foreach (var t in splitpath)
			{
				var oldnode = currNode;
				var pathname = t;
				foreach (var child in currNode.Nodes.Cast<object>().Where(child => ((TreeNode)child).Text == pathname))
				{
					currNode = (TreeNode)child;
					break;
				}
				if (oldnode != currNode) 
					continue;
				var node = new TreeNode(t); // if there wasnt a folder with that name, then its the first and should be created
				currNode.Nodes.Add(node);
				currNode = node;
			}

			var notenode = new TreeNode(note.Message)
			{
				ToolTipText = "(line " + note.Line + ")" + (note.Tag.Length > 0 ? (" [" + note.Tag.ToUpper() + "]") : ""),
				Tag = note
			};
			currNode.Nodes.Add(notenode);
			currNode.ToolTipText = "Found: " + currNode.Nodes.Count;
		}

		public void OpenPreviewDialog(Project2 project)
		{
			if (project.Page.CurrentNote == null)
				return;

			var dialog = new PreviewDialog
			{
				LineCount = int.Parse(project.Settings.PreviewLineCount),
				NotePreview = project.Page.CurrentNote
			};
			dialog.OpenClicked += (sender, args) => RunEditor(project);
			dialog.RemoveClicked += (sender, args) => RemoveNoteFromSource(project);

			dialog.ShowDialog(Owner);
		}

		public void RunEditor(Project2 project)
		{
			if (project.Page.CurrentNote == null)
				return;

			if (string.IsNullOrEmpty(project.Settings.Editor))
			{
				MessageBox.Show(Owner, @"Please select an editor in the options window.", @"Edit Externally", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				return;
			}

			var args = project.Settings.EditorArgs; /** TODO(performance) could make 1 pass through the args instead of each one individually */
			args = args.Replace("%l", "" + project.Page.CurrentNote.Line);
			args = args.Replace("%f", project.Page.CurrentNote.FileName);
			args = args.Replace("%p", project.Page.CurrentNote.FilePath);
			args = args.Replace("%t", project.Page.CurrentNote.Tag);
			args = args.Replace("%m", project.Page.CurrentNote.Message);
			var process = new ProcessStartInfo(project.Settings.Editor, args)
			{
				UseShellExecute = true
			};
			Process.Start(process);
		}

		public void RemoveNoteFromSource(Project2 project)
		{
			var page = project.Page;
			if (page.CurrentNote == null)
				return;

			// chop the message down to a much more manageable number of chars
			const int totalchars = 80;
			var shortened = page.CurrentNote.Message;
			var endlineindex = shortened.IndexOf(Environment.NewLine, StringComparison.Ordinal);
			if (endlineindex >= 0)
				shortened = shortened.Substring(0, endlineindex);
			shortened = shortened.Substring(0, Math.Min(shortened.Length, totalchars));

			var result = MessageBox.Show(Owner,
				@"Are you sure you would like to delete this note:" + '\n' + @"File: " + page.CurrentNote.FileName + '\n' + @"Line: " + 
				page.CurrentNote.Line + '\n' + shortened + @"...",
				@"Remove Note", MessageBoxButtons.YesNo);
			if (result != DialogResult.Yes)
				return;

			if (bool.Parse(project.Settings.DeleteFromSource) && File.Exists(page.CurrentNote.FilePath))
			{
				var filetext = File.ReadAllText(page.CurrentNote.FilePath);
				filetext = filetext.Replace(page.CurrentNote.All, ""); // the file may have changed before delete, so instead of removing by index, replace
				File.WriteAllText(page.CurrentNote.FilePath, filetext);
			}


			lock (project.AutoLock)
			{
				if (page.CurrentMode == ViewMode.ListView)
				{
					var listView = (DataGridView)page.CurrentView;
					project.Notes.RemoveAt(listView.CurrentCell.RowIndex);
					listView.Rows.RemoveAt(listView.CurrentCell.RowIndex);
				}
				else
				{
					var treeView = (TreeView)page.CurrentView;
					project.Notes.Remove(page.CurrentNote);
					if (treeView.SelectedNode.Parent != null)
						treeView.SelectedNode.Parent.Nodes.Remove(treeView.SelectedNode);
					else
						treeView.Nodes.Remove(treeView.SelectedNode);
				}
			}
			page.CurrentNote = null;
		}

		public void DisplayOptionsWindow(Project2 project)
		{
			var optionswindow = new OptionsWindow();
			optionswindow.InitialiseSettings(CreateDefaultSettings(), project.Settings, project.Tags.ToList(), _updateAvailable);
			optionswindow.ReplaceClicked += (sender, args) =>
			{
				var dialog = new ReplaceNotesDialog();
				var result = dialog.ShowDialog(Owner);

				if (result != DialogResult.Yes)
					return;

				var oldStart = dialog.NoteStart.Trim();
				var oldEnd = dialog.NoteEnd.Trim();
				if (oldStart.Trim().Length <= 0 || oldEnd.Trim().Length <= 0)
				{
					MessageBox.Show(Owner, @"Please enter valid start and end sections for the notes that are to be replaced.", @"Replace Old Notes", 
						MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				var newStart = args.NoteOpen.Trim();
				var newEnd = args.NoteClose.Trim();
				if (newStart.Trim().Length <= 0 || newEnd.Trim().Length <= 0)
				{
					MessageBox.Show(Owner, @"Please enter valid start and end sections for the replacement notes.", @"Replace Old Notes", 
						MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}

				ReplaceOldNotes(project.Notes, oldStart, oldEnd, newStart, newEnd);
			};
#if false
			optionswindow.UpdateClicked += (sender, args) => /** TODO((refactor) this will go where the App Settings Window being opened will go */
			{
				CheckForUpdates(true, true, true);
				args.UpdateFound = _updateAvailable;
			};
#endif
			optionswindow.Closed += (sender, args) =>
			{
				project.Settings = optionswindow.RetrieveSettings();
#if false
				var lastproject = "";
				if (CurrentProject == DefaultProject)
					lastproject = DefaultProject.LastProject;
				var lastsearchpath = CurrentProject.LastSearchPath;
				var defaultproject = DefaultProject;
				CurrentProject = optionswindow.RetrieveSettings(ref defaultproject);
				DefaultProject = defaultproject;
				CurrentProject.LastSearchPath = lastsearchpath;
				if (CurrentProject == DefaultProject)
					DefaultProject.LastProject = lastproject;
				ResetAutoTimer();
#endif
			};
			optionswindow.Show(Owner);
		}

		private static void ReplaceOldNotes(IEnumerable<Note> notes, string oldStart, string oldEnd, string newStart, string newEnd)
		{
			/** TODO(incomplete) this replaces a specific style with another. should it just replace each currently found note style with the new one instead? */
			/** TODO(incomplete) this should also create a backup of the file before replacing, and if something goes wrong, revert to the backup */
			// collect all files used and the line numbers that their notes appear on, and the line numbers that their notes end on
			var files = new Dictionary<string, List<int>>();
			foreach (var note in notes)
			{
				var linenumber = note.Line - 1;
				var linecount = note.All.Count(c => c == '\n');
				if (!files.ContainsKey(note.FilePath))
				{
					files.Add(note.FilePath, new List<int> { linenumber, linenumber + linecount });
					continue;
				}
				files[note.FilePath].Add(linenumber);
				files[note.FilePath].Add(linenumber + linecount);
			}

			foreach (var pair in files)
			{
				if (!File.Exists(pair.Key))
					continue;
				var lines = File.ReadAllLines(pair.Key);
				var linenumbers = pair.Value;
				for (var i = 0; i < linenumbers.Count; i += 2)
				{
					lines[linenumbers[i]] = lines[linenumbers[i]].Replace(oldStart, newStart);
					lines[linenumbers[i + 1]] = lines[linenumbers[i + 1]].Replace(oldEnd, newEnd);
				}
				File.WriteAllLines(pair.Key, lines);
			}
		}

		public void ShowHelpWindow()
		{
			var helpwindow = new HelpWindow
			{
				IndexPath = HelpDirectory + '\\' + HelpIndexFileName
			};
			helpwindow.Show(Owner);
		}

		public void ShowAboutDialog()
		{
			var dialog = new AboutDialog
			{
				Message = '\n' + GlobalVars.ApplicationTitle + "\nby Callum Nichols " + 'Ⓒ' + " 2015\n\nVersion " + GlobalVars.ApplicationVersion,
				LicensePath = LicenseFileName
			};
			dialog.ShowDialog(Owner);
		}

		private void ShowViewMenu(Point location, Project2 project)
		{
			var menu = new ContextMenuStrip();
			var previewItem = new ToolStripMenuItem("Preview");
			var editItem = new ToolStripMenuItem("Edit");
			var deleteItem = new ToolStripMenuItem("Delete");

			previewItem.Click += (sender, args) => OpenPreviewDialog(project);
			editItem.Click += (sender, args) => RunEditor(project);
			deleteItem.Click += (sender, args) => RemoveNoteFromSource(project);

			menu.Items.Add(previewItem);
			menu.Items.Add(editItem);
			menu.Items.Add(deleteItem);

			menu.Show(location);
		}
	}
}
