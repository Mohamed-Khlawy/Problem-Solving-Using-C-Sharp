using System.Numerics;

namespace Y._Easy_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lastIndex = int.Parse(Console.ReadLine()!);
            BigInteger[] fibonacci = new BigInteger[lastIndex];

            if (lastIndex == 1)
            {
                Console.WriteLine(0);
                return;
            }

            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.Write(fibonacci[i] + " ");
            }
        }
    }
}