namespace A._Nearest_Interesting_Number
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1183/A
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()!);

            int[] next10Numbers = Enumerable.Range(number, 10).ToArray();

            int divisibleBy4Index = 0;

            while (divisibleBy4Index < 10)
            {
                int digitsSum =
                    next10Numbers[divisibleBy4Index]
                    .ToString()
                    .Select(digit => int.Parse(digit.ToString()))
                    .Sum();

                if (digitsSum % 4 == 0)
                {
                    break;
                }

                divisibleBy4Index++;
            }

            //Console.Write("******************** ");

            Console.WriteLine(next10Numbers[divisibleBy4Index]);
        }
    }
}
