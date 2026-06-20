namespace A._Tales_of_a_Sort
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1856/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int[] sortedNumbers = new int[arraySize];

                bool theyAreSorted = true;

                int numberOfOperations = 0;

                Array.Copy(numbers, sortedNumbers, arraySize);

                Array.Sort(sortedNumbers);

                for (int i = arraySize - 1; i >= 0; i--)
                {
                    if (numbers[i] != sortedNumbers[i])
                    {
                        theyAreSorted = false;
                        numberOfOperations = sortedNumbers[i];
                        break;
                    }
                }

                //Console.Write("*********************** ");

                Console.WriteLine(theyAreSorted ? 0 : numberOfOperations);
            }
        }
    }
}
