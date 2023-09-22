namespace A._Vasya_and_Coins
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1660/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int[] coins = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfOnePurl = coins[0];
                int numberOfTwoPurl = coins[1];

                if (numberOfOnePurl == 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(2 * numberOfTwoPurl + numberOfOnePurl + 1);
                }
            }
        }
    }
}