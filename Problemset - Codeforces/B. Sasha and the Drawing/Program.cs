namespace B._Sasha_and_the_Drawing
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1929/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] input = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long gridSize = input[0];            /// n
                long minColoredDiagonals = input[1]; /// k

                long totalGridDiagonals = (4 * gridSize) - 2;

                long minColoredCells = minColoredDiagonals == totalGridDiagonals
                    ? (totalGridDiagonals / 2) + 1
                    : (long)Math.Ceiling((decimal)minColoredDiagonals / 2);

                //Console.Write("************** ");

                Console.WriteLine(minColoredCells);
            }
        }
    }
}
