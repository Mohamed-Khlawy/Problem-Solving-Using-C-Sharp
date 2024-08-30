namespace A._Mocha_and_Math
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1559/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int result = numbers[0];

                for (int i = 1; i < numbers.Count; i++)
                {
                    result &= numbers[i];
                }

                Console.WriteLine(result);
            }
        }
    }
}
