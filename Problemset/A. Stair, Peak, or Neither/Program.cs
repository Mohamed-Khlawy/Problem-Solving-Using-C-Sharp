namespace A._Stair__Peak__or_Neither
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1950/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] a_b_c = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int a = a_b_c[0];
                int b = a_b_c[1];
                int c = a_b_c[2];

                if (a < b)
                {
                    if (b < c)
                    {
                        Console.WriteLine("STAIR");
                    }

                    else if (b > c)
                    {
                        Console.WriteLine("PEAK");
                    }

                    else
                    {
                        Console.WriteLine("NONE");
                    }
                }

                else
                {
                    Console.WriteLine("NONE");
                }
            }
        }
    }
}
