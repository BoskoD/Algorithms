namespace DiameterOfABinaryTree
{
    internal class Program // Tree, DFS, Binary Tree
    {
        public int result = -1; 

        static void Main(string[] args)
        {
            var root = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            };
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            var program = new Program();
            int result = program.DiameterOfBinaryTree(root);
            Console.WriteLine($"Diameter of a binary tree is {result}");
        }

        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return -1;
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

            int left = 1 + this.Dfs(root.left);
            int right = 1 + this.Dfs(root.right);
            this.result = Math.Max(this.result, (left + right));
            return Math.Max(left, right);
        }
    }

    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode left = left;
        public TreeNode right = right;
    }
}
