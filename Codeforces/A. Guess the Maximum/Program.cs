namespace A._Guess_the_Maximum
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1979/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int min_between_maximums = int.MaxValue;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    int max_between_adjacent = Math.Max(numbers[i], numbers[i + 1]);

                    if (min_between_maximums > max_between_adjacent)
                    {
                        min_between_maximums = max_between_adjacent;
                    }
                }

                //Console.Write("************************************** ");

                Console.WriteLine(min_between_maximums - 1);
            }
        }
    }
}
