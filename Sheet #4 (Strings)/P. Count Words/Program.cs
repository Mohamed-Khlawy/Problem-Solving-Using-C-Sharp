namespace P._Count_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] seperators = { ' ', '!', '?', ',', '.' };
            string[] wordsOfSentence = Console.ReadLine()!.Split(seperators);

            long wordsCounter = 0;

            for (int i = 0; i < wordsOfSentence.Length; i++)
            {
                if (wordsOfSentence[i] != "" && char.IsLetter(wordsOfSentence[i][0]))
                {
                    wordsCounter++;
                }
            }

            Console.WriteLine(wordsCounter);
        }
    }
}