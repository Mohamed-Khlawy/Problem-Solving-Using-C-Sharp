namespace J._Lucky_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int minElement = numbersArray.Min();
            int frequencyOfMinElement = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] == minElement)
                {
                    frequencyOfMinElement++;
                }
            }

            if (frequencyOfMinElement % 2 != 0) // Odd Frequency
            {
                Console.WriteLine("Lucky");
            }
            else // Even Frequency
            {
                Console.WriteLine("Unlucky");
            }
        }
    }
}