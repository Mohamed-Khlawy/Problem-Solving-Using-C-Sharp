namespace C._Minimum_Extraction
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1607/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                Array.Sort(numbers);

                int maxMinimumElement = numbers[0];

                for (int i = 1; i < arraySize; i++)
                {
                    maxMinimumElement =
                        Math.Max(maxMinimumElement, numbers[i] - numbers[i - 1]);
                }

                //Console.Write("********************* ");

                Console.WriteLine(maxMinimumElement);
            }
        }
    }
}
