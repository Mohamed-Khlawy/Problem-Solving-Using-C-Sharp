namespace A._Orac_and_Factors
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1350/A
        public static int FindFirstDivisorForOddNumber(int oddNumber)
        {
            int divisor = 3;

            while (oddNumber % divisor != 0) divisor++;

            return divisor;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number = input[0];      /// n
                int addingTimes = input[1]; /// k

                long finalValue = number;

                if (number % 2 == 1) /// If the number was odd initially
                {
                    finalValue += FindFirstDivisorForOddNumber(oddNumber: number);
                    addingTimes--;
                }

                finalValue += 2 * addingTimes;

                //Console.Write("**************************** ");

                Console.WriteLine(finalValue);
            }
        }
    }
}
