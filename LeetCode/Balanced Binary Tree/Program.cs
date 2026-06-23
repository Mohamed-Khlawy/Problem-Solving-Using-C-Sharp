namespace Balanced_Binary_Tree
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
        public bool IsBalanced(TreeNode? root)
        {
            if (root == null) return true;

            int leftHeight = GetHeight(root.left);
            int rightHeight = GetHeight(root.right);

            if (Math.Abs(leftHeight - rightHeight) > 1) return false;

            return IsBalanced(root.left) && IsBalanced(root.right);
        }

        private int GetHeight(TreeNode? node)
        {
            if (node == null) return 0;

            return 1 + Math.Max(GetHeight(node.left), GetHeight(node.right));
        }

        static void Main(string[] args)
        {

        }
    }
}
