namespace M._Replace_MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int indexOfMinNumber = Array.IndexOf(numbersArray, numbersArray.Min());
            int indexOfMaxNumber = Array.IndexOf(numbersArray, numbersArray.Max());

            (numbersArray[indexOfMinNumber], numbersArray[indexOfMaxNumber]) =
                (numbersArray[indexOfMaxNumber], numbersArray[indexOfMinNumber]);

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.Write(numbersArray[i] + " ");
            }
        }
    }
}