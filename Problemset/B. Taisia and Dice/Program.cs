namespace B._Taisia_and_Dice
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1790/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfDices = input[0];     /// n
                int totalDicesSum = input[1];     /// s
                int sumWithoutMaxDice = input[2]; /// r

                List<int> dicesFaces = new List<int>();

                int stolenDice = totalDicesSum - sumWithoutMaxDice;

                dicesFaces.Add(stolenDice);

                for (int i = 0; i < numberOfDices - 1; i++)
                {
                    int iDice = Math.Min(stolenDice, sumWithoutMaxDice - (numberOfDices - i - 2));

                    dicesFaces.Add(iDice);

                    sumWithoutMaxDice -= iDice;
                }

                //Console.Write("********************* ");

                Console.WriteLine(string.Join(" ", dicesFaces));
            }
        }
    }
}
