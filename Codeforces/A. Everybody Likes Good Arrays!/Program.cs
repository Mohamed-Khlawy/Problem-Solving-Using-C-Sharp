namespace A._Everybody_Likes_Good_Arrays_
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1777/A
        public static bool SameParityOrNot(long a, long b)
        {
            if (a % 2 == b % 2) return true;

            return false;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                long[] numbers = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                int sameParityCounter = 0;

                for (int i = 0; i < size - 1; i++)
                {
                    sameParityCounter += SameParityOrNot(numbers[i], numbers[i + 1]) ? 1 : 0;
                }

                //Console.Write("******************** ");

                Console.WriteLine(sameParityCounter);
            }
        }
    }
}
