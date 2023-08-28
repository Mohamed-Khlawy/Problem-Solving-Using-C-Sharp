using System.Numerics;

namespace C._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');
            BigInteger first = BigInteger.Parse(elements[0]);
            BigInteger second = BigInteger.Parse(elements[1]);
            BigInteger add = first + second;
            BigInteger mul = first * second;
            BigInteger sub = first - second;
            Console.WriteLine(first + " + " + second + " = " + add);
            Console.WriteLine(first + " * " + second + " = " + mul);
            Console.WriteLine(first + " - " + second + " = " + sub);
        }
    }
}