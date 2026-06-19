namespace Maximum_Depth_of_Binary_Tree
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
        public int MaxDepth(TreeNode? root)
        {
            if (root == null) return 0;

            else
            {
                int leftDepth = MaxDepth(root.left);
                int rightDepth = MaxDepth(root.right);

                return Math.Max(leftDepth, rightDepth) + 1;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
