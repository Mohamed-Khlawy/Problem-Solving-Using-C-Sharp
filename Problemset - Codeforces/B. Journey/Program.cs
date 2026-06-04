namespace B._Journey
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2051/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int required_kms = input[0];

                int[] days_kms = new int[3] { input[1], input[2], input[3] };

                if (days_kms[0] == days_kms[1] && days_kms[1] == days_kms[2]
                    && days_kms[0] == 1)
                {
                    //Console.Write("********************************* ");

                    Console.WriteLine(required_kms);
                }

                else
                {
                    int total_kms_in_days = days_kms[0] + days_kms[1] + days_kms[2];

                    int n_division_abc = required_kms / total_kms_in_days;

                    int walked_kms = n_division_abc * total_kms_in_days;

                    int days_counter = 3 * n_division_abc;

                    while (walked_kms < required_kms)
                    {
                        walked_kms += days_kms[days_counter % 3];

                        days_counter++;
                    }

                    //Console.Write("********************************* ");

                    Console.WriteLine(days_counter);
                }
            }
        }
    }
}
