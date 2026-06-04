namespace A._Epic_Game
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/119/A
        public static int CalculateGCD(int firstNumber, int secondNumber)
        {
            while (secondNumber != 0)
            {
                (firstNumber, secondNumber) = (secondNumber, firstNumber % secondNumber);
            }

            return firstNumber;
        }

        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int SimonNumber = input[0];     /// a
            int AntisimonNumber = input[1]; /// b
            int numberOfStones = input[2];  /// n

            int turnCounter = 0;

            int tempGCD = 0;

            do
            {
                turnCounter++; /// Simon Always start the game

                switch (turnCounter % 2)
                {
                    case 0: /// If counter mod 2 is EVEN ===> Antisimon Turn
                        tempGCD = CalculateGCD(AntisimonNumber, numberOfStones);
                        break;



                    case 1: /// If counter mod 2 is ODD ===> Simon Turn
                        tempGCD = CalculateGCD(SimonNumber, numberOfStones);
                        break;
                }

                if (numberOfStones >= tempGCD)
                {
                    numberOfStones -= tempGCD;
                }

                else
                {
                    break;
                }
            }
            while (numberOfStones > 0);

            //Console.Write("************************* ");

            #region Problem Idea
            /// Based on the idea that Simon always start the game,
            /// if the counter after the game ended is (ODD) so Simon Wins 
            /// if the counter after the game ended is (EVEN) so Antisimon Wins
            #endregion

            Console.WriteLine(turnCounter % 2 == 1 ? "0" : "1");
        }
    }
}
