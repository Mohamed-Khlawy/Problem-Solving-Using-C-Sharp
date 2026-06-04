namespace A._Sum_of_2050
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1517/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long number = long.Parse(Console.ReadLine()!);

                //Console.Write("*********************** ");

                if (number % 2050 != 0)
                {
                    Console.WriteLine(-1);
                    continue;
                }

                int[] dividingResult = (number / 2050).ToString()
                    .Select(digit => int.Parse(digit.ToString())).ToArray();

                long digitsSum = dividingResult.Sum();


                Console.WriteLine(digitsSum);
            }
        }
    }
}
