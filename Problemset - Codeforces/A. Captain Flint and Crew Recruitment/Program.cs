namespace A._Captain_Flint_and_Crew_Recruitment
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1388/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number = int.Parse(Console.ReadLine()!);

                bool weCanDoIt = false;

                int remaining = number - 30;

                #region Problem Idea

                /// 6 + 10 + 14 = 30
                /// These are min 3 multiplies of prime numbers, so number should be at least 31
                /// 2 * 3 = 6
                /// 2 * 5 = 10
                /// 2 * 7 = 14

                #endregion

                if (number >= 31) weCanDoIt = true;

                //Console.WriteLine("********************* ");

                Console.WriteLine(weCanDoIt
                    ? remaining == 6 || remaining == 10 || remaining == 14
                        ? "YES\n6 10 15 " + (remaining - 1)
                        : "YES\n6 10 14 " + remaining
                    : "NO");

                //Console.WriteLine("********************* ");
            }
        }
    }
}
