namespace A._System_of_Equations
{
    internal class Program
    {
        //I saw it's Tutorial
        //Problem Link: https://codeforces.com/problemset/problem/214/A
        static void Main(string[] args)
        {
            int[] n_m = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int n = n_m[0];
            int m = n_m[1];

            long numberOfPairs = 0;

            for (int a = 0; a * a <= n && a <= m; a++)
            {
                int b = n - a * a;

                if (a + b * b == m)
                {
                    numberOfPairs++;
                }
            }

            Console.WriteLine(numberOfPairs);
        }
    }
}