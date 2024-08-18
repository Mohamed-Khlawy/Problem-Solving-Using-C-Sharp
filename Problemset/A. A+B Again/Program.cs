namespace A._A_B_Again
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1999/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> number = Console.ReadLine()!.Select(s => int.Parse(s.ToString())).ToList();

                int sum_of_digits = number.Sum();

                Console.WriteLine(sum_of_digits);
            }
        }
    }
}
