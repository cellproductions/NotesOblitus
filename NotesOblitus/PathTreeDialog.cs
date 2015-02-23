using System.Windows.Forms;

namespace NotesOblitus
{
	public partial class PathTreeDialog : Form
	{
		public TreeNode RootNode { get; set; }

		public PathTreeDialog()
		{
			InitializeComponent();
			Shown += (sender, args) => { if (RootNode != null) tvPaths.Nodes.Add(RootNode); };
		}

		public int GetTotalNodeCount()
		{
			return tvPaths.GetNodeCount(true);
		}

		private void tvPaths_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Button != MouseButtons.Right)
				return;

			UncheckNodes(e.Node, !e.Node.Checked);
			e.Node.ExpandAll();
		}

		private static void UncheckNodes(TreeNode currentNode, bool check)
		{
			currentNode.Checked = check;
			if (currentNode.Nodes.Count <= 0)
				return;
			foreach (var node in currentNode.Nodes)
				UncheckNodes(node as TreeNode, check);
		}
	}
}
