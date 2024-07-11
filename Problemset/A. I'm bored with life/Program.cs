namespace A._I_m_bored_with_life
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/822/A
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int first_number = numbers[0];
            int second_number = numbers[1];

            long result = 1;

            for (int i = 1; i <= Math.Min(first_number, second_number); i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
