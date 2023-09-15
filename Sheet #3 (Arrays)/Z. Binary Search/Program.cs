namespace Z._Binary_Search
{
    internal class Program
    {
        static void BinarySearch(long[] array, int number)
        {
            int left = 0;
            int right = array.Length - 1;
            bool foundNumber = false;

            while (left <= right)
            {
                int medium = left + (right - left) / 2;

                if (array[medium] == number)
                {
                    foundNumber = true;
                    break;
                }

                if (array[medium] < number)
                {
                    left = medium + 1;
                }

                else
                {
                    right = medium - 1;
                }
            }

            if (!foundNumber)
            {
                Console.WriteLine("not found");
            }

            else
            {
                Console.WriteLine("found");
            }
        }
        static void Main(string[] args)
        {
            int[] arraySize_numberOfQueries = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int arraySize = arraySize_numberOfQueries[0];
            int numberOfQueries = arraySize_numberOfQueries[1];

            long[] numbersArray = Console.ReadLine()!.Split().Select(long.Parse).ToArray();
            Array.Sort(numbersArray);

            while (numberOfQueries-- > 0)
            {
                int numberForSearch = int.Parse(Console.ReadLine()!);

                BinarySearch(numbersArray, numberForSearch);
            }
        }
    }
}