namespace A._Thorns_and_Coins
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1932/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<char> path = Console.ReadLine()!.Select(c => char.Parse(c.ToString())).ToList();

                int number_of_thorns = 0;
                int max_number_of_coins = 0;

                for (int i = 0; i < size; i++)
                {
                    if (path[i] == '.')
                    {
                        number_of_thorns = 0;
                    }

                    else if (path[i] == '@')
                    {
                        number_of_thorns = 0;
                        max_number_of_coins++;
                    }

                    else if (path[i] == '*')
                    {
                        number_of_thorns++;

                        if (number_of_thorns == 2)
                        {
                            break;
                        }
                    }
                }

                //Console.Write("********************************** ");

                Console.WriteLine(max_number_of_coins);
            }
        }
    }
}
