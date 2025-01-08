namespace B._Robin_Hood_and_the_Major_Oak
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2014/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> input = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int requested_year = input[0]; // n

                int years_for_falling = input[1]; // k

                int first_year_remaining = requested_year - years_for_falling + 1;

                // Formula to get number of odd numbers between 2 given numbers
                int number_of_odd_years_remaining = ((requested_year + 1) / 2) -
                                                    (first_year_remaining / 2);

                //Console.Write("*********************************** ");

                if (number_of_odd_years_remaining % 2 == 0)
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
