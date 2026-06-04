namespace A._LCM_Problem
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1389/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> l_r = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int l = l_r[0];
                int r = l_r[1];

                if (l * 2 <= r)
                {
                    Console.WriteLine(l + " " + 2 * l);
                }

                else
                {
                    Console.WriteLine(-1 + " " + -1);
                }
            }
        }
    }
}
