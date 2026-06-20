namespace B._The_Third_Side
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2074/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                //int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

                int maxLastValue = numbers.Sum() - (arraySize - 1);

                //Console.Write("********************** ");

                Console.WriteLine(maxLastValue);
            }
        }
    }
}
