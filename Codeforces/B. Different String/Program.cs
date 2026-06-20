namespace B._Different_String
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1971/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                string word = Console.ReadLine()!;
                string new_word = "";

                bool all_letters_equal = true;

                for (int i = 1; i < word.Length; i++)
                {
                    if (word[i] != word[i - 1])
                    {
                        all_letters_equal = false;

                        int first_index = i;
                        int second_index = i - 1;

                        char[] chars = word.ToCharArray();

                        char temp = chars[first_index];
                        chars[first_index] = chars[second_index];
                        chars[second_index] = temp;

                        new_word = new string(chars);

                        break;
                    }
                }

                if (all_letters_equal)
                {
                    Console.WriteLine("NO");
                }

                else
                {
                    Console.WriteLine("YES");
                    Console.WriteLine(new_word);
                }
            }
        }
    }
}
