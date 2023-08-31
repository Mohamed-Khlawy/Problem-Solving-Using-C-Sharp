namespace D._Positions_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] <= 10)
                {
                    Console.WriteLine($"A[{i}] = {numbersArray[i]}");
                }
            }
        }
    }
}