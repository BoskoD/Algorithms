namespace MaximumDepthOfBinaryTree
{
    internal class Program // Tree, DFS, BFS, Binary Tree
    {
        static void Main(string[] args)
        {
            var root = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
            };
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            int resultDFSRecursively = MaxDepthDFSRecursion(root);
            int resultBFSLelvelOrder = MaxDepthBFSLevelOrder(root);
            Console.WriteLine($"DFS recursion result: {resultDFSRecursively}\n");
            Console.WriteLine($"BFS level order traversal result: {resultBFSLelvelOrder}\n");
        }

        public static int MaxDepthDFSRecursion(TreeNode root)
        {
            return root == null ? 0 : 1 + Math.Max(MaxDepthDFSRecursion(root.left), MaxDepthDFSRecursion(root.right));
        }

        public static int MaxDepthBFSLevelOrder(TreeNode root)
        {
            if (root == null) { return 0;}
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int currentLevel = 0;

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                for (int i = 0; i < levelSize; i++)
                {
                    var currentNode = queue.Dequeue();
                    if (currentNode.left != null) { queue.Enqueue(currentNode.left); }
                    if (currentNode.right != null) { queue.Enqueue(currentNode.right); }

                }
                currentLevel++;
            }
            return currentLevel;
        }
    }

    public class TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        public int val = val;
        public TreeNode left = left;
        public TreeNode right = right;
    }
}
