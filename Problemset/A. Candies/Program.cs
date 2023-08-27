namespace A._Candies
{
    internal class Program
    {
        // Problem link: https://codeforces.com/problemset/problem/1343/A
        // This problem was hard on me, and i saw it's tutorial
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int candyWrappers = int.Parse(Console.ReadLine()!);

                for (int k_day = 2; k_day < 30; k_day++)
                {

                    if (candyWrappers % (Math.Pow(2, k_day) - 1) == 0)
                    {
                        double numberOfCandies = candyWrappers / (Math.Pow(2, k_day) - 1);
                        Console.WriteLine(numberOfCandies);
                        break;
                    }
                }

            }
        }
    }
}