using System.Numerics;

namespace S._Sum_of_Consecutive_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while(tests--  > 0)
            {
                string numbers = Console.ReadLine()!;
                string[] inputs = numbers.Split(' ');

                int number1 = Math.Min(int.Parse(inputs[0]), int.Parse(inputs[1]));
                int number2 = Math.Max(int.Parse(inputs[0]), int.Parse(inputs[1]));
                BigInteger sum = 0;

                for (int i = number1 + 1; i < number2; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}