namespace A._Two_Groups
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1747/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                long[] numbers = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long numbersSum = numbers.Sum();

                //Console.Write("******************* ");

                Console.WriteLine(Math.Abs(numbersSum));
            }
        }
    }
}
