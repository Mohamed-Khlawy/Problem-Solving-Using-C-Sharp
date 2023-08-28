namespace Z._Hard_Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            long[] nums = new long[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                nums[i] = long.Parse(elements[i]);
            }
            double first = (nums[1] * Math.Log(nums[0]));
            double second = (nums[3] * Math.Log(nums[2]));
            if (first > second)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}