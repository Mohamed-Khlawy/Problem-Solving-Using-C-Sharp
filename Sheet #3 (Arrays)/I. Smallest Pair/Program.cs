namespace I._Smallest_Pair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);
                int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                // We intialize smallest Sum with first iteration result
                int smallestSum = numbersArray[0] + numbersArray[1] + 1 - 0;

                for (int i = 0; i < numbersArray.Length - 1; i++)
                {
                    for (int j = i + 1; j < numbersArray.Length; j++)
                    {
                        int iterationSum = numbersArray[i] + numbersArray[j] + j - i;

                        if (smallestSum > iterationSum)
                        {
                            smallestSum = iterationSum;
                        }
                    }
                }

                Console.WriteLine(smallestSum);
            }
        }
    }
}