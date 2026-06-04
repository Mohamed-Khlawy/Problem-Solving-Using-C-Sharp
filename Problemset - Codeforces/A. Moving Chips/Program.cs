namespace A._Moving_Chips
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1923/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int ribbonCells = int.Parse(Console.ReadLine()!);

                int[] ribbon = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);

                int firstCellWithChip = Array.IndexOf(ribbon, 1);
                int lastCellWithChip = Array.LastIndexOf(ribbon, 1);

                int freeCells = 0;

                for (int i = firstCellWithChip + 1; i < lastCellWithChip; i++)
                {
                    if (ribbon[i] == 0) freeCells++;
                }

                //Console.Write("********************* ");

                Console.WriteLine(freeCells);
            }
        }
    }
}
