namespace A._Catch_the_Coin
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1989/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int coinX = input[0];
                int coinY = input[1];

                bool weCanCollectCoin = false;

                coinY -= Math.Abs(coinX) - 1;

                if (coinY >= 0 || (coinX < 0 && coinY >= coinX) || (coinX > 0 && coinY >= (coinX * -1)))
                    weCanCollectCoin = true;

                Console.WriteLine(weCanCollectCoin ? "YES" : "NO");
            }
        }
    }
}
