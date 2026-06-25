using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMainProject
{
    // Problem Link => https://leetcode.com/problems/minimum-depth-of-binary-tree/description/
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
    internal class Minimum_Depth_of_Binary_Tree
    {
        public int MinDepth(TreeNode? root)
        {
            if (root == null) return 0;

            else if (root.left == null || root.right == null)
            {
                if (root.left == null)
                {
                    return MinDepth(root.right) + 1;
                }

                else
                {
                    return MinDepth(root.left) + 1;
                }
            }

            else
            {
                int leftDepth = MinDepth(root.left);
                int rightDepth = MinDepth(root.right);

                return Math.Min(leftDepth, rightDepth) + 1;
            }
        }
    }
}
