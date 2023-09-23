namespace B._Who_s_Opposite
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1560/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                double[] a_b_c = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

                double a = a_b_c[0];
                double b = a_b_c[1];
                double c = a_b_c[2];

                double difference = Math.Abs(a - b);
                double totalNumbers = difference * 2;

                if (difference < 2 || a > totalNumbers || b > totalNumbers || c > totalNumbers
                    || Math.Max(a, b) != Math.Min(a, b) + difference)
                {
                    Console.WriteLine(-1);
                }

                else
                {
                    if (c <= difference)
                    {
                        Console.WriteLine(c + difference);
                    }
                    else
                    {
                        Console.WriteLine(c - difference);
                    }
                }
            }
        }
    }
}