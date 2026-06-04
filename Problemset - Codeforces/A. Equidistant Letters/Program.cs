namespace A._Equidistant_Letters
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1626/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                string str = Console.ReadLine()!;

                string alphabet = "abcdefghijklmnopqrstuvwxyz";

                int[] alphabet_frequency = new int[26];

                List<char> rearranged_str = new List<char>();

                for (int i = 0; i < str.Length; i++)
                {
                    int char_index = alphabet.IndexOf(str[i]);

                    alphabet_frequency[char_index]++;
                }

                //Console.Write("********************************** ");

                for (int i = 0; i < 26; i++)
                {
                    if (alphabet_frequency[i] == 1)
                    {
                        Console.Write(alphabet[i]);
                    }

                    else if (alphabet_frequency[i] == 2)
                    {
                        Console.Write(alphabet[i]);
                        Console.Write(alphabet[i]);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
