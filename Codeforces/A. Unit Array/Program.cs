namespace A._Unit_Array
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1834/A
        public static void MakeMinusOneCounterEven(int numberOfMinusOne, ref int minNumberOfOperations)
        {
            if (numberOfMinusOne % 2 == 0) return; /// Even Counter already so return

            else /// Odd Counter
            {
                minNumberOfOperations++;
            }
        }
        public static void MakePositiveBiggerThanOrEqualToNegative(
            int listSize, int numberOfOne, ref int numberOfMinusOne, ref int minNumberOfOperations)
        {
            int half = (int)Math.Ceiling((double)listSize / 2);

            minNumberOfOperations += half - numberOfOne;
            numberOfMinusOne -= half - numberOfOne;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int listSize = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int numberOfMinusOne = numbers.Where(number => number == -1).Count();
                int numberOfOne = listSize - numberOfMinusOne;

                int minNumberOfOperations = 0;

                if (listSize % 2 != 0) /// ODD Size
                {
                    if (numberOfMinusOne > numberOfOne)
                    {
                        MakePositiveBiggerThanOrEqualToNegative
                            (listSize, numberOfOne, ref numberOfMinusOne, ref minNumberOfOperations);
                    }

                    MakeMinusOneCounterEven(numberOfMinusOne, ref minNumberOfOperations);
                }

                else /// Even Size
                {
                    if (numberOfMinusOne > numberOfOne)
                    {
                        MakePositiveBiggerThanOrEqualToNegative
                            (listSize, numberOfOne, ref numberOfMinusOne, ref minNumberOfOperations);
                    }

                    MakeMinusOneCounterEven(numberOfMinusOne, ref minNumberOfOperations);
                }

                //Console.Write("*************************** ");

                Console.WriteLine(minNumberOfOperations);
            }
        }
    }
}
