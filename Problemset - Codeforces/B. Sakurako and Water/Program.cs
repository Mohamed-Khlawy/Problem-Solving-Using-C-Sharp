namespace B._Sakurako_and_Water
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2033/B
        public static List<int> Calculate2TempMaximums
            (List<List<int>> square, int squareDimension, int iterationNumber)
        {
            int tempMaxElement = 0;

            List<int> tempMaxElements = new List<int>();

            for (int col = iterationNumber - 1, row = 0;
                col < squareDimension && row < squareDimension;
                col++, row++)
            {
                tempMaxElement = Math.Min(tempMaxElement, square[row][col]);
            }

            tempMaxElements.Add(tempMaxElement);

            /// When we are in the Main Diagonal of the square we will do it only once,
            /// so we will return after first loop.
            if (iterationNumber == 1)
            {
                tempMaxElements.Add(0);
                return tempMaxElements;
            }

            tempMaxElement = 0;

            for (int row = iterationNumber - 1, col = 0;
                row < squareDimension && col < squareDimension;
                row++, col++)
            {
                tempMaxElement = Math.Min(tempMaxElement, square[row][col]);
            }

            tempMaxElements.Add(tempMaxElement);

            return tempMaxElements;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int squareDimension = int.Parse(Console.ReadLine()!);

                List<List<int>> square = new List<List<int>>();

                for (int i = 0; i < squareDimension; i++)
                {
                    square.Add(Console.ReadLine()!.Split().Select(int.Parse).ToList());
                }

                int iterationsIndex = squareDimension;

                int minMagicTimes = 0;

                while (iterationsIndex >= 1)
                {
                    List<int> tempMaxElements =
                        Calculate2TempMaximums(square, squareDimension, iterationsIndex);

                    int tempMaxElement1 = tempMaxElements[0];
                    int tempMaxElement2 = tempMaxElements[1];

                    minMagicTimes += tempMaxElement1 < 0 ? Math.Abs(tempMaxElement1) : 0;
                    minMagicTimes += tempMaxElement2 < 0 ? Math.Abs(tempMaxElement2) : 0;

                    iterationsIndex--;
                }

                //Console.Write("*********************** ");

                Console.WriteLine(minMagicTimes);
            }
        }
    }
}
