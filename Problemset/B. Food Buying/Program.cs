namespace B._Food_Buying
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1296/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number_of_burles = int.Parse(Console.ReadLine()!);

                long max_burles_can_spend = 0;

                int remaining = 0;

                while (number_of_burles >= 10)
                {
                    remaining = number_of_burles % 10;

                    number_of_burles = number_of_burles - remaining;

                    max_burles_can_spend += number_of_burles;

                    number_of_burles = number_of_burles / 10 + remaining;
                }

                max_burles_can_spend += number_of_burles;

                //Console.Write("************************************* ");

                Console.WriteLine(max_burles_can_spend);
            }
        }
    }
}
