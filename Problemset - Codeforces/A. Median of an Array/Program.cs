namespace A._Median_of_an_Array
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1946/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                Array.Sort(numbers);

                int medianIndex = arraySize % 2 == 0 ? arraySize / 2 - 1 : arraySize / 2;

                int medianNumber = numbers[medianIndex];

                int minOperations = 1;

                for (int i = medianIndex + 1; i < arraySize; i++)
                {
                    if (numbers[i] == medianNumber) minOperations++;

                    else break;
                }

                //Console.Write("****************************** ");

                Console.WriteLine(minOperations);
            }
        }
    }
}
