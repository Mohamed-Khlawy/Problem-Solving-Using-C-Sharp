namespace H._Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int minIndex = 0;

            for (int i = 0; i < size; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < size; j++)
                {
                    if (numbersArray[j] < numbersArray[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // New way to swap 
                (numbersArray[minIndex], numbersArray[i]) = (numbersArray[i], numbersArray[minIndex]);

                // Original swap
                //int temp = numbersArray[i];
                //numbersArray[i] = numbersArray[minIndex];
                //numbersArray[minIndex] = temp;
            }

            for (int i = 0; i < size; ++i)
            {
                Console.Write(numbersArray[i] + " ");
            }
        }
    }
}