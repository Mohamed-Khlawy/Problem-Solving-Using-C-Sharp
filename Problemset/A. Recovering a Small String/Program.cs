namespace A._Recovering_a_Small_String
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1931/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int encoded_word = int.Parse(Console.ReadLine()!);

                string alphabet = "abcdefghijklmnopqrstuvwxyz";

                char[] last_word = { 'a', 'a', 'a' };

                for (int i = 2; i >= 0; i--)
                {
                    int encoded_without_last = encoded_word - i;

                    if (encoded_without_last <= 26)
                    {
                        last_word[i] = alphabet[encoded_without_last - 1];
                        break;
                    }

                    else
                    {
                        last_word[i] = 'z';
                        encoded_word -= 26;
                    }
                }

                Console.WriteLine(last_word[0].ToString() +
                                  last_word[1].ToString() +
                                  last_word[2].ToString());
            }
        }
    }
}
