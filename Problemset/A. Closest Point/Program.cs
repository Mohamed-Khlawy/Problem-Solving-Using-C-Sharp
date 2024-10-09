namespace A._Closest_Point
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2004/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                List<int> unique_numbers = new List<int>();

                bool can_we = true;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (!unique_numbers.Contains(numbers[i]))
                    {
                        unique_numbers.Add(numbers[i]);
                    }

                    if (unique_numbers.Count > 2)
                    {
                        can_we = false;
                        break;
                    }
                }

                if (can_we)
                {
                    if (unique_numbers.Count == 1 ||
                        (unique_numbers.Count == 2 &&
                        Math.Abs(unique_numbers[0] - unique_numbers[1]) > 1))
                    {
                        Console.WriteLine("YES");
                    }

                    else
                    {
                        Console.WriteLine("NO");
                    }
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
