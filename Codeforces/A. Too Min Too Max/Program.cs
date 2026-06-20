namespace A._Too_Min_Too_Max
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1934/A
        public static long CalculateMaxValue(int i, int j, int k, int l, int[] numbersArray)
        {
            return Math.Abs(numbersArray[i] - numbersArray[j]) +
                   Math.Abs(numbersArray[j] - numbersArray[k]) +
                   Math.Abs(numbersArray[k] - numbersArray[l]) +
                   Math.Abs(numbersArray[l] - numbersArray[i]);
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                Array.Sort(numbers);

                long maxValue =
                    CalculateMaxValue(i: 0, j: arraySize - 2, k: 1, l: arraySize - 1, numbers);

                //Console.Write("************************** ");

                Console.WriteLine(maxValue);
            }
        }
    }
}
