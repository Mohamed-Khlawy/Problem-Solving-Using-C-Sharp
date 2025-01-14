namespace A._Juggling_Letters
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1397/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number_of_words = int.Parse(Console.ReadLine()!);

                string alphabet = "abcdefghijklmnopqrstuvwxyz";

                int[] frequency = new int[26];

                bool can_we_make_them_equal = true;

                for (int i = 0; i < number_of_words; i++)
                {
                    string word = Console.ReadLine()!;

                    for (int j = 0; j < word.Length; j++)
                    {
                        int char_index = alphabet.IndexOf(word[j]);

                        frequency[char_index]++;
                    }
                }

                for (int i = 0; i < frequency.Length; i++)
                {
                    if (frequency[i] % number_of_words != 0)
                    {
                        can_we_make_them_equal = false;
                        break;
                    }
                }

                //Console.Write("************************************ ");

                if (can_we_make_them_equal)
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
