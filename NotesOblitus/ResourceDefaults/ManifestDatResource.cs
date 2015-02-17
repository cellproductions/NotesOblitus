using Global;

namespace NotesOblitus.ResourceDefaults
{
	static partial class MissingResources
	{
		private static string GetManifestDat()
		{
			return "" +
				"Application:" + GlobalVars.ApplicationVersion + '\n' +
				"Manifest:" + GlobalVars.ManifestBuilderVersion + '\n' +
				"Updater:" + GlobalVars.PatcherVersion + '\n';
		}
	}
}
