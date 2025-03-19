namespace C._Game_of_Mathletes
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2060/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int arraySize = input[0];   /// n
                int requiredSum = input[1]; /// k

                int[] blackBoardNumbers =
                    Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int[] numbersFrequency = new int[arraySize + 1];

                int gameScore = 0;

                int leftIndex = 0;
                int rightIndex = arraySize - 1;

                while (leftIndex < rightIndex)
                {
                    numbersFrequency[blackBoardNumbers[leftIndex]]++;
                    numbersFrequency[blackBoardNumbers[rightIndex]]++;

                    leftIndex++;
                    rightIndex--;
                }

                for (int i = 1; i <= requiredSum / 2; i++)
                {
                    if (requiredSum - i <= arraySize)
                    {
                        gameScore += i != requiredSum - i
                            ? Math.Min(numbersFrequency[i], numbersFrequency[requiredSum - i])
                            : numbersFrequency[i] / 2;
                    }
                }

                //Console.Write("************************** ");

                Console.WriteLine(gameScore);
            }
        }
    }
}
