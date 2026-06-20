namespace C._Target_Practice
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1873/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            int[,] default_matrix =
            {
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 2, 2, 2, 2, 2, 2, 2, 2, 1},
                {1, 2, 3, 3, 3, 3, 3, 3, 2, 1},
                {1, 2, 3, 4, 4, 4, 4, 3, 2, 1},
                {1, 2, 3, 4, 5, 5, 4, 3, 2, 1},
                {1, 2, 3, 4, 5, 5, 4, 3, 2, 1},
                {1, 2, 3, 4, 4, 4, 4, 3, 2, 1},
                {1, 2, 3, 3, 3, 3, 3, 3, 2, 1},
                {1, 2, 2, 2, 2, 2, 2, 2, 2, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
            };

            while (tests-- > 0)
            {
                int result = 0;

                for (int i = 0; i < 10; i++)
                {
                    string row_input = Console.ReadLine()!;

                    if (row_input.Contains('X'))
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (row_input[j] == 'X')
                            {
                                result += default_matrix[i, j];
                            }
                        }
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
