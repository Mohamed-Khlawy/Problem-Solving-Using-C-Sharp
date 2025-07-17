namespace A._Playing_with_Dice
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/378/A
        static void Main(string[] args)
        {
            int[] playersInput = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int firstPlayerPaper = playersInput[0];
            int secondPlayerPaper = playersInput[1];

            int possibleWinsForFirstPlayer = 0;
            int possibleWinsForSecondPlayer = 0;
            int possibleDraws = 0;

            for (int diceFace = 1; diceFace <= 6; diceFace++)
            {
                int diffForFirstPlayer = Math.Abs(diceFace - firstPlayerPaper);
                int diffForSecondPlayer = Math.Abs(diceFace - secondPlayerPaper);

                if (diffForFirstPlayer == diffForSecondPlayer)
                {
                    possibleDraws++;
                }

                else
                {
                    if (diffForFirstPlayer < diffForSecondPlayer)
                    {
                        possibleWinsForFirstPlayer++;
                    }

                    else possibleWinsForSecondPlayer++;
                }
            }

            //Console.Write("********************************* ");

            Console.WriteLine($"{possibleWinsForFirstPlayer} " +
                $"{possibleDraws} " +
                $"{possibleWinsForSecondPlayer}");
        }
    }
}
