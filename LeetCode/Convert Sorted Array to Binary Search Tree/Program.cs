namespace Convert_Sorted_Array_to_Binary_Search_Tree
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
        public TreeNode? SortedArrayToBST(int[] nums)
        {
            return Build(nums, 0, nums.Length - 1);
        }

        private TreeNode? Build(int[] nums, int left, int right)
        {
            if (left > right) return null;

            int mid = left + (right - left) / 2;

            TreeNode root = new(nums[mid]);

            root.left = Build(nums, left, mid - 1);
            root.right = Build(nums, mid + 1, right);

            return root;
        }

        static void Main(string[] args)
        {

        }
    }
}
