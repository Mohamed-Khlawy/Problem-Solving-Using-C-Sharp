namespace A._Coins
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1814/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] n_k = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long burles_in_coins = n_k[0];
                long k_burles = n_k[1];

                if (burles_in_coins % 2 == 0)
                {
                    Console.WriteLine("YES");
                }

                else
                {
                    long diff_between_n_k = burles_in_coins - k_burles;

                    if (diff_between_n_k % 2 == 0)
                    {
                        Console.WriteLine("YES");
                    }

                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
        }
    }
}
