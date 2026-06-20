namespace A._Long_Comparison
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1613/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] number1Description =
                    Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                long[] number2Description =
                    Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                long number1Integer = number1Description[0]; /// x1
                long number1Zeros = number1Description[1];   /// p1
                long number2Integer = number2Description[0]; /// x2
                long number2Zeros = number2Description[1];   /// p2

                long minZeros = Math.Min(number1Zeros, number2Zeros);

                number1Zeros -= minZeros;
                number2Zeros -= minZeros;

                //Console.Write("******************** ");

                if (number1Zeros >= 7)
                {
                    Console.WriteLine(">");
                }

                else if (number2Zeros >= 7)
                {
                    Console.WriteLine("<");
                }
                else
                {
                    for (int i = 0; i < number1Zeros; i++) number1Integer *= 10;
                    for (int i = 0; i < number2Zeros; i++) number2Integer *= 10;

                    if (number1Integer > number2Integer)
                    {
                        Console.WriteLine(">");
                    }
                    else if (number1Integer < number2Integer)
                    {
                        Console.WriteLine("<");
                    }
                    else
                    {
                        Console.WriteLine("=");
                    }
                }
            }
        }
    }
}
