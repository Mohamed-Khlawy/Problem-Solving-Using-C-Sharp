using System.Numerics;

namespace G._Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int n = int.Parse(Console.ReadLine()!);
                BigInteger result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                Console.WriteLine(result);
            }
        }
    }
}