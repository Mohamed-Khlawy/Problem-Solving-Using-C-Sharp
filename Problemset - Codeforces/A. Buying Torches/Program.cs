namespace A._Buying_Torches
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1418/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] gameInput = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long trade1 = gameInput[0]; /// x
                long trade2 = gameInput[1]; /// y
                long requiredTorches = gameInput[2]; /// k

                long totalSticks = (trade2 * requiredTorches) + requiredTorches - 1;

                long minTrades = (long)Math.Ceiling((decimal)totalSticks / (trade1 - 1))
                    + requiredTorches;

                //Console.Write("********************* ");

                Console.WriteLine(minTrades);
            }
        }
    }
}
