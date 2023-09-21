namespace G._Even_Hate_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);
                int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                if (numbersArray.Length % 2 != 0) //Odd size, so even won't be equal to odd
                {
                    Console.WriteLine(-1);
                }

                else
                {
                    int evenCounter = 0;
                    int oddCounter = 0;

                    for (int i = 0; i < numbersArray.Length; i++)
                    {
                        if (numbersArray[i] % 2 != 0)
                        {
                            oddCounter++;
                        }
                        else
                        {
                            evenCounter++;
                        }
                    }

                    Console.WriteLine((numbersArray.Length / 2) - Math.Min(evenCounter, oddCounter));
                }
            }
        }
    }
}