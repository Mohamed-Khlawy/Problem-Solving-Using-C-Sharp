namespace A._Donut_Shops
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1373/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                double[] input = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

                double a = input[0];
                double b = input[1];
                double c = input[2];

                //Console.Write("***************************** ");

                if (a >= c)
                {
                    Console.WriteLine($"-1 {b}");
                }

                else
                {
                    if (c / b < a)
                    {
                        Console.WriteLine($"1 {b}");
                    }

                    else
                    {
                        Console.WriteLine($"1 -1");
                    }
                }
            }
        }
    }
}
