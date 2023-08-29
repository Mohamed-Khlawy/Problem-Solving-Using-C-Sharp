namespace B._Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int numberForSearch = int.Parse(Console.ReadLine()!);

            if (numbersArray.Contains(numberForSearch))
            {
                for(int i = 0; i < numbersArray.Length; i++)
                {
                    if (numbersArray[i] == numberForSearch)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}