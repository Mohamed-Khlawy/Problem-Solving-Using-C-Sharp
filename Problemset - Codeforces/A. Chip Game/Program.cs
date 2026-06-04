namespace A._Chip_Game
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1719/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] boardDimensions = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfRows = boardDimensions[0];
                int numberOfColumns = boardDimensions[1];

                /// Burenka will win if one of the dimensions is even and the other is odd,
                /// Otherwise Tonya will win.
                bool BurenkaWinns = (numberOfRows % 2 == 0 && numberOfColumns % 2 == 1) ||
                    (numberOfRows % 2 == 1 && numberOfColumns % 2 == 0);

                //Console.Write("******************** ");

                Console.WriteLine(BurenkaWinns ? "Burenka" : "Tonya");
            }
        }
    }
}
