namespace B._Triple
{
    internal class Program
    {
        //Proplem Link: https://codeforces.com/problemset/problem/1669/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);
                int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                Array.Sort(numbersArray);
                bool foundTriple = false;

                for (int i = 0; i < numbersArray.Length - 2; i++)
                {
                    if (numbersArray[i] == numbersArray[i + 1] && numbersArray[i] == numbersArray[i + 2])
                    {
                        Console.WriteLine(numbersArray[i]);
                        foundTriple = true;
                        break;
                    }
                }

                if (!foundTriple)
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}