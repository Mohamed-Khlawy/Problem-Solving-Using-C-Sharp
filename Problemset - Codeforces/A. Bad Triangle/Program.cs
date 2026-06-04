namespace A._Bad_Triangle
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1398/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long size = long.Parse(Console.ReadLine()!);

                List<long> numbers = Console.ReadLine()!.Split().Select(long.Parse).ToList();

                /// Based on that the numbers is already sorted,
                /// so the smallest sum we can get is from first and second number.
                long smallestSum = numbers[0] + numbers[1];

                //Console.Write("*************************** ");

                Console.WriteLine(smallestSum <= numbers[^1] ? $"1 2 {size}" : -1);
            }
        }
    }
}
