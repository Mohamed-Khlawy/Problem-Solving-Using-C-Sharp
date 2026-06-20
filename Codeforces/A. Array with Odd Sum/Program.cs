namespace A._Array_with_Odd_Sum
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1296/A
        // It was hard and i saw it's Tutorial
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);
                int[] numbersArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                long arraySum = 0;
                bool foundOdd = false;
                bool foundEven = false;

                for (int i = 0; i < numbersArray.Length; i++)
                {
                    arraySum += numbersArray[i];

                    if (numbersArray[i] % 2 != 0)
                    {
                        foundOdd = true;
                    }
                    else
                    {
                        foundEven = true;
                    }
                }

                if (arraySum % 2 != 0 || (foundEven && foundOdd))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}