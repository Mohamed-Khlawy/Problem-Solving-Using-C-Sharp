namespace P._Minimize_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            bool foundOdd = false;
            int dividesCounter = 0;

            while (true)
            {
                for (int i = 0; i < numbersArray.Length; i++)
                {
                    if (numbersArray[i] % 2 == 0)
                    {
                        numbersArray[i] /= 2;
                    }
                    else
                    {
                        foundOdd = true;
                        break;
                    }
                }

                if (foundOdd)
                {
                    break;
                }
                else
                {
                    dividesCounter++;
                }
            }

            Console.WriteLine(dividesCounter);
        }
    }
}