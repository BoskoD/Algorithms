namespace SubtreeOfAnotherTree
{
    internal class Program // Tree, DFS, Binary Tree
    {
        static void Main(string[] args)
        {
            var root = new TreeNode(3)
            {
                left = new TreeNode(4)
            };
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(2);
            root.right = new TreeNode(5);

            var subRoot = new TreeNode(4)
            {
                left = new TreeNode(1),
                right = new TreeNode(2)
            };

            bool result = IsSubTree(root, subRoot);
            Console.WriteLine(result);
        }

        public static bool IsSubTree(TreeNode root, TreeNode subRoot)
        {
            if (root == null)
            {
                return root == subRoot;
            }

            return (root.val == subRoot.val && SameTree(root, subRoot)) || IsSubTree(root.left, subRoot) || IsSubTree(root.right, subRoot);
        }

        public static bool SameTree(TreeNode root, TreeNode subRoot)
        {
            if (root == null && subRoot == null)
            {
                return root == subRoot;
            }

            if(root != null && subRoot != null && root.val == subRoot.val)
            {
                return SameTree(root.left, subRoot.left) && SameTree(root.right, subRoot.right);
            }
            return false;
        }
    }
    
    internal class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        public int val = val;
        public TreeNode left = left;
        public TreeNode right = right;
    }
}
