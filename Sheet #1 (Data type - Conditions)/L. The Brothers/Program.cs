namespace L._The_Brothers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            string x = Console.ReadLine()!;
            string[] elements2 = x.Split(' ');

            if (elements[1] == elements2[1])
                Console.WriteLine("ARE Brothers");
            else
                Console.WriteLine("NOT");
        }
    }
}