namespace T._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            int[] nums = new int[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                nums[i] = int.Parse(elements[i]);
            }
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Array.Reverse(nums);
            Console.WriteLine();
            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}