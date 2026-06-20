namespace A._Buttons
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1858/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] a_b_c = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                long a = a_b_c[0];
                long b = a_b_c[1];
                long c = a_b_c[2];

                // If a Not Equal b,
                // So, who's sum with c is greater WINS
                if (a != b)
                {
                    long a_sum_c = a + c;
                    long b_sum_c = b + c;

                    if (a_sum_c > b_sum_c)
                    {
                        Console.WriteLine("First");
                    }
                    else
                    {
                        Console.WriteLine("Second");
                    }
                }

                // If a Equal b,
                // So,
                // if c is odd  ==> Anne Wins (First)
                // if c is even ==> Kitte Wins (Second)
                else
                {
                    if (c % 2 != 0)
                    {
                        Console.WriteLine("First");
                    }
                    else
                    {
                        Console.WriteLine("Second");
                    }
                }
            }
        }
    }
}
