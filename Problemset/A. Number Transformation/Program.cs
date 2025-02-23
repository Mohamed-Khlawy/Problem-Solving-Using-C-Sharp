namespace A._Number_Transformation
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1674/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int firstNumber = input[0];  /// x
                int secondNumber = input[1]; /// y

                Tuple<int, int> powerAndDivisor = new Tuple<int, int>(0, 0);

                //Console.Write("***************************** ");

                if (firstNumber <= secondNumber && secondNumber % firstNumber == 0)
                {
                    Console.WriteLine(powerAndDivisor.Item1 + 1 + " " +
                        (powerAndDivisor.Item2 + (secondNumber / firstNumber)));
                    continue;
                }

                Console.WriteLine(powerAndDivisor.Item1 + " " + powerAndDivisor.Item2);
            }
        }
    }
}
