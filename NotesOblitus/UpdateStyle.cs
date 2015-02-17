using System;

namespace NotesOblitus
{
	public enum UpdateStyle
	{
		Auto,
		Notify,
		None
	}

	public static class UpdateStyleExtensions
	{
		public static UpdateStyle Parse(this UpdateStyle style, string updateStyle)
		{
			UpdateStyle result;
			if (Enum.TryParse(updateStyle, true, out result))
				return result;

			updateStyle = updateStyle.Trim();
			switch (updateStyle)
			{
				case "0": return UpdateStyle.Auto;
				case "1": return UpdateStyle.Notify;
				case "2": return UpdateStyle.None;
			}

			throw new Exception("Invalid UpdateStyle value! [value=" + updateStyle + ']');
		}

		public static UpdateStyle Parse(string updateStyle)
		{
			UpdateStyle result;
			if (Enum.TryParse(updateStyle, true, out result))
				return result;

			updateStyle = updateStyle.Trim();
			switch (updateStyle)
			{
				case "0": return UpdateStyle.Auto;
				case "1": return UpdateStyle.Notify;
				case "2": return UpdateStyle.None;
			}

			throw new Exception("Invalid UpdateStyle value! [value=" + updateStyle + ']');
		}

		public static UpdateStyle FromInt(this UpdateStyle style, int value)
		{
			switch (value)
			{
				case 0: return UpdateStyle.Auto;
				case 1: return UpdateStyle.Notify;
				case 2: return UpdateStyle.None;
				default:
					throw new Exception("Invalid UpdateStyle value! [value=" + value + ']');
			}
		}

		public static UpdateStyle FromInt(int value)
		{
			switch (value)
			{
				case 0: return UpdateStyle.Auto;
				case 1: return UpdateStyle.Notify;
				case 2: return UpdateStyle.None;
				default:
					throw new Exception("Invalid UpdateStyle value! [value=" + value + ']');
			}
		}
	}
}
