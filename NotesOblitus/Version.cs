using System;

namespace NotesOblitus
{
	public class Version : IComparable<Version>
	{
		public int Major { get; internal set; }
		public int Minor { get; internal set; }
		public int Build { get; internal set; }

		public int CompareTo(Version other)
		{
			return Major < other.Major
				? -1
				: (Major > other.Major
					? 1
					: (Minor < other.Minor
						? -1
						: (Minor > other.Minor
							? 1
							: Build < other.Build ? -1 : Build > other.Build ? 1 : 0)));
		}

		public override string ToString()
		{
			return Major.ToString() + '.' + Minor + '.' + Build;
		}

		public static Version Parse(string value)
		{
			var parts = value.Split('.');
			return new Version { Major = int.Parse(parts[0]), Minor = int.Parse(parts[1]), Build = int.Parse(parts[2]) };
		}
	}
}
