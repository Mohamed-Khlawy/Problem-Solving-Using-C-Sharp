namespace A._Yet_Another_Tetris_Problem
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1324/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfColumns = int.Parse(Console.ReadLine()!);

                int[] columnsHeights = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int evenHeights = columnsHeights.Where(height => height % 2 == 0).Count();

                //Console.Write("****************************** ");

                Console.WriteLine((evenHeights == 0 || evenHeights == numberOfColumns)
                    ? "YES"
                    : "NO");
            }
        }
    }
}
