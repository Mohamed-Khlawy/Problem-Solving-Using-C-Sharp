namespace A._Legs
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1996/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number_of_legs = int.Parse(Console.ReadLine()!);

                if (number_of_legs == 2)
                {
                    Console.WriteLine(1);
                }

                else if (number_of_legs % 4 == 0)
                {
                    Console.WriteLine(number_of_legs / 4);
                }

                else if (number_of_legs % 4 == 2)
                {
                    Console.WriteLine((number_of_legs - 2) / 4 + 1);
                }
            }
        }
    }
}
