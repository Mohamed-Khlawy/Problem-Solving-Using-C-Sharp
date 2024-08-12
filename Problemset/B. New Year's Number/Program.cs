namespace B._New_Year_s_Number
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1475/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number = int.Parse(Console.ReadLine()!);

                int counter_2021 = number % 2020;

                int counter_2020 = (number - counter_2021) / 2020 - counter_2021;

                if (counter_2020 >= 0 &&
                    2020 * counter_2020 + 2021 * counter_2021 == number)
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
