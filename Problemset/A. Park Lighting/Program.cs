namespace A._Park_Lighting
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1358/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int[] rows_cols = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                double rows = rows_cols[0];
                double cols = rows_cols[1];

                double minLanterns = 0;

                if (cols % 2 == 0) //Even number of cols
                {
                    minLanterns = cols / 2 * rows;
                }

                else //Odd number of cols
                {
                    minLanterns = ((cols - 1) / 2 * rows) + (Math.Ceiling(rows / 2));
                }

                Console.WriteLine(minLanterns);
            }
        }
    }
}