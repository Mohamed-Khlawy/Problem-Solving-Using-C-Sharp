namespace B._Maximum_Multiple_Sum
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1985/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int n = int.Parse(Console.ReadLine()!);

                long max_sum = 0;
                int good_i = 0;

                for (int i = 2; i <= n; i++)
                {
                    long i_sum = i;

                    int j = 2;

                    while (j * i <= n)
                    {
                        i_sum += j * i;
                        j++;
                    }

                    if (i_sum > max_sum)
                    {
                        max_sum = i_sum;
                        good_i = i;
                    }
                }

                Console.WriteLine(good_i);
            }
        }
    }
}
