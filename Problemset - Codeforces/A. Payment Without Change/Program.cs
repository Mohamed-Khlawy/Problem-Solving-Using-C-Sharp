namespace A._Payment_Without_Change
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1256/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] a_b_n_S = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_coins_of_n = a_b_n_S[0]; // a
                int number_of_coins_of_1 = a_b_n_S[1]; // b
                int value_of_n = a_b_n_S[2]; // n
                int required_total_value = a_b_n_S[3]; // S

                long total_coins_I_have = ((long)number_of_coins_of_n * value_of_n) + number_of_coins_of_1;

                int needed_number_of_1 = required_total_value % value_of_n;

                if (total_coins_I_have >= required_total_value &&
                    needed_number_of_1 <= number_of_coins_of_1)
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
