namespace A._Dima_and_Friends
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/272/A
        static void Main(string[] args)
        {
            int numberOfPlayers = int.Parse(Console.ReadLine()!);

            int[] playersFingers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int[] DimaPossibleFingers = new int[] { 1, 2, 3, 4, 5 };

            int playersFingersSum = playersFingers.Sum();

            int DimaFingersToWin = 0;

            for (int i = 0; i < 5; i++)
            {
                /// When the mod result is one, 
                /// Dima will lose the game and clean the apartment.
                DimaFingersToWin +=
                    (playersFingersSum + DimaPossibleFingers[i]) % (numberOfPlayers + 1) != 1
                    ? 1
                    : 0;
            }

            //Console.Write("********************** ");

            Console.WriteLine(DimaFingersToWin);
        }
    }
}
