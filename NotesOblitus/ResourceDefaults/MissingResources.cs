namespace NotesOblitus.ResourceDefaults
{
	static partial class MissingResources
	{
		public static string GetSyntaxFileAsString()
		{
			return GetSyntaxJson();
		}

		public static string GetLicenseFileAsString()
		{
			return GetLicenseTxt();
		}

		public static string GetDefaultPrjAsString()
		{
			return GetDefaultPrj();
		}
	}
}
