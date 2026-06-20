namespace B1._Wonderful_Coloring___1
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1551/B1
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                string str = Console.ReadLine()!;

                string alphabet = "abcdefghijklmnopqrstuvwxyz";

                int[] frequency = new int[26];

                for (int i = 0; i < str.Length; i++)
                {
                    int char_index = alphabet.IndexOf(str[i]);

                    frequency[char_index]++;
                }



                int number_of_red_chars = 0;

                int one_occurence = 0;

                for (int i = 0; i < frequency.Length; i++)
                {
                    if (frequency[i] == 1)
                    {
                        one_occurence++;
                    }

                    else if (frequency[i] >= 2)
                    {
                        number_of_red_chars++;
                    }
                }

                number_of_red_chars += one_occurence / 2;

                //Console.Write("************************************************ ");

                Console.WriteLine(number_of_red_chars);
            }
        }
    }
}
