namespace X._8_Neighbors
{
    internal class Program
    {
        //This proplem was hard and i used Chat Gpt
        static bool IsValid(int x, int y, int n, int m)
        {
            return x >= 0 && x < n && y >= 0 && y < m;
        }

        static bool AreAllNeighborsX(char[,] grid, int x, int y, int n, int m)
        {
            int[] dx = { -1, 1, 0, 0, -1, -1, 1, 1 };
            int[] dy = { 0, 0, -1, 1, -1, 1, -1, 1 };

            for (int i = 0; i < 8; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];

                if (IsValid(nx, ny, n, m) && grid[nx, ny] != 'x')
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            char[,] grid = new char[n, m];

            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine()!;
                for (int j = 0; j < m; j++)
                {
                    grid[i, j] = row[j];
                }
            }

            int[] xy = Console.ReadLine()!.Split().Select(int.Parse)!.ToArray();
            int x = xy[0] - 1; // Adjust for 0-based indexing
            int y = xy[1] - 1; // Adjust for 0-based indexing

            if (AreAllNeighborsX(grid, x, y, n, m))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}