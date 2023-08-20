using System.Numerics;

namespace U._Some_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;
            string[] elements = input.Split(' ');

            int n = int.Parse(elements[0].ToString());
            int a = int.Parse(elements[1].ToString());
            int b = int.Parse(elements[2].ToString());
            BigInteger sum = 0;

            while (n > 0)
            {
                int copy_n = n;
                int digitsSum = 0;

                while (copy_n > 0)
                {
                    digitsSum += copy_n % 10;
                    copy_n /= 10;
                }

                if (digitsSum >= a && digitsSum <= b)
                {
                    sum += n;
                }

                n--;
            }

            Console.WriteLine(sum);
        }
    }
}