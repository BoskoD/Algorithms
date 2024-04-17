using System.Collections.Generic;

namespace InvertBinaryTree
{
    internal class Program // Tree, DFS, BFS, Binary Tree
    {
        static void Main(string[] args)
        {
            //         4
            //       /   \
            //      2     7
            //     / \   / \
            //    1   3 6   9

            var root = new TreeNode(4)
            {
                left = new TreeNode(2),
                right = new TreeNode(7)
            };

            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);

            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(9);

            TreeNode result = InvertTree(root);
            PrintTree(result);

            Console.WriteLine($"Right node from root: {result.right.val}\n" +
                              $"Left node from root: {result.left.val}\n");
        }

        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null) { return null; }

            var temp = root.left;
            root.left = root.right;
            root.right = temp;

            _ = InvertTree(root.left);
            _ = InvertTree(root.right);

            return root;
        }

        public static void PrintTree(TreeNode root)
        {
            if (root == null) { return; }
            
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelCount = queue.Count;
                while (levelCount-- > 0)
                {
                    TreeNode current = queue.Dequeue();
                    Console.Write(string.Concat(current.val, ","));
                    if (current.left != null) { queue.Enqueue(current.left); }
                    if (current.right != null) { queue.Enqueue(current.right); }
                }
            }
            Console.WriteLine();
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode righ = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
