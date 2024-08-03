namespace C._Vasilije_in_Cacak
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1878/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                long[] n_k_x = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long max_number_to_choose = n_k_x[0];
                long number_of_elements_to_choose = n_k_x[1];
                long needed_sum = n_k_x[2];

                // MIN_SUM = (k * (k + 1)) / 2

                // MAX_SUM = ((n * (n + 1)) - ((n - k) * (n - k + 1))) / 2


                long min_sum = (number_of_elements_to_choose *
                    (number_of_elements_to_choose + 1)) / 2;


                long max_sum = ((max_number_to_choose * (max_number_to_choose + 1)) -
                    (max_number_to_choose - number_of_elements_to_choose) *
                    (max_number_to_choose - number_of_elements_to_choose + 1)) / 2;

                //Console.Write("*** ");

                if (needed_sum <= max_sum && needed_sum >= min_sum)
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
