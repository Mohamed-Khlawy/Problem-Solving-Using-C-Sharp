using System.Numerics;

namespace Y._The_last_2_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            BigInteger res = 1;
            for (int i = 0; i < elements.Length; i++)
            {
                res *= BigInteger.Parse(elements[i]);
            }
            BigInteger[] last2Digits = new BigInteger[2];
            for (int i = 0; i < 2; i++)
            {
                last2Digits[i] = (BigInteger)res % 10;
                res /= 10;
            }
            Array.Reverse(last2Digits);
            for (int i = 0; i < 2; i++)
            {
                Console.Write(last2Digits[i]);
            }
        }
    }
}