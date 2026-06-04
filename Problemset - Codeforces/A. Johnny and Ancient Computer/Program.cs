namespace A._Johnny_and_Ancient_Computer
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1362/A
        public static void MakeTargetBigger(ref long initialValue, ref long targetValue)
        {
            if (initialValue > targetValue)
            {
                (initialValue, targetValue) = (targetValue, initialValue);
            }
        }
        public static int CountNumberOfOperations(long dividingResult)
        {
            int[] divideNumbers = new int[] { 2, 4, 8 };

            int operationsCounter = 0;

            while (dividingResult > 1)
            {
                bool weDivideSuccessfully = false;

                for (int i = 2; i >= 0; i--)
                {
                    if (dividingResult % divideNumbers[i] == 0)
                    {
                        dividingResult /= divideNumbers[i];
                        operationsCounter++;
                        weDivideSuccessfully = true;
                        break;
                    }
                }

                if (!weDivideSuccessfully)
                {
                    operationsCounter = -1;
                    break;
                }
            }

            return operationsCounter;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] input = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long initialValue = input[0]; /// a
                long targetValue = input[1];  /// b

                MakeTargetBigger(ref initialValue, ref targetValue);

                int minOperations = -1;

                if (initialValue == targetValue) minOperations = 0;

                else if (targetValue % initialValue == 0)
                {
                    minOperations = CountNumberOfOperations(targetValue / initialValue);
                }

                //Console.Write("************************ ");

                Console.WriteLine(minOperations);
            }
        }
    }
}
