namespace M._Capital_or_Small_or_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = char.Parse(Console.ReadLine()!);
            if (char.IsDigit(c))
                Console.WriteLine("IS DIGIT");
            else if (char.IsUpper(c))
                Console.WriteLine("ALPHA\nIS CAPITAL");
            else if (char.IsLower(c))
                Console.WriteLine("ALPHA\nIS SMALL");
        }
    }
}