namespace A._Required_Remainder
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1374/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] x_y_n = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int x = x_y_n[0];
                int y = x_y_n[1];
                int n = x_y_n[2];

                int n_mod_x = n % x;

                //Console.Write("*** ");

                if (n_mod_x == y)
                {
                    Console.WriteLine(n);
                }

                else if (n_mod_x < y)
                {
                    long diff = y - n_mod_x;

                    long result = n + diff - x;

                    Console.WriteLine(result);
                }

                else if (n_mod_x > y)
                {
                    long diff = n_mod_x - y;

                    long result = n - diff;

                    Console.WriteLine(result);
                }
            }
        }
    }
}
