namespace B._Progressive_Square
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1955/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int square_size = input[0]; // n
                int rows_incrementing = input[1]; // c
                int cols_incrementing = input[2]; // d

                List<int> Maxim_square = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                Maxim_square.Sort();

                List<int> My_square = new List<int>();

                // First element in both squares are equal after sorting Maxim_square
                int current_row_element = Maxim_square[0];
                int current_col_element = Maxim_square[0];

                for (int row = 0; row < square_size; row++)
                {
                    if (row == 0)
                    {
                        // In first row no change will happen in the Current Row Element
                        My_square.Add(current_row_element);

                        for (int col = 1; col < square_size; col++)
                        {
                            current_col_element += cols_incrementing;

                            My_square.Add(current_col_element);
                        }
                    }

                    else
                    {
                        current_row_element += rows_incrementing;
                        current_col_element = current_row_element;

                        My_square.Add(current_row_element);

                        for (int col = 1; col < square_size; col++)
                        {
                            current_col_element += cols_incrementing;

                            My_square.Add(current_col_element);
                        }
                    }
                }

                My_square.Sort();

                //Console.Write("************************************* ");

                if (My_square.SequenceEqual(Maxim_square))
                {
                    Console.WriteLine("YES");
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
