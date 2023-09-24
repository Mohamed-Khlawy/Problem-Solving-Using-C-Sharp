namespace A._Create_A_New_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine()!;
            string secondWord = Console.ReadLine()!;

            Console.WriteLine(firstWord.Length + " " + secondWord.Length);
            Console.WriteLine(firstWord + " " + secondWord);
        }
    }
}