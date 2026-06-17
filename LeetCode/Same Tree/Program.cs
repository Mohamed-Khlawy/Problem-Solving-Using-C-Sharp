namespace Same_Tree
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
        public bool IsSameTree(TreeNode? p, TreeNode? q)
        {
            if (p == null && q == null) return true;

            if (p == null || q == null) return false;

            if (p.val != q.val) return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
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
            string[] inputTree1 = Console.ReadLine()!.Split(',').ToArray();
            string[] inputTree2 = Console.ReadLine()!.Split(',').ToArray();

            TreeNode? tree1 = BuildTree(inputTree1);
            TreeNode? tree2 = BuildTree(inputTree2);

            Program program = new();

            bool result = program.IsSameTree(tree1, tree2);

            Console.WriteLine(result);
        }
    }
}
