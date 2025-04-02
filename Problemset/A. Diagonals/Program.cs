namespace A._Diagonals
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1995/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] problemDescription =
                    Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                int boardDimension = problemDescription[0]; /// n
                int numberOfChips = problemDescription[1]; /// k

                int occupiedDiagonals = 0;

                if (numberOfChips >= boardDimension)
                {
                    /// We finish the main diagonal first,
                    /// then check other diagonals.
                    numberOfChips -= boardDimension;

                    occupiedDiagonals++;

                    int diagonalIndex = 1;

                    while (numberOfChips > 0)
                    {
                        /// Each diagonal after the main diagonal,
                        /// will execute 2 times.
                        numberOfChips -= boardDimension - diagonalIndex;

                        occupiedDiagonals++;

                        if (numberOfChips > 0)
                        {
                            numberOfChips -= boardDimension - diagonalIndex;
                            diagonalIndex++;
                            occupiedDiagonals++;
                        }
                    }
                }

                //Console.Write("********************* ");

                Console.WriteLine(occupiedDiagonals);
            }
        }
    }
}
