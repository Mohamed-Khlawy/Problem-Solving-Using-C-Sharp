namespace A._Cakeminator
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/330/A

        public static void isItStrawberryOrDot(char matrix_cell,
            ref int temp_cake_counter, ref bool we_found_evil_strawberry)
        {
            switch (matrix_cell)
            {
                case 'S':
                    we_found_evil_strawberry = true;
                    break;

                case '.':
                    temp_cake_counter++;
                    break;
            }
        }

        static void Main(string[] args)
        {
            int[] rows_columns = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int rows = rows_columns[0];
            int columns = rows_columns[1];

            int number_of_eating_cake_cells = 0;

            bool we_found_evil_strawberry = false;

            List<int> taken_rows = new List<int>();

            List<List<char>> matrix = new List<List<char>>();

            for (int i = 0; i < rows; i++)
            {
                List<char> row_input = Console.ReadLine()!
                                      .Select(c => char.Parse(c.ToString()))
                                      .ToList();

                matrix.Add(row_input);
            }

            // Count number of eating cake cells in each row
            for (int row = 0; row < rows; row++)
            {
                we_found_evil_strawberry = false;
                int temp_cake_counter = 0;

                for (int column = 0; column < columns; column++)
                {
                    isItStrawberryOrDot(matrix[row][column],
                        ref temp_cake_counter, ref we_found_evil_strawberry);

                    // When we find one evil strawberry we won't take the whole row
                    if (we_found_evil_strawberry)
                    {
                        temp_cake_counter = 0;
                        break;
                    }
                }

                // We didn't find any evil strawberry, so we will take the whole row
                if (!we_found_evil_strawberry)
                {
                    number_of_eating_cake_cells += temp_cake_counter;
                    taken_rows.Add(row);
                }
            }

            // Count number of remaining cake cells in each column
            for (int column = 0; column < columns; column++)
            {
                we_found_evil_strawberry = false;
                int temp_cake_counter = 0;

                for (int row = 0; row < rows; row++)
                {
                    if (!taken_rows.Contains(row))
                    {
                        isItStrawberryOrDot(matrix[row][column],
                        ref temp_cake_counter, ref we_found_evil_strawberry);

                        if (we_found_evil_strawberry)
                        {
                            temp_cake_counter = 0;
                            break;
                        }
                    }
                }

                if (!we_found_evil_strawberry)
                {
                    number_of_eating_cake_cells += temp_cake_counter;
                }
            }

            //Console.Write("********************************** ");

            Console.WriteLine(number_of_eating_cake_cells);
        }
    }
}
