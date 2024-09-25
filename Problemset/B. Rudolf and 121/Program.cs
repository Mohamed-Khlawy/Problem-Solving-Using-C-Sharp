namespace B._Rudolf_and_121
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1941/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                bool can_make_all_zero = true;

                for (int i = 0; i < numbers.Count - 2; i++)
                {
                    if (numbers[i] < 0)
                    {
                        can_make_all_zero = false;
                        break;
                    }

                    else if (numbers[i] > 0)
                    {
                        int temp = numbers[i];

                        numbers[i] -= temp;
                        numbers[i + 1] -= 2 * temp;
                        numbers[i + 2] -= temp;
                    }
                }

                if (numbers[numbers.Count - 1] == 0 && numbers[numbers.Count - 2] == 0 &&
                    can_make_all_zero)
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
