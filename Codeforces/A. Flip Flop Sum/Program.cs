namespace A._Flip_Flop_Sum
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1778/A
        public static bool IsTheNextMinusOne(int next)
        {
            return next == -1;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                long arraySum = 0;

                bool weFoundOneMinusOne = false;
                bool weFound2ConsectuiveMinusOnes = false;

                for (int i = 0; i < arraySize; i++)
                {
                    if (numbers[i] == -1 && !weFound2ConsectuiveMinusOnes)
                    {
                        weFoundOneMinusOne = true;

                        if (i < arraySize - 1 && IsTheNextMinusOne(numbers[i + 1]))
                        {
                            arraySum += 2;
                            weFound2ConsectuiveMinusOnes = true;
                            i++; // Skip the next -1 since we already counted it
                        }

                        else arraySum += numbers[i];
                    }

                    else arraySum += numbers[i];
                }

                if (!weFound2ConsectuiveMinusOnes && !weFoundOneMinusOne)
                {
                    // If we didn't find any -1, we subtract 4
                    arraySum -= 4;
                }

                //Console.Write("**************************** ");

                Console.WriteLine(arraySum);
            }
        }
    }
}
