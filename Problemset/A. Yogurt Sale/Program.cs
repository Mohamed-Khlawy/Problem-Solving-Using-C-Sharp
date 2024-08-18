namespace A._Yogurt_Sale
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1955/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_a_b = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int n = n_a_b[0];
                int a = n_a_b[1];
                int b = n_a_b[2];

                //Console.Write("*** ");

                if (n % 2 == 0)
                {
                    int divided = n / 2;

                    int using_a = n * a;

                    int using_b = divided * b;

                    Console.WriteLine(Math.Min(using_a, using_b));
                }

                else
                {
                    int divided = (n - 1) / 2;

                    int using_a = n * a;

                    int using_b_and_a = divided * b + a;

                    Console.WriteLine(Math.Min(using_a, using_b_and_a));
                }
            }
        }
    }
}
