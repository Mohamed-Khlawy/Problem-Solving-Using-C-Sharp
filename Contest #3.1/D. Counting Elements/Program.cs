namespace D._Counting_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            long counter = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray.Contains(numbersArray[i] + 1))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}