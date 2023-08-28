using System.Numerics;

namespace F._Digits_Summation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            BigInteger first = BigInteger.Parse(elements[0][elements[0].Length - 1].ToString());
            BigInteger second = BigInteger.Parse(elements[1][elements[1].Length - 1].ToString());

            BigInteger add = first + second;
            Console.WriteLine(add);
        }
    }
}