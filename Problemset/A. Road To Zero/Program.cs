namespace A._Road_To_Zero
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1342/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] x_y = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long x = x_y[0];
                long y = x_y[1];

                long[] a_b = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long a = a_b[0];
                long b = a_b[1];

                long min_dollars = (Math.Abs(x - y) * a) +
                    Math.Min((Math.Min(x, y) * b), (Math.Min(x, y) * 2 * a));

                Console.WriteLine(min_dollars);
            }
        }
    }
}
