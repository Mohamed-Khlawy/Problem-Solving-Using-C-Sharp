namespace B._Good_Arrays
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1856/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                int onesSum = 0;
                long nonOnesSum = 0;

                for (int i = 0; i < arraySize; i++)
                {
                    if (numbers[i] == 1) onesSum++;

                    else nonOnesSum += numbers[i] - 1;
                }

                //Console.Write("******************* ");

                Console.WriteLine(nonOnesSum > onesSum && arraySize > 1 ? "YES" : "NO");
            }
        }
    }
}
