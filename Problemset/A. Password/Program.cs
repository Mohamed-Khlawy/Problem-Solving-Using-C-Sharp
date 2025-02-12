namespace A._Password
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1743/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfUnUsedDigits = int.Parse(Console.ReadLine()!);

                int[] unUsedDigits = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfUsedDigits = 10 - numberOfUnUsedDigits;

                int possiblePasswords = numberOfUsedDigits * (numberOfUsedDigits - 1) / 2 * 6;

                //Console.Write("*************************** ");

                Console.WriteLine(possiblePasswords);
            }
        }
    }
}
