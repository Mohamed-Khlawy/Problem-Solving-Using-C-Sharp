namespace A._Consecutive_Sum_Riddle
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1594/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long prefixSumResult = long.Parse(Console.ReadLine()!);

                //Console.Write("******************** ");

                Console.WriteLine
                    ($"{(prefixSumResult - 1) * -1} {prefixSumResult}");
            }
        }
    }
}
