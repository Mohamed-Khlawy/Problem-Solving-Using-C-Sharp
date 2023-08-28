using System.Numerics;

namespace G._Summation_from_1_to_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            BigInteger n = BigInteger.Parse(elements[0]);
            BigInteger sum = (n * (n + 1)) / 2;
            Console.WriteLine(sum);
        }
    }
}