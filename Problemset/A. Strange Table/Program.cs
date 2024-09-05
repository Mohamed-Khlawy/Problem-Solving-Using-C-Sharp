namespace A._Strange_Table
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1506/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] n_m_x = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long rows = n_m_x[0];
                long cols = n_m_x[1];
                long specific_number = n_m_x[2];

                long row_in_cols = ((specific_number - 1) % rows) + 1;
                long col_in_cols = (long)Math.Ceiling((double)specific_number / (double)rows);

                long target_number = (row_in_cols - 1) * cols + col_in_cols;

                //Console.Write("*********************************** ");

                Console.WriteLine(target_number);
            }
        }
    }
}
