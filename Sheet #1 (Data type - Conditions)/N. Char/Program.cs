namespace N._Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = char.Parse(Console.ReadLine()!);
            if (char.IsLower(c))
            {
                Console.WriteLine(char.ToUpper(c));
            }
            else if (char.IsUpper(c))
            {
                Console.WriteLine(char.ToLower(c));
            }
        }
    }
}