namespace A._To_Zero
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2075/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int n = n_k[0],
                    k = n_k[1];

                int minOperations = 0;

                if (n % 2 != 0)
                {
                    n -= k;
                    minOperations = 1;
                }

                minOperations += (int)Math.Ceiling((decimal)n / (k - 1));

                //Console.Write("******************************* ");

                Console.WriteLine(minOperations);
            }
        }
    }
}
