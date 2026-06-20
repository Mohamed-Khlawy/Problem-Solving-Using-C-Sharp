namespace B._Following_the_String
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1927/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> trace = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                string alphabet = "abcdefghijklmnopqrstuvwxyz";

                List<int> frequences = Enumerable.Repeat(0, 26).ToList();

                int alphabet_index = 0;

                List<char> lost_string = new List<char>();

                for (int i = 0; i < trace.Count; i++)
                {
                    if (trace[i] == 0)
                    {
                        lost_string.Add(alphabet[alphabet_index]);

                        frequences[alphabet_index]++;

                        alphabet_index++;
                    }

                    else
                    {
                        char repeated_char = ' ';

                        for (int j = 0; j < 26; j++)
                        {
                            if (frequences[j] == trace[i])
                            {
                                repeated_char = alphabet[j];
                                break;
                            }
                        }

                        lost_string.Add(repeated_char);

                        int index_of_repeated_char = alphabet.IndexOf(repeated_char);

                        frequences[index_of_repeated_char]++;
                    }
                }

                for (int i = 0; i < lost_string.Count; i++)
                {
                    Console.Write(lost_string[i]);
                }

                Console.WriteLine();
            }
        }
    }
}
