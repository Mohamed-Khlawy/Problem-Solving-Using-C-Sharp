namespace B._New_Theatre_Square
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1359/B
        public static void UpdateNumberOfWhites(ref int singles, ref int doubles,
            int numberOfDots)
        {
            switch (numberOfDots % 2)
            {
                case 0: /// Even Difference
                    doubles += numberOfDots / 2;
                    break;

                case 1: /// Odd Difference
                    singles += 1;
                    doubles += (numberOfDots - 1) / 2;
                    break;
            }
        }

        public static void CalcualteOption1ForTotalPrice(ref int minTotalPrice, int singles,
            int doubles, int burlesForSingle)
        {
            /// Option 1 Based on Burles for Single (ONLY)
            int tempPrice = (singles * burlesForSingle) + (doubles * 2 * burlesForSingle);

            minTotalPrice = tempPrice < minTotalPrice ? tempPrice : minTotalPrice;
        }

        public static void CalcualteOption2ForTotalPrice(ref int minTotalPrice, int singles,
            int doubles, int burlesForSingle, int burlesForDoble)
        {
            /// Option 2 Based on Burles for Double and Burles for Single (BOTH)
            int tempPrice = (singles * burlesForSingle) + (doubles * burlesForDoble);

            minTotalPrice = tempPrice < minTotalPrice ? tempPrice : minTotalPrice;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfRows = input[0];    /// n
                int numberOfColumns = input[1]; /// m
                int burlesForSingle = input[2]; /// x
                int burlesForDouble = input[3]; /// y

                List<List<char>> square = new List<List<char>>();

                for (int i = 0; i < numberOfRows; i++)
                {
                    List<char> iRow = Console.ReadLine()!
                                     .Select(c => char.Parse(c.ToString())).ToList();

                    square.Add(iRow);
                }

                int singles = 0;
                int doubles = 0;

                int minTotalPrice = int.MaxValue;

                for (int row = 0; row < numberOfRows; row++)
                {
                    int numberOfDots = 0;

                    for (int col = 0; col < numberOfColumns; col++)
                    {
                        if (square[row][col] == '.')
                            numberOfDots++;

                        else if (square[row][col] == '*')
                        {
                            UpdateNumberOfWhites(ref singles, ref doubles, numberOfDots);

                            numberOfDots = 0;
                        }
                    }

                    if (numberOfDots != 0)
                        UpdateNumberOfWhites(ref singles, ref doubles, numberOfDots);
                }

                CalcualteOption1ForTotalPrice
                    (ref minTotalPrice, singles, doubles, burlesForSingle);

                CalcualteOption2ForTotalPrice
                    (ref minTotalPrice, singles, doubles, burlesForSingle, burlesForDouble);

                //Console.Write("********************************** ");

                Console.WriteLine(minTotalPrice);
            }
        }
    }
}
