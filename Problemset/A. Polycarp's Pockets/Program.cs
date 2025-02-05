namespace A._Polycarp_s_Pockets
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1003/A
        static void Main(string[] args)
        {
            int numberOfCoins = int.Parse(Console.ReadLine()!);

            List<int> coins = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            int minPockets = 0;

            coins.Sort();

            for (int i = 0; i < coins.Count; i++)
            {
                int tempPockets = 1;

                for (int j = i + 1; j < coins.Count; j++)
                {
                    if (coins[j] == coins[i]) tempPockets++;

                    else break;
                }

                minPockets = Math.Max(minPockets, tempPockets);
            }

            //Console.Write("******************* ");

            Console.WriteLine(minPockets);
        }
    }
}
