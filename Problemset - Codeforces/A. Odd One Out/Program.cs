namespace A._Odd_One_Out
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1915/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] a_b_c = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int a = a_b_c[0];
                int b = a_b_c[1];
                int c = a_b_c[2];

                if (a == b)
                {
                    Console.WriteLine(c);
                }

                else if (b == c)
                {
                    Console.WriteLine(a);
                }

                else
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
