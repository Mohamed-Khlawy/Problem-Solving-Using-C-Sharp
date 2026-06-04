namespace B._The_Cake_Is_a_Lie
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1519/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_m_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int n = n_m_k[0];
                int m = n_m_k[1];
                int k = n_m_k[2];

                // Move Right
                int total_burles_for_right = (m - 1) * 1;

                // Move Left
                int total_burles_for_left = (n - 1) * m;

                int total_burles = total_burles_for_right + total_burles_for_left;

                if (total_burles == k)
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
