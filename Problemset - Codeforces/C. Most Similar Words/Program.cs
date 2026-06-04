namespace C._Most_Similar_Words
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1676/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_m = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int number_of_words = n_m[0];
                int size_of_word = n_m[1];

                List<string> words = new List<string>();

                //string alphabet = "abcdefghijklmnopqrstuvwxyz";

                int min_difference = int.MaxValue;

                for (int i = 0; i < number_of_words; i++)
                {
                    words.Add(Console.ReadLine()!);
                }

                for (int i = 0; i < words.Count - 1; i++)
                {

                    for (int k = i + 1; k < words.Count; k++)
                    {

                        int current_difference = 0;

                        for (int j = 0; j < size_of_word; j++)
                        {
                            current_difference += Math.Abs(words[i][j] - words[k][j]);
                        }

                        if (current_difference < min_difference)
                        {
                            min_difference = current_difference;
                        }
                    }
                }

                //Console.Write("**************************************** ");

                Console.WriteLine(min_difference);

                Console.WriteLine();
            }
        }
    }
}
