namespace A._Fashionable_Array
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2110/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                Array.Sort(numbers);

                int minMoves = 0;

                int firstElementMod = numbers[0] % 2;
                int lastElementMod = numbers[arraySize - 1] % 2;

                int movesCounter = 0;

                for (int i = 0; i < arraySize; i++)
                {
                    if (numbers[i] % 2 == lastElementMod)
                    {
                        minMoves = movesCounter;
                        break;
                    }

                    else movesCounter++;
                }

                movesCounter = 0;

                for (int i = arraySize - 1; i >= 0; i--)
                {
                    if (numbers[i] % 2 == firstElementMod)
                    {
                        minMoves = Math.Min(minMoves, movesCounter);
                        break;
                    }

                    else movesCounter++;
                }

                //Console.Write("************************** ");

                Console.WriteLine(minMoves);
            }
        }
    }
}
