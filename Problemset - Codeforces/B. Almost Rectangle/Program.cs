namespace B._Almost_Rectangle
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1512/B
        public static void FirstAndSecondAsterisksInTheSameRow
            (int squareDimension, ref List<List<char>> square, int[] existingAsterisks)
        {
            if (existingAsterisks[0] < squareDimension - 1)
            {
                square[existingAsterisks[0] + 1][existingAsterisks[1]] = '*';
                square[existingAsterisks[2] + 1][existingAsterisks[3]] = '*';
            }

            else
            {
                square[existingAsterisks[0] - 1][existingAsterisks[1]] = '*';
                square[existingAsterisks[2] - 1][existingAsterisks[3]] = '*';
            }
        }
        public static void FirstAndSecondAsterisksInTheSameColumn
            (int squareDimension, ref List<List<char>> square, int[] existingAsterisks)
        {
            if (existingAsterisks[1] < squareDimension - 1)
            {
                square[existingAsterisks[0]][existingAsterisks[1] + 1] = '*';
                square[existingAsterisks[2]][existingAsterisks[3] + 1] = '*';
            }

            else
            {
                square[existingAsterisks[0]][existingAsterisks[1] - 1] = '*';
                square[existingAsterisks[2]][existingAsterisks[3] - 1] = '*';
            }
        }
        public static void NeitherInSameRowOrColumn
            (int squareDimension, ref List<List<char>> square, int[] existingAsterisks)
        {
            square[existingAsterisks[0]][existingAsterisks[3]] = '*';
            square[existingAsterisks[2]][existingAsterisks[1]] = '*';
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int squareDimension = int.Parse(Console.ReadLine()!);

                List<List<char>> square = new List<List<char>>();

                for (int i = 0; i < squareDimension; i++)
                {
                    List<char> iThRow =
                        Console.ReadLine()!.Select(mark => char.Parse(mark.ToString())).ToList();

                    square.Add(iThRow);
                }

                #region Array Explanation

                /// 0 Index ==> First Asterisk Row
                /// 1 Index ==> First Asterisk Col
                /// 2 Index ==> Second Asterisk Row
                /// 3 Index ==> Second Asterisk Col

                #endregion
                int[] existingAsterisks = new int[4];

                bool foundFirstAsterisk = false;
                bool foundSecondAsterisk = false;

                for (int row = 0; row < squareDimension; row++)
                {
                    for (int col = 0; col < squareDimension; col++)
                    {
                        if (square[row][col] == '*')
                        {
                            if (!foundFirstAsterisk) /// Now we found First Asterisk
                            {
                                existingAsterisks[0] = row;
                                existingAsterisks[1] = col;
                                foundFirstAsterisk = true;
                            }

                            else /// Now we found Second Asterisk
                            {
                                existingAsterisks[2] = row;
                                existingAsterisks[3] = col;
                                foundSecondAsterisk = true;
                                break;
                            }
                        }
                    }

                    if (foundFirstAsterisk && foundSecondAsterisk) break;
                }

                /// They are in the same Row
                if (existingAsterisks[0] == existingAsterisks[2])
                {
                    FirstAndSecondAsterisksInTheSameRow
                        (squareDimension, ref square, existingAsterisks);
                }

                /// They are in the same Column
                else if (existingAsterisks[1] == existingAsterisks[3])
                {
                    FirstAndSecondAsterisksInTheSameColumn
                        (squareDimension, ref square, existingAsterisks);
                }

                /// Neither in same Row or Column
                else
                {
                    NeitherInSameRowOrColumn
                        (squareDimension, ref square, existingAsterisks);
                }

                //Console.WriteLine("*************************************************");

                for (int row = 0; row < squareDimension; row++)
                {
                    Console.WriteLine(string.Join("", square[row]));
                }

                //Console.WriteLine("*************************************************");
            }
        }
    }
}
