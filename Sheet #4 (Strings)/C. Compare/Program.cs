namespace C._Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine()!;
            string secondWord = Console.ReadLine()!;

            string alphapet = "abcdefghijklmnopqrstuvwxyz";
            string lowestString;

            lowestString = firstWord.Length <= secondWord.Length ? firstWord : secondWord;

            int lowestLength = lowestString.Length;

            for (int i = 0; i < lowestLength; i++)
            {
                int wordIndexForFirst = alphapet.IndexOf(firstWord[i]);
                int wordIndexForSecond = alphapet.IndexOf(secondWord[i]);

                if (wordIndexForFirst < wordIndexForSecond)
                {
                    Console.WriteLine(firstWord);
                    return;
                }
                else if (wordIndexForFirst > wordIndexForSecond)
                {
                    Console.WriteLine(secondWord);
                    return;
                }
            }

            Console.WriteLine(lowestString);
        }
    }
}