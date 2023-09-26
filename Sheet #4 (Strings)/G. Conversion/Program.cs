namespace G._Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine()!;
            string wordAfterConversion = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ',')
                {
                    wordAfterConversion += " ";
                }

                else if (char.IsUpper(word[i]))
                {
                    wordAfterConversion += char.ToLower(word[i]);
                }

                else
                {
                    wordAfterConversion += char.ToUpper(word[i]);
                }
            }

            Console.WriteLine(wordAfterConversion);
        }
    }
}