namespace A._Beat_The_Odds
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1691/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<long> numbers = Console.ReadLine()!.Split().Select(long.Parse).ToList();

                int removed_odds = 0;
                int removed_evens = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        removed_evens++;
                    }

                    else
                    {
                        removed_odds++;
                    }
                }

                Console.WriteLine(Math.Min(removed_evens, removed_odds));
            }
        }
    }
}
