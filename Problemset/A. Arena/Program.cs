namespace A._Arena
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1487/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfHeroes = int.Parse(Console.ReadLine()!);

                int[] heroes = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                Array.Sort(heroes);

                int nonPossibleWinners = heroes.Where(hero => hero == heroes[0]).Count();

                int possibleWinners = numberOfHeroes - nonPossibleWinners;

                //Console.Write("************************** ");

                Console.WriteLine(possibleWinners);
            }
        }
    }
}
