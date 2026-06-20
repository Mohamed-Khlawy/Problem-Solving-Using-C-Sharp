namespace A._Sakurako_and_Kosuke
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2033/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int n = int.Parse(Console.ReadLine()!);

                int negative_n = n * -1;

                int turn = 1;
                int current_position = 0;

                while (current_position >= negative_n && current_position <= n)
                {
                    if (turn % 2 == 1) // ODD ==> Sakurako
                    {
                        int moving_units = (2 * turn - 1) * -1;

                        current_position += moving_units;
                    }

                    else if (turn % 2 == 0) // EVEN ==> Kosuke
                    {
                        int moving_units = 2 * turn - 1;

                        current_position += moving_units;
                    }

                    turn++;
                }

                if (turn % 2 == 0)
                {
                    Console.WriteLine("Sakurako");
                }

                else
                {
                    Console.WriteLine("Kosuke");
                }
            }
        }
    }
}
