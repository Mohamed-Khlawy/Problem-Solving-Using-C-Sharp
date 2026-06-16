using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class Program
    {
        public IList<int> InorderTraversal(TreeNode? root)
        {
            List<int> result = new();
            
            Traverse(root, result);
            
            return result;
        }

        private void Traverse(TreeNode? node, List<int> result)
        {
            if (node == null) return;

            Traverse(node.left, result); // Traverse the left subtree

            result.Add(node.val); // Visit the current node

            Traverse(node.right, result); // Traverse the right subtree
        }

        static TreeNode? BuildTree(string[] values)
        {
            if (values.Length == 0 || values[0] == "null" || values[0] == "")
                return null;

            TreeNode root = new TreeNode(int.Parse(values[0]));

            Queue<TreeNode> queue = new();
            queue.Enqueue(root);

            int i = 1;

            while (queue.Count > 0 && i < values.Length)
            {
                TreeNode current = queue.Dequeue();

                // Left child
                if (i < values.Length && values[i] != "null")
                {
                    current.left = new TreeNode(int.Parse(values[i]));
                    queue.Enqueue(current.left);
                }
                i++;

                // Right child
                if (i < values.Length && values[i] != "null")
                {
                    current.right = new TreeNode(int.Parse(values[i]));
                    queue.Enqueue(current.right);
                }
                i++;
            }

            return root;
        }
        
        static void Main(string[] args)
        {
            string[] inputTree = Console.ReadLine()!.Split(',').ToArray();

            TreeNode? root = BuildTree(inputTree);

            Program program = new();

            IList<int> result = program.InorderTraversal(root);

            Console.WriteLine(string.Join(',', result));
        }
    }
}
