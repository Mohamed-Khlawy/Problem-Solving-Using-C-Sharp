namespace A._Hexadecimal_s_theorem
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/199/A

        public static List<long> CreateFibonacci(int maxElement)
        {
            List<long> FibonacciList = new List<long>() { 0, 1 };

            long lastNumber = 0;
            long beforeLastNumber = 1;

            long fibonacciValue = lastNumber + beforeLastNumber;

            while (fibonacciValue <= maxElement)
            {
                FibonacciList.Add(fibonacciValue);

                (lastNumber, beforeLastNumber) = (beforeLastNumber, fibonacciValue);

                fibonacciValue = lastNumber + beforeLastNumber;
            }

            return FibonacciList;
        }


        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()!);

            List<long> Fibonacci = CreateFibonacci(number);

            //Console.Write("*********************** ");

            if (number == 0)
            {
                Console.WriteLine($"0 0 0");
                return;
            }

            Console.WriteLine((Fibonacci[^1] == number) ?
                $"0 {Fibonacci[^3]} {Fibonacci[^2]}" : "I'm too stupid to solve this problem");
        }
    }
}
