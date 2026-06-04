namespace A._Three_Piles_of_Candies
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1196/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] input = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long firstPile = input[0];  /// a
                long secondPile = input[1]; /// b
                long thirdPile = input[2];  /// c

                //Console.Write("****************************** ");

                Console.WriteLine(input.Sum() / 2);
            }
        }
    }
}
