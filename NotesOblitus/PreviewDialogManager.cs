using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NotesOblitus
{
	internal struct SyntaxFile
	{
		public struct SyntaxColours
		{
			public string Keywords { get; set; }
			public string Number { get; set; }
			public string String { get; set; }
			public string Comment { get; set; }
		}

		public SyntaxColours Syntax { get; set; }
		public string[] Keywords { get; set; }
	}

	public class PreviewDialogManager
	{
		private static readonly Regex NumberRegex = new Regex("[^\\D]?\\d+[ulLfUF]?", RegexOptions.Compiled);
		private static readonly Regex StringRegex = new Regex("([\"\"'])(?:(?=(\\\\?))\\2.)*?\\1", RegexOptions.Compiled);
		private static readonly Regex CommentLineRegex = new Regex("//(.*?)\r?\n", RegexOptions.Compiled);
		private static readonly Regex CommentBlockRegex = new Regex("(/\\*([^*]|[\r\n]|(\\*+([^*/]|[\r\n])))*\\*+/)", RegexOptions.Compiled | RegexOptions.Multiline);

		public List<string> Keywords { get; internal set; }
		public Color KeywordColor { get; internal set; }
		public Color NumberColor { get; internal set; }
		public Color StringColor { get; internal set; }
		public Color CommentColor { get; internal set; }

		public PreviewDialogManager()
		{
			Keywords = new List<string>();
			KeywordColor = Color.Blue;
			NumberColor = Color.Red;
			StringColor = Color.Brown;
			CommentColor = Color.Green;
		}

		public void ReadSyntaxFile(string path)
		{
			var file = JsonConvert.DeserializeObject<SyntaxFile>(File.ReadAllText(path));
			KeywordColor = CheckAndGetColour(file.Syntax.Keywords);
			NumberColor = CheckAndGetColour(file.Syntax.Number);
			StringColor = CheckAndGetColour(file.Syntax.String);
			CommentColor = CheckAndGetColour(file.Syntax.Comment);
			if (file.Keywords != null)
				Keywords.AddRange(file.Keywords);
		}

		private static Color CheckAndGetColour(string name)
		{
			if (string.IsNullOrEmpty(name))
				return Color.Black;
			var colour = Color.FromName(name);
			return colour.A == 0 ? Color.Black : colour;
		}

		public void GetPreviewTextAndLine(Note note, int linecount, out string previewText, out int startLine)
		{
			var line = 1;
			previewText = "";
			using (var reader = new StreamReader(note.FilePath))
			{
				if (linecount == -1)
				{
					line = startLine = 1;
					while (!reader.EndOfStream)
					{
						previewText += reader.ReadLine() + '\n';
						++line;
					}
				}
				else
				{
					if (note.Line >= linecount)
					{
						while (line < note.Line - linecount)
						{
							reader.ReadLine();
							++line;
						}
					}
					startLine = line;
					while (line++ <= note.Line)
						previewText += reader.ReadLine() + '\n';
					while (!reader.EndOfStream && line++ < note.Line + linecount)
						previewText += reader.ReadLine() + '\n';
				}
			}
		}

		public void SetLineNumbers(RichTextBox previewBox, RichTextBox lineBox, int startLine)
		{
			lineBox.Text = "";
			var len = previewBox.Lines.Length;
			while (len-- > 0)
				lineBox.AppendText("" + startLine++ + Environment.NewLine); // update lines text box
			lineBox.SelectAll();
			lineBox.SelectionAlignment = HorizontalAlignment.Right;
		}

		public void ApplySyntaxColouring(RichTextBox textBox, Note note)
		{
			if (Keywords.Count > 0)
			{
				var keywordregex = Keywords.Aggregate("", (current, keyword) => current + ('(' + keyword + ")|"));
				keywordregex = keywordregex.Substring(0, keywordregex.Length - 1);
				ColourAllMatches(textBox, Regex.Matches(textBox.Text, keywordregex), KeywordColor);
			}

			ColourAllMatches(textBox, NumberRegex.Matches(textBox.Text), NumberColor);
			ColourAllMatches(textBox, StringRegex.Matches(textBox.Text), StringColor);
			ColourAllMatches(textBox, CommentLineRegex.Matches(textBox.Text), CommentColor);
			ColourAllMatches(textBox, CommentBlockRegex.Matches(textBox.Text), CommentColor);

			var startindex = textBox.Text.IndexOf(note.All.Replace("\r", ""), StringComparison.Ordinal);
			if (startindex != -1)
				SetTextBackColour(textBox, startindex, note.All.Length, Color.DarkGray);
		}

		public void ColourAllMatches(RichTextBox textBox, MatchCollection matches, Color colour)
		{
			foreach (Match match in matches)
				SetTextColour(textBox, match.Index, match.Length, colour);
		}

		public static void SetTextColour(RichTextBox textBox, int textIndex, int selectionLength, Color colour)
		{
			textBox.SelectionStart = textIndex;
			textBox.SelectionLength = selectionLength;
			textBox.SelectionColor = colour;
		}

		public static void SetTextBackColour(RichTextBox textBox, int textIndex, int selectionLength, Color colour)
		{
			textBox.SelectionStart = textIndex;
			textBox.SelectionLength = selectionLength;
			textBox.SelectionBackColor = colour;
		}
	}
}
