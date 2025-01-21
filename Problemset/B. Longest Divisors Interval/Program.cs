namespace B._Longest_Divisors_Interval
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1855/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long number = long.Parse(Console.ReadLine()!);

                int max_interval_size = 1;

                for (long i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        max_interval_size++;
                    }

                    else
                    {
                        break;
                    }
                }

                //Console.Write("******************************* ");

                Console.WriteLine(max_interval_size);
            }
        }
    }
}
