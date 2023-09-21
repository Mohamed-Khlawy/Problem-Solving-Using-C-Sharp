namespace E._Alternating_Array
{
    internal class Program
    {
        // It was hard but i got it
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int[] copy = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                copy[i] = numbersArray[i];
            }

            int firstWayMinOperations = 0;
            int secondWayMinOperations = 0;

            for (int i = 0; i < numbersArray.Length - 1; i++) // First Way
            {
                if ((numbersArray[i] < 0 && numbersArray[i + 1] < 0) ||
                    (numbersArray[i] > 0 && numbersArray[i + 1] > 0))
                {
                    firstWayMinOperations++;
                    numbersArray[i + 1] *= -1;
                }
            }

            copy[0] *= -1;
            secondWayMinOperations++;

            for (int i = 1; i < copy.Length; i++) // Second Way
            {
                if ((copy[i] < 0 && copy[i - 1] < 0) ||
                    (copy[i] > 0 && copy[i - 1] > 0))
                {
                    secondWayMinOperations++;
                    copy[i] *= -1;
                }
            }

            Console.WriteLine(Math.Min(firstWayMinOperations, secondWayMinOperations));
        }
    }
}