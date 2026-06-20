namespace A._Problem_Generator
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1980/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                string[] problems = { "A", "B", "C", "D", "E", "F", "G" };

                int[] n_m = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int n = n_m[0];
                int m = n_m[1];

                string input = Console.ReadLine()!;
                string[] bank = new string[n];

                for (int i = 0; i < n; i++)
                {
                    bank[i] = input[i].ToString();
                }

                long min_problems = 0;

                foreach (string probelm in problems)
                {
                    int problem_count = bank.Where(x => x == probelm).Count();

                    if (problem_count < m)
                    {
                        min_problems += m - problem_count;
                    }
                }

                Console.WriteLine(min_problems);
            }
        }
    }
}
