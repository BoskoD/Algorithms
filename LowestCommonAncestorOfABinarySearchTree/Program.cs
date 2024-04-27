namespace LowestCommonAncestorOfABinarySearchTree
{
    internal class Program // Tree, DFS, Binary Search Tree, Binary Tree
    {
        static void Main(string[] args)
        {
            var root = new TreeNode(6)
            {
                left = new TreeNode(2),
                right = new TreeNode(8)
            };

            // Left subtree
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);
            root.left.right.left = new TreeNode(3);
            root.left.right.right = new TreeNode(5);
            // Right subtree
            root.right.left = new TreeNode(7);
            root.right.left = new TreeNode(9);

            var p = new TreeNode(2);
            var q = new TreeNode(4);

            var result = LCA(root, p, q);
            Console.WriteLine(result.val);
        }

        static TreeNode LCA(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p.val > root.val && q.val > root.val) return LCA(root.right, p, q);
            if (p.val < root.val && q.val < root.val) return LCA(root.left, p, q);
            return root;
        }
    }

    internal class TreeNode(int val, TreeNode left = null, TreeNode right = null)
    {
        public int val = val;
        public TreeNode left = left;
        public TreeNode right = right;
    }
}
