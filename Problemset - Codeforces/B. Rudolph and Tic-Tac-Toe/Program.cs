namespace B._Rudolph_and_Tic_Tac_Toe
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1846/B

        #region Problem Functions
        public static void IsTheWinnerInRows(List<List<char>> Matrix, ref bool IsThereAWinner,
            ref char winnerMark)
        {
            for (int row = 0; row < 3; row++)
            {
                if (Matrix[row][0] == Matrix[row][1] && Matrix[row][1] == Matrix[row][2] &&
                    Matrix[row][0] != '.')
                {
                    /// The winnerMark is anyone of these marks, because they are equal
                    winnerMark = Matrix[row][0];
                    IsThereAWinner = true;
                    return;
                }
            }

            IsTheWinnerInColumns(Matrix, ref IsThereAWinner, ref winnerMark);
        }

        public static void IsTheWinnerInColumns(List<List<char>> Matrix, ref bool IsThereAWinner,
            ref char winnerMark)
        {
            for (int col = 0; col < 3; col++)
            {
                if (Matrix[0][col] == Matrix[1][col] && Matrix[1][col] == Matrix[2][col] &&
                    Matrix[0][col] != '.')
                {
                    /// The winnerMark is anyone of these marks, because they are equal
                    winnerMark = Matrix[0][col];
                    IsThereAWinner = true;
                    return;
                }
            }

            IsTheWinnerInDiagonal1(Matrix, ref IsThereAWinner, ref winnerMark);
        }

        public static void IsTheWinnerInDiagonal1(List<List<char>> Matrix, ref bool IsThereAWinner,
            ref char winnerMark)
        {
            if (Matrix[0][0] == Matrix[1][1] && Matrix[1][1] == Matrix[2][2] &&
                Matrix[0][0] != '.')
            {
                /// The winnerMark is anyone of these marks, because they are equal
                winnerMark = Matrix[0][0];
                IsThereAWinner = true;
                return;
            }

            IsTheWinnerInDiagonal2(Matrix, ref IsThereAWinner, ref winnerMark);
        }

        public static void IsTheWinnerInDiagonal2(List<List<char>> Matrix, ref bool IsThereAWinner,
            ref char winnerMark)
        {
            if (Matrix[0][2] == Matrix[1][1] && Matrix[1][1] == Matrix[2][0] &&
                Matrix[0][2] != '.')
            {
                /// The winnerMark is anyone of these marks, because they are equal
                winnerMark = Matrix[0][2];
                IsThereAWinner = true;
                return;
            }
        }

        #endregion

        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<List<char>> TicTacToeMatrix = new List<List<char>>();

                for (int i = 0; i < 3; i++)
                {
                    List<char> iRow = Console.ReadLine()!
                                    .Select(c => char.Parse(c.ToString())).ToList();

                    TicTacToeMatrix.Add(iRow);
                }

                bool IsThereAWinner = false;

                char winnerMark = '#';

                IsTheWinnerInRows(TicTacToeMatrix, ref IsThereAWinner, ref winnerMark);

                //Console.WriteLine("****************** ");

                Console.WriteLine((IsThereAWinner && winnerMark != '.') ? winnerMark : "DRAW");

                //Console.WriteLine("****************** ");
            }
        }
    }
}
