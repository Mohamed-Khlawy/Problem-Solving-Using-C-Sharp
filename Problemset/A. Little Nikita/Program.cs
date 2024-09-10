namespace A._Little_Nikita
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1977/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_m = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int n = n_m[0];
                int m = n_m[1];

                if (n == m || (n > m && (n - m) % 2 == 0))
                {
                    Console.WriteLine("YES");
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
