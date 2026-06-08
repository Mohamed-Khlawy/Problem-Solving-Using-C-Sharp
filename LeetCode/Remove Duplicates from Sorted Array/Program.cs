namespace Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            
            int i = 0;
            
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1;
        }
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()!.Split(',').Select(int.Parse).ToArray();

            Program pr = new Program();

            Console.WriteLine($"Number of Unique Elements is {pr.RemoveDuplicates(nums)}\n" +
                $"The Array now ==> {string.Join(',', nums)}");
        }
    }
}
