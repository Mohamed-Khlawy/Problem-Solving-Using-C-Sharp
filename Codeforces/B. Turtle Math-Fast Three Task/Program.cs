namespace B._Turtle_Math_Fast_Three_Task
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1933/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                long sum = 0;

                bool element_divisible_by_3 = false;

                foreach (int number in numbers)
                {
                    sum += number;

                    if (number % 3 == 1)
                    {
                        element_divisible_by_3 = true;
                    }
                }

                if (sum % 3 == 0)
                {
                    Console.WriteLine(0);
                }

                else if (sum % 3 == 2)
                {
                    Console.WriteLine(1);
                }

                else if (sum % 3 == 1)
                {
                    if (element_divisible_by_3)
                    {
                        Console.WriteLine(1);
                    }

                    else
                    {
                        Console.WriteLine(2);
                    }
                }
            }
        }
    }
}
