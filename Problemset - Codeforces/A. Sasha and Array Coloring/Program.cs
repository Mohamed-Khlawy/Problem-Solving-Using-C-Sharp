namespace A._Sasha_and_Array_Coloring
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1843/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                if (numbers.Count == 1)
                {
                    Console.WriteLine(0);
                }

                else
                {
                    numbers.Sort();

                    int left = numbers.Count - 1;
                    int right = 0;
                    long result = 0;

                    while (left > right)
                    {
                        result += numbers[left] - numbers[right];

                        left--;
                        right++;
                    }

                    Console.WriteLine(result);
                }
            }
        }
    }
}
