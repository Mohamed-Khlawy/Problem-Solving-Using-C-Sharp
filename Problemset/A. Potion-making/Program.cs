namespace A._Potion_making
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1525/A
        public static int CalculateGCD(int a, int b)
        {
            while (b > 0)
            {
                (a, b) = (b, a % b);
            }

            return a;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int essencePercentage = int.Parse(Console.ReadLine()!);

                //Console.Write("********************** ");

                Console.WriteLine(100 / CalculateGCD(essencePercentage, 100));
            }
        }
    }
}
