namespace F._Reversing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            //Array.Reverse(numbersArray); //Easy way to reverse
            int[] reversedArray = new int[size];
            for (int i = size - 1, j = 0; i >= 0; i--, j++)
            {
                reversedArray[j] = numbersArray[i];
                Console.Write(reversedArray[j] + " ");
            }
        }
    }
}