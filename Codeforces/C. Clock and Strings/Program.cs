namespace C._Clock_and_Strings
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1971/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] a_b_c_d = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int a = a_b_c_d[0];
                int b = a_b_c_d[1];
                int c = a_b_c_d[2];
                int d = a_b_c_d[3];

                int max_a_b = Math.Max(a, b);
                int min_a_b = Math.Min(a, b);

                if (c > max_a_b || c < min_a_b)
                {
                    if (d < max_a_b && d > min_a_b)
                    {
                        Console.WriteLine("YES");
                    }

                    else
                    {
                        Console.WriteLine("NO");
                    }
                }

                else if (d > max_a_b || d < min_a_b)
                {
                    if (c < max_a_b && c > min_a_b)
                    {
                        Console.WriteLine("YES");
                    }

                    else
                    {
                        Console.WriteLine("NO");
                    }
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
