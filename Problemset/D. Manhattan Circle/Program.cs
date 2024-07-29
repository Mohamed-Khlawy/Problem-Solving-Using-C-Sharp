namespace D._Manhattan_Circle
{
    internal class Program
    {
        // Probelm Link : https://codeforces.com/problemset/problem/1985/D
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_m = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int n = n_m[0];
                int m = n_m[1];

                List<string> grid = new List<string>(n);

                for (int i = 0; i < n; i++)
                {
                    grid.Add(Console.ReadLine()!);
                }

                int max_number_of_windows = 0;
                int row_with_max_window = 0;

                for (int i = 0; i < n; i++)
                {
                    int counter_for_windows = grid[i].Where(x => x == '#').Count();

                    if (counter_for_windows > max_number_of_windows)
                    {
                        row_with_max_window = i;
                        max_number_of_windows = counter_for_windows;
                    }
                }

                int first_window_in_row = grid[row_with_max_window].IndexOf('#');
                int last_window_in_row = grid[row_with_max_window].LastIndexOf('#');

                int col_with_center_window = (first_window_in_row + last_window_in_row) / 2 + 1;
                row_with_max_window += 1;

                //Console.Write("*** ");
                Console.WriteLine(row_with_max_window + " " + col_with_center_window);
            }
        }
    }
}
