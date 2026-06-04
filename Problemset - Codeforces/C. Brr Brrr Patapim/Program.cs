namespace C._Brr_Brrr_Patapim
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2094/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int gridSize = int.Parse(Console.ReadLine()!);

                List<List<int>> grid = new List<List<int>>();

                for (int i = 0; i < gridSize; i++)
                {
                    List<int> row =
                        Console.ReadLine()!.Split(' ').Select(int.Parse).ToList();

                    grid.Add(row);
                }

                long[] permutation = new long[gridSize * 2];

                long totalSum = gridSize * 2 * (gridSize * 2 + 1) / 2;

                for (int row = 0; row < gridSize; row++)
                {
                    for (int col = 0; col < gridSize; col++)
                    {
                        int index = row + col + 1;

                        permutation[index] = grid[row][col];
                    }
                }

                permutation[0] = totalSum - permutation.Sum();

                //Console.Write("*********************** ");

                Console.WriteLine(string.Join(" ", permutation));
            }
        }
    }
}
