namespace B._Karina_and_Array
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1822/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                long[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);

                Array.Sort(numbers);

                long maxBeauty = Math.Max(numbers[0] * numbers[1], numbers[^1] * numbers[^2]);

                //Console.Write("******************* ");

                Console.WriteLine(maxBeauty);
            }
        }
    }
}
