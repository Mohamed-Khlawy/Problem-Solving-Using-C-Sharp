using System.Numerics;

namespace W._Mathematical_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            int first = int.Parse(elements[0]);
            int second = int.Parse(elements[2]);
            BigInteger result = BigInteger.Parse(elements[4]);

            switch (elements[1])
            {
                case "+":
                    if (first + second == result)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        result = first + second;
                        Console.WriteLine(result);
                    }
                    break;
                case "-":
                    if (first - second == result)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        result = first - second;
                        Console.WriteLine(result);
                    }
                    break;
                case "*":
                    if (first * second == result)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        result = first * second;
                        Console.WriteLine(result);
                    }
                    break;
            }
        }
    }
}