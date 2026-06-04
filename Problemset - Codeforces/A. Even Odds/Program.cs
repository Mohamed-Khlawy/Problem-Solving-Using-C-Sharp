using System.Numerics;

namespace A._Even_Odds
{
    internal class Program
    {
        // Problem Link: https://codeforces.com/problemset/problem/318/A
        // This problem wath hard on me
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;
            string[] inputArray = input.Split(' ');

            BigInteger lastNumber = BigInteger.Parse(inputArray[0]);
            BigInteger indexOfNumber = BigInteger.Parse(inputArray[1]);

            BigInteger half = (lastNumber + 1) / 2;

            if (indexOfNumber <= half)//The number is in odd half
            {
                Console.WriteLine((2 * indexOfNumber) - 1);
            }
            else//The number is in even half
            {
                Console.WriteLine(2 * (indexOfNumber - half));
            }
        }
    }
}