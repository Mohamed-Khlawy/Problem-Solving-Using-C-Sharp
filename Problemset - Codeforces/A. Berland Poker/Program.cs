namespace A._Berland_Poker
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1359/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_m_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_cards = n_m_k[0]; // n
                int number_of_jokers = n_m_k[1]; // m
                int number_of_players = n_m_k[2]; // k

                //Console.Write("************************************** ");

                if (number_of_jokers == 0)
                {
                    Console.WriteLine(0);
                }

                else
                {
                    int cards_for_each_player = number_of_cards / number_of_players;

                    if (cards_for_each_player >= number_of_jokers)
                    {
                        Console.WriteLine(number_of_jokers);
                    }

                    else
                    {
                        int first_player_cards = cards_for_each_player;

                        int remaining_jokers = number_of_jokers - first_player_cards;

                        int second_player_cards =
                            (remaining_jokers + number_of_players - 2) /
                            (number_of_players - 1);

                        Console.WriteLine(first_player_cards - second_player_cards);
                    }
                }
            }
        }
    }
}
