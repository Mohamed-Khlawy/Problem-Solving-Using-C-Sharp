using System.Numerics;

namespace C._Finding_Minimums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberOfValues_sizeOfGroups = Console.ReadLine()!;
            string[] inputArray = numberOfValues_sizeOfGroups.Split(' ');

            int numberOfValues = int.Parse(inputArray[0]);
            int sizeOfGroups = int.Parse(inputArray[1]);

            string array = Console.ReadLine()!;
            string[] stringArray = array.Split(' ');
            BigInteger[] arrayOfNmbers;

            if (sizeOfGroups > numberOfValues)
            {
                arrayOfNmbers = new BigInteger[numberOfValues];
            }

            else
            {
                arrayOfNmbers = new BigInteger[sizeOfGroups];
            }
            //0  1 2 3 4 5 6 7
            for (BigInteger i = 0; i < numberOfValues; i++)//4 -1 2 3 5 0 2 7
            {
                arrayOfNmbers[(int)i % sizeOfGroups] = BigInteger.Parse(stringArray[(int)i]);
                if ((i + 1) % sizeOfGroups == 0 || i + 1 == numberOfValues)
                {
                    Console.Write(arrayOfNmbers.Min() + " ");
                    if (numberOfValues - i - 1 >= sizeOfGroups)
                    {
                        continue;
                    }
                    else
                    {
                        arrayOfNmbers = new BigInteger[(int)(numberOfValues - i - 1)];
                    }
                }
            }
        }
    }
}