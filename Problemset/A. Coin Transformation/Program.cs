namespace A._Coin_Transformation
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2043/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long coinValue = long.Parse(Console.ReadLine()!); // n

                long maxCoins = 1;

                int dividingTimes = 0;

                while (coinValue > 3)
                {
                    coinValue = (long)Math.Floor((decimal)coinValue / 4);

                    dividingTimes++;
                }
                
                maxCoins = (int)Math.Pow(2, dividingTimes);

                //Console.Write("***************************** ");

                Console.WriteLine(maxCoins);
            }
        }
    }
}
