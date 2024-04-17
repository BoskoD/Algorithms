using System.Collections.Generic;
using System.Xml.Linq;

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
            
            PrintPreorder(result); // pre order traversal
            PrintInorder(result); // in order traversal
            PrintPostorder(result); // post order traversal
            PrintTreeLevelOrder(result);    // level order traversal


            Console.WriteLine($"\nRight node from root: {result.right.val}\n" +
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

        public static void PrintTreeLevelOrder(TreeNode root)
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

        public static void PrintInorder(TreeNode root)
        {
            if (root == null) { return; }

            PrintInorder(root.left);

            // Then print the data of node
            Console.Write(root.val + " ");

            // Now recur on right child
            PrintInorder(root.right);
        }

        public static void PrintPreorder(TreeNode root)
        {
            if (root == null) { return; }

            // First print the data of node
            Console.Write(root.val + " ");

            // Then recur on left child
            PrintPreorder(root.left);

            // Now recur on right child
            PrintPreorder(root.right);
        }

        public static void PrintPostorder(TreeNode root)
        {
            if (root == null) { return; }

            // First recur on left child
            PrintPostorder(root.left);

            // Then recur on right child
            PrintPostorder(root.right);

            // Now print the data of node
            Console.Write(root.val + " ");
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
