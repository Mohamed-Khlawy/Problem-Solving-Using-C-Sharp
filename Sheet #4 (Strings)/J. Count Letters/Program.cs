namespace J._Count_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine()!;

            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            Dictionary<char, int> lettersCounter = new Dictionary<char, int>();

            for (int i = 0; i < alphabet.Length; i++)
            {
                lettersCounter.Add(alphabet[i], 0);
            }

            for (int i = 0; i < word.Length; i++)
            {
                lettersCounter[word[i]]++;
            }

            foreach (var letter in lettersCounter)
            {
                if (letter.Value > 0)
                {
                    Console.WriteLine($"{letter.Key} : {letter.Value}");
                }
            }
        }
    }
}