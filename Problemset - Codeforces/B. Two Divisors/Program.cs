namespace B._Two_Divisors
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1916/B
        public static long CalculateGCD(long a, long b)
        {
            while (b != 0)
            {
                (a, b) = (b, a % b);
            }

            return a;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] input = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long a = input[0];
                long b = input[1];

                //Console.Write("*********************** ");

                if (b % a == 0)
                {
                    Console.WriteLine(b * b / a);
                }

                else
                {
                    Console.WriteLine(b * a / CalculateGCD(a, b));
                }
            }
        }
    }
}
