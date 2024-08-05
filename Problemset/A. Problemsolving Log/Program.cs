namespace A._Problemsolving_Log
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1914/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int contest_duration = int.Parse(Console.ReadLine()!);

                string contest_log = Console.ReadLine()!;

                string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                int number_of_solved_problems = 0;

                for (int i = 0; i < 26; i++)
                {
                    int minutes_for_problem = contest_log.Where(x => x == alphabet[i]).Count();

                    if (minutes_for_problem >= alphabet.IndexOf(alphabet[i]) + 1)
                    {
                        number_of_solved_problems++;
                    }
                }

                //Console.Write("*** ");
                Console.WriteLine(number_of_solved_problems);
            }
        }
    }
}
