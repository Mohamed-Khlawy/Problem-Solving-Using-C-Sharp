namespace C._Make_Equal_Again
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1931/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int first_number = numbers[0];
                int last_number = numbers[numbers.Count - 1];

                int equal_counter_from_start = 0;
                int equal_counter_from_end = 0;

                int left_index = 0;
                int right_index = size - 1;

                int min_burles = 0;

                while (equal_counter_from_start < size &&
                      numbers[left_index] == first_number)
                {
                    equal_counter_from_start++;
                    left_index++;
                }

                while (equal_counter_from_end < size &&
                      numbers[right_index] == last_number)
                {
                    equal_counter_from_end++;
                    right_index--;
                }

                if (first_number == last_number)
                {
                    min_burles = size - (equal_counter_from_start + equal_counter_from_end);
                }

                else
                {
                    int max_in_equality = Math.Max(equal_counter_from_start, equal_counter_from_end);

                    min_burles = size - max_in_equality;
                }

                //Console.Write("*************************************** ");

                Console.WriteLine(Math.Max(0, min_burles));
            }
        }
    }
}
