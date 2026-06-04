using System.Numerics;

namespace B._Sale
{
    internal class Program
    {
        //Problem link: https://codeforces.com/problemset/problem/34/B
        static void Main(string[] args)
        {
            // User inputs
            string numberOfSets_numberOfMoves = Console.ReadLine()!;
            string setsString = Console.ReadLine()!;

            // Convert user inputs to integers
            string[] numberOfSets_numberOfMovesArray = numberOfSets_numberOfMoves.Split(' ');
            string[] setsSplited = setsString.Split(' ');
            int numberOfSets = int.Parse(numberOfSets_numberOfMovesArray[0]);
            int numberOfMoves = int.Parse((numberOfSets_numberOfMovesArray[1]));

            int[] setsArray = new int[numberOfSets];// To store the money of each set
            BigInteger amountOfMoneyGained = 0;// To calculate amount of money he will gain
            List<int> money = new List<int>();// To add the minus value of any set

            for (int i = 0; i < numberOfSets; i++)
            {
                setsArray[i] = int.Parse(setsSplited[i].ToString());
                if (setsArray[i] < 0)
                {
                    money.Add(setsArray[i]);
                }
            }

            money.Sort();// To sort them and iterate on it based on the moves 

            int index = 0;
            for (int i = 0; i < numberOfMoves; i++)
            {
                if (index < money.Count)
                {
                    amountOfMoneyGained += money[index];
                    index++;
                }
            }

            // Used Math.Abs to get the absolute value of money
            Console.WriteLine(Math.Abs((double)amountOfMoneyGained));
        }
    }
}