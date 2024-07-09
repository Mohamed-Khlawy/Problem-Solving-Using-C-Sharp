namespace C._Where_s_the_Bishop
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1692/C
        static void Main(string[] args)
        {
            // Note 1 ==> If you will take the code to the Codeforces to submit the Problem,
            // don't change any line of the code.
            // Note 2 ==> If you want to test the problem with the example test of the problem,
            // You will have to Uncomment the string x1 line and the string z line and it will work.


            int tests = int.Parse(Console.ReadLine()!);
            string x = Console.ReadLine()!;
            //string x1 = Console.ReadLine()!;

            while (tests-- > 0)
            {
                List<string> chessboard = new List<string>(8);

                for (int i = 0; i < 8; i++)
                {
                    chessboard.Add(Console.ReadLine()!);
                }

                int bishop_row = 0;
                int bishop_col = 0;

                for (int i = 1; i < 7; i++)
                {
                    if (chessboard[i - 1].Where(x => x == '#').Count() == 2 &&
                        chessboard[i].Where(x => x == '#').Count() == 1 &&
                        chessboard[i + 1].Where(x => x == '#').Count() == 2)
                    {
                        bishop_row = i;
                        break;
                    }
                }

                for (int i = 1; i < 7; i++)
                {
                    if (chessboard[bishop_row][i] == '#')
                    {
                        bishop_col = i;
                        break;
                    }
                }

                bishop_row++;
                bishop_col++;

                Console.WriteLine(bishop_row + " " + bishop_col);

                if (tests > 0)
                {
                    string y = Console.ReadLine()!;
                    //string z = Console.ReadLine()!;
                }
            }
        }
    }
}
