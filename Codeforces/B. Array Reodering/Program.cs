namespace B._Array_Reodering
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1535/B

        static bool is_GCD_equal_1(int first, int second)
        {
            int copy_first = first;
            int copy_second = second;

            while (second != 0)
            {
                int temp = first;
                first = second;
                second = temp % second;
            }

            if (first > 1)
            {
                return true;
            }

            else
            {
                copy_first *= 2;
                copy_second /= 2;

                while (copy_first != 0)
                {
                    int temp = copy_second;
                    copy_second = copy_first;
                    copy_first = temp % copy_first;
                }

                if (copy_second > 1)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int good_pairs = 0;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    for (int j = i + 1; j < numbers.Count; j++)
                    {
                        if (is_GCD_equal_1(numbers[i], numbers[j] * 2))
                        {
                            good_pairs++;
                        }
                    }
                }

                //Console.Write("**************************************** ");

                Console.WriteLine(good_pairs);
            }
        }
    }
}
