namespace A._Lights_Out
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/275/A
        static void Main(string[] args)
        {
            // Create Intial Grid with all lights is on (equal to 1)
            List<List<int>> grid = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                List<int> ith_row = new List<int> { 1, 1, 1 };

                grid.Add(ith_row);
            }



            // Take the number of presses for each light
            List<List<int>> press_times = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                List<int> ith_row = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                press_times.Add(ith_row);
            }


            // Update the Grid for each light only when the number of presses is (ODD)
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (press_times[i][j] % 2 != 0)
                    {
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                grid[i][j] = Math.Abs(grid[i][j] - 1);
                                grid[i][j + 1] = Math.Abs(grid[i][j + 1] - 1);
                                grid[i + 1][j] = Math.Abs(grid[i + 1][j] - 1);
                            }

                            else if (j == 1)
                            {
                                grid[i][j] = Math.Abs(grid[i][j] - 1);
                                grid[i][j - 1] = Math.Abs(grid[i][j - 1] - 1);
                                grid[i][j + 1] = Math.Abs(grid[i][j + 1] - 1);
                                grid[i + 1][j] = Math.Abs(grid[i + 1][j] - 1);
                            }

                            else // j == 2
                            {
                                grid[i][j] = Math.Abs(grid[i][j] - 1);
                                grid[i][j - 1] = Math.Abs(grid[i][j - 1] - 1);
                                grid[i + 1][j] = Math.Abs(grid[i + 1][j] - 1);
                            }
                        }

                        else if (i == 1)
                        {
                            if (j == 0)
                            {
                                grid[i][j] = Math.Abs(grid[i][j] - 1);
                                grid[i - 1][j] = Math.Abs(grid[i - 1][j] - 1);
                                grid[i + 1][j] = Math.Abs(grid[i + 1][j] - 1);
                                grid[i][j + 1] = Math.Abs(grid[i][j + 1] - 1);

                            }

                            else if (j == 1)
                            {
                                grid[i][j] = Math.Abs(grid[i][j] - 1);
                                grid[i][j + 1] = Math.Abs(grid[i][j + 1] - 1);
                                grid[i][j - 1] = Math.Abs(grid[i][j - 1] - 1);
                                grid[i + 1][j] = Math.Abs(grid[i + 1][j] - 1);
                                grid[i - 1][j] = Math.Abs(grid[i - 1][j] - 1);

                            }

                            else // j == 2
                            {
                                grid[i][j] = Math.Abs(grid[i][j] - 1);
                                grid[i + 1][j] = Math.Abs(grid[i + 1][j] - 1);
                                grid[i - 1][j] = Math.Abs(grid[i - 1][j] - 1);
                                grid[i][j - 1] = Math.Abs(grid[i][j - 1] - 1);

                            }
                        }

                        else // i == 2
                        {
                            if (j == 0)
                            {
                                grid[i][j] = Math.Abs(grid[i][j] - 1);
                                grid[i - 1][j] = Math.Abs(grid[i - 1][j] - 1);
                                grid[i][j + 1] = Math.Abs(grid[i][j + 1] - 1);

                            }

                            else if (j == 1)
                            {
                                grid[i][j] = Math.Abs(grid[i][j] - 1);
                                grid[i - 1][j] = Math.Abs(grid[i - 1][j] - 1);
                                grid[i][j + 1] = Math.Abs(grid[i][j + 1] - 1);
                                grid[i][j - 1] = Math.Abs(grid[i][j - 1] - 1);

                            }

                            else // j == 2
                            {
                                grid[i][j] = Math.Abs(grid[i][j] - 1);
                                grid[i - 1][j] = Math.Abs(grid[i - 1][j] - 1);
                                grid[i][j - 1] = Math.Abs(grid[i][j - 1] - 1);

                            }
                        }
                    }
                }
            }

            //Console.WriteLine("**************************************");


            // Printing the resulting Grid
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grid[i][j]);
                }

                Console.WriteLine();
            }

            //Console.Write("**************************************");

            //Console.WriteLine();
        }
    }
}
