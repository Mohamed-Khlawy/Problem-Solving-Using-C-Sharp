namespace A._Turtle_Puzzle_Rearrange_and_Negate
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1933/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arr_size = int.Parse(Console.ReadLine()!);

                int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int positive_nums_sum = arr.Where(x => x > 0).Sum();

                int negative_nums_sum = (arr.Where(x => x < 0).Sum()) * -1;

                int total_sum = positive_nums_sum + negative_nums_sum;

                Console.WriteLine(total_sum);
            }
        }
    }
}
