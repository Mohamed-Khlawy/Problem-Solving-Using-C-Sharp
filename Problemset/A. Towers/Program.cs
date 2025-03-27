namespace A._Towers
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/37/A
        static void Main(string[] args)
        {
            int numberOfBars = int.Parse(Console.ReadLine()!);

            int[] bars = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);

            Array.Sort(bars);

            int totalTowers = 0;
            int heighestTower = 0;

            for (int i = 0; i < numberOfBars; i++)
            {
                int tempTowerHeight = 1;

                for (int j = i + 1; j < numberOfBars; j++)
                {
                    if (bars[j] != bars[i]) break;

                    tempTowerHeight++;

                    i = j;
                }

                totalTowers++;

                heighestTower = Math.Max(tempTowerHeight, heighestTower);
            }

            //Console.Write("****************** ");

            Console.WriteLine($"{heighestTower} {totalTowers}");
        }
    }
}
