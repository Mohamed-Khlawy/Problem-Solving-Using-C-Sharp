namespace A._Brick_Wall
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1918/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                double[] n_m = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

                double number_of_rows = n_m[0];
                double number_of_cols = n_m[1];

                Console.WriteLine(number_of_rows * Math.Floor(number_of_cols / 2));
            }
        }
    }
}
