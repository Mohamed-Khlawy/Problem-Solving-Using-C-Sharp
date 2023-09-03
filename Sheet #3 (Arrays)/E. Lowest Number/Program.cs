namespace E._Lowest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int minNumber = numbersArray.Min();
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] == minNumber)
                {
                    Console.WriteLine($"{numbersArray[i]} {i + 1}");
                    break;
                }
            }
        }
    }
}