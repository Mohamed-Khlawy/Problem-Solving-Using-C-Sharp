namespace A._Cherry
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1554/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                long max_multiplication = 1;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    long current_multiplication = (long)numbers[i] * numbers[i + 1];

                    if (current_multiplication > max_multiplication)
                    {
                        max_multiplication = current_multiplication;
                    }
                }

                //Console.Write("**************************************** ");

                Console.WriteLine(max_multiplication);
            }
        }
    }
}
