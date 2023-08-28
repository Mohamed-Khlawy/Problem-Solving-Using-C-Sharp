namespace B._Basic_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');
            foreach (string element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}