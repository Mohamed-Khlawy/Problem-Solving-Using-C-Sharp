namespace A._Theatre_Square
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1/A
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

            double n = input[0];
            double m = input[1];
            double a = input[2];

            long result = (long)(Math.Ceiling((n / a)) * Math.Ceiling((m / a)));

            Console.WriteLine(result);
        }
    }
}
