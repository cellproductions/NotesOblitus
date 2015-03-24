using NotesOblitus.Controls;

namespace NotesOblitus
{
	public class Project2
	{
		public ProjectSettings Settings { get; internal set; }
		public ProjectPage Control { get; internal set; }

		public Project2(ProjectSettings settings, ProjectPage view)
		{
			Settings = settings;
			Control = view;
		}
	}
}
