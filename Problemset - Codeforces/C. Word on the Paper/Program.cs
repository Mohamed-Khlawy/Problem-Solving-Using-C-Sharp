namespace C._Word_on_the_Paper
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1850/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int[,] grid = new int[8, 8];

                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    string rowElements = Console.ReadLine()!;

                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        grid[i, j] = rowElements[j];
                    }
                }

                string word = "";

                foreach (char element in grid)
                {
                    if (element != '.')
                    {
                        word += element;
                    }
                }

                Console.WriteLine(word);
            }
        }
    }
}