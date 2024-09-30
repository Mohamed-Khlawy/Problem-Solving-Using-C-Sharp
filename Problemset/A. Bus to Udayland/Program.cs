namespace A._Bus_to_Udayland
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/711/A
        static void Main(string[] args)
        {
            int number_of_rows = int.Parse(Console.ReadLine()!);

            List<string> rows = new List<string>();

            int row_number_for_seating = 0;

            int exact_half_of_row = 0; // 0 for first half, 1 for second half

            bool can_they_seat = false;

            for (int i = 0; i < number_of_rows; i++)
            {
                rows.Add(Console.ReadLine()!);

                if (rows[i][0] == rows[i][1] && rows[i][0] == 'O' && !can_they_seat)
                {
                    row_number_for_seating = i;
                    exact_half_of_row = 0;
                    can_they_seat = true;
                }

                else if (rows[i][3] == rows[i][4] && rows[i][3] == 'O' && !can_they_seat)
                {
                    row_number_for_seating = i;
                    exact_half_of_row = 1;
                    can_they_seat = true;
                }
            }

            if (can_they_seat)
            {
                Console.WriteLine("YES");

                for (int i = 0; i < number_of_rows; i++)
                {
                    if (i == row_number_for_seating)
                    {
                        if (exact_half_of_row == 0)
                        {
                            Console.Write("++");

                            for (int j = 2; j < rows[i].Length; j++)
                            {
                                Console.Write(rows[i][j]);
                            }

                            Console.WriteLine();
                        }

                        else if (exact_half_of_row == 1)
                        {
                            for (int j = 0; j < rows[i].Length - 2; j++)
                            {
                                Console.Write(rows[i][j]);
                            }

                            Console.Write("++");

                            Console.WriteLine();
                        }
                    }

                    else
                    {
                        Console.WriteLine(rows[i]);
                    }
                }
            }

            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
