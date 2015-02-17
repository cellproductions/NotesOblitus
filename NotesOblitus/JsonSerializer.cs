using System;
using System.Diagnostics;
using System.IO;

namespace NotesOblitus
{
	class JsonSerializer
	{
#if false
		private const char OpenObject = '{';
		private const char CloseObject = '}';
		private const char OpenArray = '[';
		private const char CloseArray = ']';
		private const char Variable = '"';
		private const char Separator = ':';
		private const char Comma = ',';
		private const char ControlChar = '\\';

		public class JsonException : Exception
		{
			public JsonException()
			{
			}

			public JsonException(string message)
				: base(message)
			{
			}
		}

		private enum State
		{
			Object,
			Array,
			Pair,
			None
		}

		public static T DeserializeObject<T>(string filePath)
		{
			var objecttype = typeof(T);
			if (objecttype.GetConstructor(Type.EmptyTypes) == null)
				throw new JsonException("Type T has no default constructor! [type=" + objecttype.Name + ']');

			var source = File.ReadAllText(filePath).Trim();
			if (source[0] != OpenObject || source[source.Length - 1] != CloseObject)
				throw new JsonException("Invalid Json file! [filepath=" + filePath + ']');

			var instance = (T)Activator.CreateInstance(objecttype);

			var currstate = State.None;
			var length = source.Length - 1; // skip past the end brace
			var index = 1; // skip past the opening bace
			while (index < length)
			{
				index = NextToken(source, index);

				switch (source[index])
				{
					case OpenObject:
						break;
					case CloseObject:
						break;
					case OpenArray:
						break;
					case CloseArray:
						break;
					case Variable:
						var varname = "";
						while (source[index] != Variable)
						{
							if (source[index - 1] == ControlChar)
								continue;
							varname += source[++index];
						}
						index = NextToken(source, index);
						if (source[index] != Separator)
							throw new JsonException("Invalid Json file! Missing : separator. [index= " + index + ", filepath=" + filePath + ']');
						index += 1;
						var value = ReadNextToken(source, ref index);

						var field = objecttype.GetField(varname);
						if (field != null)
						{
							field.SetValue(instance, value);
						}
						else
						{
							var property = objecttype.GetProperty(varname);
							if (property != null)
							{
								
							}
						}

						break;
					case Separator:
						break;
					case Comma:
						break;
				}

				index += stride;
			}
		}

		private static string ReadNextToken(string source, ref int currIndex)
		{
			currIndex = NextToken(source, currIndex);
			var token = "";
			while (!IsWhiteSpace(source[currIndex]))
				token += source[currIndex++];
			return token;
		}

		private static int NextToken(string source, int currIndex)
		{
			while (IsWhiteSpace(source[currIndex]))
				currIndex += 1;
			return currIndex;
		}

		private static bool IsWhiteSpace(char c)
		{
			return c == ' ' || c == '\r' || c == '\n' || c == '\t' || c == '\0';
		}

		public static string SerializeObject(object toSerialize) // serializes with formatting automatically
		{
			
		}
#endif
	}
}
