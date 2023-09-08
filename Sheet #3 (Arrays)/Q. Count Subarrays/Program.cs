namespace Q._Count_Subarrays
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
                int subArraysCounter = 0;

                for (int i = 0; i < numbersArray.Length; i++)
                {
                    int lastNumber = numbersArray[i];
                    for (int j = i; j < numbersArray.Length; j++)
                    {
                        if (numbersArray[j] < lastNumber)
                        {
                            break;
                        }
                        else
                        {
                            subArraysCounter++;
                            lastNumber = numbersArray[j];
                        }
                    }
                }

                Console.WriteLine(subArraysCounter);
            }
        }
    }
}