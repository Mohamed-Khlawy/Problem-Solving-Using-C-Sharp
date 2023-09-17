namespace C._Choose_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraySize_maxElements = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int arraySize = arraySize_maxElements[0];
            int maxElements = arraySize_maxElements[1];

            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            Array.Sort(numbersArray);

            long maxSummation = 0;
            int index = numbersArray.Length - 1;

            while (maxElements > 0)
            {
                if (maxSummation < numbersArray[index] + maxSummation)
                {
                    maxSummation += numbersArray[index];
                }
                index--;
                maxElements--;
            }

            if (maxSummation <= 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(maxSummation);
            }
        }
    }
}