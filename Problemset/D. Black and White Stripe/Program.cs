namespace D._Black_and_White_Stripe
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1690/D
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_cells = n_k[0]; // n
                int consecutive_black_cells = n_k[1]; // k

                List<char> cells = Console.ReadLine()!
                                  .Select(c => char.Parse(c.ToString()))
                                  .ToList();

                int max_B_in_cells = 0;
                int max_B_in_subcells = 0;

                int left_index;
                int right_index;

                for (int i = 0; i <= cells.Count - consecutive_black_cells; i++)
                {
                    left_index = i;
                    right_index = i + consecutive_black_cells - 1;

                    if (left_index == 0)
                    {
                        for (int j = 0; j <= right_index; j++)
                        {
                            if (cells[j] == 'B')
                            {
                                max_B_in_subcells++;
                            }
                        }

                        max_B_in_cells = max_B_in_subcells;
                    }

                    else
                    {
                        if (cells[left_index - 1] == 'B')
                        {
                            max_B_in_subcells--;
                        }

                        if (cells[right_index] == 'B')
                        {
                            max_B_in_subcells++;
                        }


                        if (max_B_in_cells < max_B_in_subcells)
                        {
                            max_B_in_cells = max_B_in_subcells;
                        }
                    }

                    if (max_B_in_cells >= consecutive_black_cells)
                    {
                        break;
                    }
                }

                if (max_B_in_cells >= consecutive_black_cells)
                {
                    Console.WriteLine(0);
                }

                else
                {
                    Console.WriteLine(consecutive_black_cells - max_B_in_cells);
                }
            }
        }
    }
}
