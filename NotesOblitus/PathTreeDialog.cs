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
	}
}
