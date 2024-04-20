namespace SameTree
{
    internal class Program // Tree, DFS, BFS, Binary Tree
    {
        static void Main(string[] args)
        {
            var root1 = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            };

            var root2 = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            };

            bool sameTrees = SameTreeCheck(root1, root2);
            Console.WriteLine($"Trees are the same? {sameTrees}");
        }

        public static bool SameTreeCheck(TreeNode root1, TreeNode root2)
        {
            return root1 == null && root2 == null
                 ? root1 == root2
                 : root1.val == root2.val && 
                 SameTreeCheck(root1.left, root2.left) && 
                 SameTreeCheck(root1.right, root2.right);
        }
    }

    internal class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode left = left;
        public TreeNode right = right;
    }
}
