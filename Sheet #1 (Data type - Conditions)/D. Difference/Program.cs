using System.Numerics;

namespace D._Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            BigInteger first = BigInteger.Parse(elements[0]);
            BigInteger second = BigInteger.Parse(elements[1]);
            BigInteger third = BigInteger.Parse(elements[2]);
            BigInteger fourth = BigInteger.Parse(elements[3]);

            BigInteger right = third * fourth;
            BigInteger left = first * second;

            BigInteger difference = left - right;

            Console.WriteLine($"Difference = {difference}");
        }
    }
}