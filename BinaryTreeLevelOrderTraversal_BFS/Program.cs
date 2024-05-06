namespace BinaryTreeLevelOrderTraversal_BFS
{
    public class Program // Tree, Breadth-First Search, Binary Tree
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

            IList<IList<int>> result = BFS(root);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine($"Level {i}:");
                foreach (int num in result[i])
                {
                    Console.WriteLine(num);
                }
            }
        }

        public static IList<IList<int>> BFS(TreeNode root)
        {
            var result = new List<IList<int>>();
            if(root == null) return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (true)
            {
                int currentNodeCount = queue.Count;
                var currentLevel = new List<int>();

                if(currentNodeCount == 0) break;
                while (currentNodeCount > 0)
                {
                    TreeNode currentNode = queue.Dequeue();
                    currentLevel.Add(currentNode.val);
                    if(currentNode.left != null) queue.Enqueue(currentNode.left);
                    if(currentNode.right != null) queue.Enqueue(currentNode.right);
                    currentNodeCount--;
                }
                result.Add(currentLevel);
            }
            return result;
        }
    }

    public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        public int val = val;
        public TreeNode left = left;
        public TreeNode right = right;
    }
}
