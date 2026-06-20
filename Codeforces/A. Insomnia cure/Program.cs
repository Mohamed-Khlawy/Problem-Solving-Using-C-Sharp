namespace A._Insomnia_cure
{
    internal class Program
    {
        // Problem Link: https://codeforces.com/problemset/problem/148/A
        static void Main(string[] args)
        {
            int k_Dragons = int.Parse(Console.ReadLine()!);
            int l_Dragons = int.Parse(Console.ReadLine()!);
            int m_Dragons = int.Parse(Console.ReadLine()!);
            int n_Dragons = int.Parse(Console.ReadLine()!);
            int totalDragons = int.Parse(Console.ReadLine()!);

            int totalDamaged = 0;
            for (int i = 1; i <= totalDragons; i++)
            {
                if (i % k_Dragons == 0 || i % l_Dragons == 0 || i % m_Dragons == 0 || i % n_Dragons == 0)
                {
                    totalDamaged++;
                }
            }

            Console.WriteLine(totalDamaged);
        }
    }
}