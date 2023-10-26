namespace V._Replace_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine()!;

            word = word.Replace("EGYPT", " ");

            Console.WriteLine(word);
        }
    }
}