namespace A._Cover_in_Water
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1900/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                string cells = Console.ReadLine()!;

                int empty_cells_counter = 0;

                int max_empty_cells = 0;

                List<int> empty_cells_list = new List<int>();

                for (int i = 0; i < cells.Length; i++)
                {
                    if (cells[i] == '.')
                    {
                        empty_cells_counter++;
                    }

                    else if (cells[i] == '#' && empty_cells_counter > 0)
                    {
                        empty_cells_list.Add(empty_cells_counter);

                        if (max_empty_cells < empty_cells_counter)
                        {
                            max_empty_cells = empty_cells_counter;
                        }

                        empty_cells_counter = 0;
                    }
                }

                empty_cells_list.Add(empty_cells_counter);

                if (max_empty_cells < empty_cells_counter)
                {
                    max_empty_cells = empty_cells_counter;
                }

                //Console.Write("***************************************** ");

                if (max_empty_cells >= 3)
                {
                    Console.WriteLine(2);
                }

                else
                {
                    Console.WriteLine(empty_cells_list.Sum());
                }
            }
        }
    }
}
