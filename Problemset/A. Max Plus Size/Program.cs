namespace A._Max_Plus_Size
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2019/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int halfOne = (int)Math.Ceiling((decimal)arraySize / 2);
                int halfTwo = arraySize - halfOne;

                int totalSum = numbers.Sum();
                int maxNumber = numbers.Max();

                bool foundMaxInHalfOne = false;

                for (int i = 0; i < arraySize; i += 2)
                {
                    if (numbers[i] == maxNumber)
                    {
                        foundMaxInHalfOne = true;
                        break;
                    }
                }

                if (foundMaxInHalfOne)
                {
                    halfOne += maxNumber;
                }

                else
                {
                    halfTwo += maxNumber;
                }

                //Console.Write("***************************** ");

                Console.WriteLine(Math.Max(halfOne, halfTwo));
            }
        }
    }
}
