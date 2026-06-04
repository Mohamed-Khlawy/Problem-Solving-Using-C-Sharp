namespace A._Soccer
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1982/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] score1 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                int[] score2 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int x1 = score1[0];
                int x2 = score2[0];
                int y1 = score1[1];
                int y2 = score2[1];

                bool noDraw = false;

                if (x1 > y1 && x2 > y2 || x1 < y1 && x2 < y2)
                {
                    noDraw = true;
                }

                //Console.Write("*********************** ");

                Console.WriteLine(noDraw ? "YES" : "NO");
            }
        }
    }
}
