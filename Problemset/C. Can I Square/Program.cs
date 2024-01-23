namespace C._Can_I_Square
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1915/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests > 0)
            {
                tests--;

                long buckets = long.Parse(Console.ReadLine()!);

                List<long> buckets_list = Console.ReadLine()!.Split().Select(long.Parse).ToList();

                long wodden_squares = 0;

                for (int i = 0; i < buckets_list.Count; i++)
                {
                    wodden_squares += buckets_list[i];
                }

                double double_square = Math.Sqrt(wodden_squares);

                double int_square = Math.Floor(double_square);

                if (double_square == int_square)
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
