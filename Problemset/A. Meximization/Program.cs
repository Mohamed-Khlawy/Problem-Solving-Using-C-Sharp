namespace A._Meximization
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1497/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int[] numbersFreqency = new int[101];

                int[] newNumbers = new int[arraySize];

                int newNumbersIndex = 0;

                bool weWillLoopAgain = true;

                foreach (int number in numbers)
                {
                    numbersFreqency[number]++;
                }

                while (weWillLoopAgain)
                {
                    weWillLoopAgain = false;

                    for (int i = 0; i < 101; i++)
                    {
                        if (numbersFreqency[i] > 0)
                        {
                            newNumbers[newNumbersIndex++] = i;
                            numbersFreqency[i]--;
                        }

                        if (!weWillLoopAgain)
                        {
                            weWillLoopAgain = numbersFreqency[i] > 0;
                        }
                    }
                }

                //Console.Write("********************************* ");

                Console.WriteLine(string.Join(" ", newNumbers));
            }
        }
    }
}
