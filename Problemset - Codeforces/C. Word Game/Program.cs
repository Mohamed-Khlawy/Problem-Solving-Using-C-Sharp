namespace C._Word_Game
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1722/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number_of_words = int.Parse(Console.ReadLine()!);

                List<List<string>> words = new List<List<string>>();

                int[] playres_scores = new int[3];

                Dictionary<string, int> kvp = new Dictionary<string, int>();

                for (int i = 0; i < 3; i++)
                {
                    words.Add(Console.ReadLine()!.Split().ToList());
                }

                // Store number of occurrences for each word in the Dictionary

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < number_of_words; j++)
                    {
                        if (kvp.ContainsKey(words[i][j]))
                        {
                            kvp[words[i][j]]++;
                        }

                        else
                        {
                            kvp.Add(words[i][j], 1);
                        }
                    }
                }

                // Count score for each player based on number of occurrences for each of his words

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < number_of_words; j++)
                    {
                        if (kvp[words[i][j]] == 1)
                        {
                            playres_scores[i] += 3;
                        }

                        else if (kvp[words[i][j]] == 2)
                        {
                            playres_scores[i] += 1;
                        }
                    }
                }

                Console.WriteLine(playres_scores[0] + " " +
                                  playres_scores[1] + " " + playres_scores[2]);
            }
        }
    }
}
