namespace Y._Range_sum_query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraySize_numberOfQueries = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int arraySize = arraySize_numberOfQueries[0];
            int numberOfQueries = arraySize_numberOfQueries[1];

            long[] numbersArray = Console.ReadLine()!.Split().Select(long.Parse).ToArray();
            long[] prefixSumArray = new long[arraySize];

            prefixSumArray[0] = numbersArray[0];

            for (int i = 1; i < arraySize; i++)
            {
                prefixSumArray[i] = numbersArray[i] + prefixSumArray[i - 1];
            }

            while (numberOfQueries-- > 0)
            {
                int[] left_right = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int left = left_right[0] - 1;
                int right = left_right[1] - 1;

                long rangeSum = prefixSumArray[right] - (left > 0 ? prefixSumArray[left - 1] : 0);

                Console.WriteLine(rangeSum);
            }
        }
    }
}