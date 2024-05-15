namespace BinaryTreeRightSideView
{
    internal class Program // Tree, DFS, BFS, Binary Tree
    {
        public List<int> result = [];

        static void Main(string[] args)
        {
            var root = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    right = new TreeNode(5)
                },
                right = new TreeNode(3)
                {
                    right = new TreeNode(4)
                }
            };

            var pg = new Program();
            List<int> result = pg.RightSideView(root);
            foreach (int val in result)
            {
                Console.WriteLine(val);
            }
        }

        public List<int> RightSideView(TreeNode root)
        {
            this.Dfs(root, 0);
            return this.result;
        }

        public void Dfs(TreeNode root, int level)
        {
            if (root == null)
            {
                return;
            }

            if (level >= this.result.Count)
            {
                this.result.Add(root.val);
            }

            this.Dfs(root.right, level + 1);
            this.Dfs(root.left, level + 1);
        }
    }

    internal class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode left = left;
        public TreeNode right = right;
    }
}
