namespace D._Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine()!;
            string secondWord = Console.ReadLine()!;

            Console.WriteLine(firstWord.Length + " " + secondWord.Length);
            Console.WriteLine(firstWord + secondWord);

            char firstOfFirst = firstWord[0];
            char firstOfSecond = secondWord[0];

            Console.Write(firstOfSecond);
            for (int i = 1; i < firstWord.Length; i++)
            {
                Console.Write(firstWord[i]);
            }

            Console.Write(" ");

            Console.Write(firstOfFirst);
            for (int i = 1; i < secondWord.Length; i++)
            {
                Console.Write(secondWord[i]);
            }
        }
    }
}