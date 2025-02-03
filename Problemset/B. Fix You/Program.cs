namespace B._Fix_You
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1391/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] sqaureDimensions = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfRows = sqaureDimensions[0];    /// n
                int numberOfColumns = sqaureDimensions[1]; /// m

                List<List<char>> square = new List<List<char>>();

                int minCellsToChange = 0;

                for (int i = 0; i < numberOfRows; i++)
                {
                    List<char> iRow = Console.ReadLine()!
                                     .Select(c => char.Parse(c.ToString()))
                                     .ToList();

                    square.Add(iRow);
                }

                #region Problem Idea
                /// The idea is that the last element in any row mustn't be (R),
                /// because this is the last element in the row
                /// and if this happen it will go out of the square boundaries and he will lose.
                /// 
                /// The same idea in the last row shouldn't have any character equal to (D),
                /// because this is the last row and nothing down from it,
                /// and if this happen it will go out of the square boundaries and he will lose.
                #endregion

                for (int i = 0; i < numberOfRows - 1; i++)
                {
                    if (square[i][numberOfColumns - 1] == 'R') minCellsToChange++;
                }

                for (int i = 0; i < numberOfColumns - 1; i++)
                {
                    if (square[numberOfRows - 1][i] == 'D') minCellsToChange++;
                }

                //Console.Write("********************** ");

                Console.WriteLine(minCellsToChange);
            }
        }
    }
}
