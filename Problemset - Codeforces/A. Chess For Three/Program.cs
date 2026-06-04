namespace A._Chess_For_Three
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1973/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] playersScores = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int scoresSum = playersScores.Sum();

                //Console.Write("********************* ");

                Console.WriteLine(scoresSum % 2 == 0
                    ? Math.Min(scoresSum / 2, playersScores[0] + playersScores[1])
                    : -1);
            }
        }
    }
}
