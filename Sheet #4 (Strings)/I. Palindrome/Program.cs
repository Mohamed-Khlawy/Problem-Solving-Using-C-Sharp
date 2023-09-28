namespace I._Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine()!;

            char[] wordChars = word.ToCharArray();

            Array.Reverse(wordChars);

            string reversedWord = new string(wordChars);

            if (word == reversedWord)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}