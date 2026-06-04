namespace B._Card_Game
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1999/B

        static int WinnerOfRound(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }

            else if (a == b)
            {
                return 0;
            }

            else
            {
                return -1;
            }
        }

        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> cards = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                List<int> suneet_cards = new List<int>();

                List<int> slavic_cards = new List<int>();

                suneet_cards.Add(cards[0]);
                suneet_cards.Add(cards[1]);

                slavic_cards.Add(cards[2]);
                slavic_cards.Add(cards[3]);

                suneet_cards.Sort();
                slavic_cards.Sort();

                int winning_games_for_suneet = 0;

                if (WinnerOfRound(suneet_cards[0], slavic_cards[0]) +
                    WinnerOfRound(suneet_cards[1], slavic_cards[1]) > 0)
                {
                    winning_games_for_suneet++;
                }

                if (WinnerOfRound(suneet_cards[1], slavic_cards[1]) +
                    WinnerOfRound(suneet_cards[0], slavic_cards[0]) > 0)
                {
                    winning_games_for_suneet++;
                }

                if (WinnerOfRound(suneet_cards[0], slavic_cards[1]) +
                    WinnerOfRound(suneet_cards[1], slavic_cards[0]) > 0)
                {
                    winning_games_for_suneet++;
                }

                if (WinnerOfRound(suneet_cards[1], slavic_cards[0]) +
                    WinnerOfRound(suneet_cards[0], slavic_cards[1]) > 0)
                {
                    winning_games_for_suneet++;
                }

                //Console.Write("************************************ ");

                Console.WriteLine(winning_games_for_suneet);
            }
        }
    }
}
