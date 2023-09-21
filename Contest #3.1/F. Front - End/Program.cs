namespace F._Front___End
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int leftIndex = 0;
            int rightIndex = numbersArray.Length - 1;

            while (leftIndex <= rightIndex)
            {
                if (leftIndex != rightIndex)
                {
                    Console.Write(numbersArray[leftIndex] + " " + numbersArray[rightIndex] + " ");
                }
                else
                {
                    Console.Write(numbersArray[leftIndex]);
                }

                leftIndex++;
                rightIndex--;
            }
        }
    }
}