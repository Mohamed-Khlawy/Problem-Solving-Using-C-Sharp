namespace A._Strange_Partition
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1471/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] input = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long listSize = input[0];    /// n
                long fixedNumber = input[1]; /// x

                List<long> numbers = Console.ReadLine()!.Split().Select(long.Parse).ToList();

                long minBeauty = (long)Math.Ceiling((double)numbers.Sum() / fixedNumber);

                long maxBeauty =
                    numbers.Sum(number => (long)Math.Ceiling((double)number / fixedNumber));

                //Console.Write("***************** ");

                Console.WriteLine(minBeauty + " " + maxBeauty);
            }
        }
    }
}
