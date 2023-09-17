namespace B._Reversing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] == 0)
                {
                    Array.Reverse(numbersArray, 0, i);
                }
            }

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.Write(numbersArray[i] + " ");
            }
        }
    }
}