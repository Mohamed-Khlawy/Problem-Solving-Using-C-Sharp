namespace F._Way_Too_Long_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                string word = Console.ReadLine()!;

                if (word.Length <= 10)
                {
                    Console.WriteLine(word);
                }

                else
                {
                    Console.WriteLine($"{word[0]}{word.Length - 2}{word[word.Length - 1]}");
                }
            }
        }
    }
}