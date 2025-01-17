namespace B._Unique_Bid_Auction
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1454/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> chosen_numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int[] frequency_of_numbers = new int[size + 1];

                int[] players_indeces = new int[size + 1];

                int winner_index = -1;

                for (int i = 0; i < size; i++)
                {
                    frequency_of_numbers[chosen_numbers[i]]++;

                    players_indeces[chosen_numbers[i]] = i + 1;
                }

                for (int i = 0; i <= size; i++)
                {
                    if (frequency_of_numbers[i] == 1)
                    {
                        winner_index = players_indeces[i];
                        break;
                    }
                }

                //Console.Write("******************************* ");

                Console.WriteLine(winner_index);
            }
        }
    }
}
