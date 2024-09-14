namespace D._Unnatural_Language_Processing
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1915/D
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<char> intial_word = Console.ReadLine()!
                                        .Select(c => char.Parse(c.ToString()))
                                        .ToList();

                List<string> word_after_spliting = new List<string>();

                List<char> vowels = new List<char> { 'a', 'e' };
                List<char> consonants = new List<char> { 'b', 'c', 'd' };


                int vowels_exist = intial_word
                                  .Where(c => c == 'a' || c == 'e')
                                  .Count();
                int vowels_added = 0;


                int consonants_exist = intial_word
                                      .Where(c => c == 'b' || c == 'c' || c == 'd')
                                      .Count();
                int consonants_added = 0;


                for (int i = 0; i < size; i++)
                {
                    if (consonants.Contains(intial_word[i]) &&
                        consonants.Contains(intial_word[i + 1]))
                    {
                        word_after_spliting[word_after_spliting.Count - 1] += intial_word[i];
                        consonants_added++;
                    }

                    else
                    {
                        string sub_word = intial_word[i].ToString() + intial_word[i + 1];
                        word_after_spliting.Add(sub_word);

                        i++;

                        vowels_added++;
                        consonants_added++;
                    }

                    if (i >= size - 2)
                    {
                        break;
                    }
                }

                if (consonants_added < consonants_exist)
                {
                    word_after_spliting[word_after_spliting.Count - 1] += intial_word[size - 1];
                }


                //Console.WriteLine("**********************************");

                for (int i = 0; i < word_after_spliting.Count; i++)
                {
                    if (i == word_after_spliting.Count - 1)
                    {
                        Console.WriteLine(word_after_spliting[i]);
                    }

                    else
                    {
                        Console.Write(word_after_spliting[i] + '.');
                    }
                }

                //Console.WriteLine("**********************************");
            }
        }
    }
}
