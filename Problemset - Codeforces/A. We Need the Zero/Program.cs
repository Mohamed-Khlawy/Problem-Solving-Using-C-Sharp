namespace A._We_Need_the_Zero
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1805/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int arrayXOR = numbers.Aggregate(0, (accessor, current) => accessor ^ current);

                //Console.Write("***************************** ");

                Console.WriteLine((arraySize % 2 == 1 || (arraySize % 2 == 0 && arrayXOR == 0))
                    ? arrayXOR
                    : -1);
            }
        }
    }
}
