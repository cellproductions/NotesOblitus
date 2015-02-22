using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NotesOblitus
{
	class OptionsWindowManager
	{
		public class MacroDisplay
		{
			public string DisplayText { get; set; }
			public string Macro { get; set; }

			public override string ToString()
			{
				return DisplayText;
			}
		}

		public OptionsWindow Owner { get; internal set; }
		public Dictionary<string, string> Macros { get; internal set; }
		public string RootSearchPath { get; set; }
		public List<string> FilteredPaths { get; set; }
		public string[] AcceptedTypes { get; set; }

		public OptionsWindowManager(OptionsWindow owner)
		{
			Owner = owner;
			Macros = new Dictionary<string, string>
			{ 
				{ "Line Number", "%l" },
				{ "File Name", "%f" },
				{ "File Path", "%p" },
				{ "Tag", "%t" },
				{ "Message", "%m" }
			};
			FilteredPaths = new List<string>();
		}

		public void SetPreviewEditorTarget(TextBox editorBox)
		{
			var dialog = new OpenFileDialog
			{
				CheckFileExists = true,
				CheckPathExists = true,
				InitialDirectory = !string.IsNullOrEmpty(editorBox.Text) ? GetFilesPath(editorBox.Text) : "",
				Title = @"Editor Selection",
				Filter = @"Executable files (*.exe)|*.exe"
			};

			if (dialog.ShowDialog(Owner) != DialogResult.OK)
				return;

			editorBox.Text = dialog.FileName;
		}

		private static string GetFilesPath(string filePath)
		{
			if (string.IsNullOrEmpty(filePath))
				return null;
			var index = filePath.LastIndexOf('\\');
			return index >= 0 && index + 1 < filePath.Length ? filePath.Substring(0, index) : filePath;
		}

		public void InsertMacro(TextBox argsBox, MacroDisplay selectedMacro)
		{
#if DEBUG
			Debug.Assert(selectedMacro != null);
#endif
			argsBox.Text = argsBox.Text.Insert(argsBox.SelectionStart, selectedMacro.Macro);
		}

		public void SetupAndDisplayPaths(int depth)
		{
			var rootpath = NotesOblitusManager.GetFolderName(RootSearchPath);
			if (string.IsNullOrEmpty(rootpath))
				return;

			var comparer = new NotesOblitusManager.PathComparer();
			var root = CreateNode(rootpath, RootSearchPath, !FilteredPaths.Contains(RootSearchPath, comparer));
			root.Toggle();

			SetupPaths(root, depth, comparer);

			var dialog = new PathTreeDialog
			{
				Text = @"Path Filter",
				RootNode = root
			};

			if (dialog.ShowDialog(Owner) != DialogResult.OK)
				return;

			FilteredPaths = CollectUncheckPaths(root, dialog.GetTotalNodeCount());
		}

		private void SetupPaths(TreeNode root, int depth, NotesOblitusManager.PathComparer comparer)
		{
			var currnodes = new List<TreeNode> { root };
			for (var i = 0; i < depth; ++i)
			{
				var nodes = new List<TreeNode>();
				foreach (var node in currnodes)
				{
#if DEBUG
					Debug.Assert(node != null);
#endif
					var path = node.Tag as string;
					if (path == null || !Directory.Exists(path))
						continue;
					var files = (from file in Directory.EnumerateFiles(path) 
								 let index = file.LastIndexOf('.') 
								 where index >= 0 && index < file.Length - 1 && AcceptedTypes.Contains(file.Substring(index + 1)) 
								 select file).ToList();
					var directories = Directory.EnumerateDirectories(path);
					foreach (var file in files)
						node.Nodes.Add(CreateNode(file.Substring(RootSearchPath.LastIndexOf('\\') + 1), file, !FilteredPaths.Contains(file, comparer)));
					foreach (var directory in directories)
					{
						var n = CreateNode(directory.Substring(RootSearchPath.LastIndexOf('\\') + 1), directory, !FilteredPaths.Contains(directory, comparer));
						node.Nodes.Add(n);
						if (Directory.Exists(directory))
							nodes.Add(n);
					}
				}
				currnodes.Clear();
				currnodes.AddRange(nodes);
			}
		}

		private static TreeNode CreateNode(string text, string tag, bool check)
		{
			return new TreeNode(text)
			{
				Tag = tag,
				Checked = check
			};
		}

		private static List<string> CollectUncheckPaths(TreeNode root, int totalNodes)
		{
			var nodes = new List<string>(totalNodes);
			CollectUnchecked(root, nodes);
			return nodes;
		}

		private static void CollectUnchecked(TreeNode currentNode, ICollection<string> nodes)
		{
			if (!currentNode.Checked)
				nodes.Add(currentNode.Tag as string);
			if (currentNode.Nodes.Count <= 0) 
				return;
			foreach (var node in currentNode.Nodes)
				CollectUnchecked(node as TreeNode, nodes);
		}
	}
}
