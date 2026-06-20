namespace B._Scale
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1996/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int n = n_k[0];
                int k = n_k[1];

                List<List<int>> original_grid = new List<List<int>>(); // Input Grid

                List<List<int>> reduced_grid = new List<List<int>>();  // Output Grid

                // Take the Input Grid as a List of Lists of ints
                for (int i = 0; i < n; i++)
                {
                    original_grid.Add(Console.ReadLine()!.
                        Select(x => int.Parse(x.ToString())).ToList());
                }

                // Number of Rows and Columns for the Output Grid
                int n_divide_by_k = n / k;

                // Store target vlues from Input (original) Grid to Output (reduced) Grid
                for (int i = 0; i < n_divide_by_k; i++)
                {
                    List<int> row_for_reduced = new List<int>();

                    for (int j = 0; j < n_divide_by_k; j++)
                    {
                        row_for_reduced.Add(original_grid[i * k][j * k]);
                    }

                    reduced_grid.Add(row_for_reduced);
                }


                // Printing the Output (redueced) Grid
                //Console.WriteLine("*******************************");

                for (int i = 0; i < n_divide_by_k; i++)
                {
                    for (int j = 0; j < n_divide_by_k; j++)
                    {
                        Console.Write(reduced_grid[i][j]);
                    }
                    Console.WriteLine();
                }

                //Console.WriteLine("*******************************");
            }
        }
    }
}
