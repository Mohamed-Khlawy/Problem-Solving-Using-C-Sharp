namespace B._Phoenix_and_Puzzle
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1515/B
        public static bool CanWeFormSquare(int halfPuzzles)
        {
            int sqrt = (int)Math.Sqrt(halfPuzzles);

            return sqrt * sqrt == halfPuzzles;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfPuzzlePieces = int.Parse(Console.ReadLine()!);

                //Console.Write("*********************** ");

                Console.WriteLine
                    ((numberOfPuzzlePieces % 2 == 0 && CanWeFormSquare(numberOfPuzzlePieces / 2)) ||
                     (numberOfPuzzlePieces % 4 == 0 && CanWeFormSquare(numberOfPuzzlePieces / 4))
                    ? "YES"
                    : "NO");
            }
        }
    }
}
