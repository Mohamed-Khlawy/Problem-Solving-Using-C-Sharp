namespace C._Good_Prefixes
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1985/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                long prefix_sum = 0;

                long max_element = 0;

                long good_prefixes = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    prefix_sum += numbers[i];

                    if (numbers[i] > max_element)
                    {
                        max_element = numbers[i];
                    }

                    if (prefix_sum - max_element == max_element)
                    {
                        good_prefixes++;
                    }
                }

                //Console.Write("***************************** ");

                Console.WriteLine(good_prefixes);
            }
        }
    }
}
