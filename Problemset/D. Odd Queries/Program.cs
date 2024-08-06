namespace D._Odd_Queries
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1807/D
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] n_q = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long size_of_list = n_q[0];
                long number_of_queries = n_q[1];

                List<long> numbers = Console.ReadLine()!.Split().Select(long.Parse).ToList();

                long[] prefix_sum = new long[size_of_list + 1];

                for (int i = 1; i <= size_of_list; i++)
                {
                    prefix_sum[i] = prefix_sum[i - 1];
                    prefix_sum[i] += numbers[i - 1];
                }

                while (number_of_queries-- > 0)
                {
                    long[] l_r_k = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                    long left_index = l_r_k[0];
                    long right_index = l_r_k[1];
                    long number_for_change = l_r_k[2];

                    long sum_with_new_SubList = prefix_sum[size_of_list] -
                        (prefix_sum[right_index] - prefix_sum[left_index - 1]) +
                        number_for_change * (right_index - left_index + 1);

                    if (sum_with_new_SubList % 2 == 1)
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
}
