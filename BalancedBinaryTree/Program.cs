namespace BalancedBinaryTree
{
    internal class Program // Tree, DFS, Binary Tree
    {
        public bool result = true;

        static void Main(string[] args)
        {
            var root = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
            };
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            bool isBalancedTree = new Program().IsBalanced(root);
            Console.WriteLine($"Tree is balanced: {isBalancedTree}");
        }

        private bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            _ = this.Dfs(root);
            return this.result;
        }

        private int Dfs(TreeNode root)
        {
            if (root == null)
            {
                return -1;
            }

            int leftDepth = this.Dfs(root.left);
            int rightDepth = this.Dfs(root.right);

            this.result = this.result && Math.Abs(rightDepth - leftDepth) <= 1;
            return Math.Max(leftDepth, rightDepth) + 1;
        }
    }

    internal class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        #pragma warning disable CS8601 // Possible null reference assignment.
        public TreeNode left = left;
        #pragma warning disable CS8601 // Possible null reference assignment.
        public TreeNode right = right;
    }
}
