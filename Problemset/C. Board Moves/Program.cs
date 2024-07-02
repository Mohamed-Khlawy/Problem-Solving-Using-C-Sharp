namespace C._Board_Moves
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1353/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long n = long.Parse(Console.ReadLine()!);

                long sum_squares = 0;

                for (int i = 1; i <= n / 2; i++)
                {
                    sum_squares += (long)i * i;
                }

                Console.WriteLine(sum_squares * 8);
            }
        }
    }
}
