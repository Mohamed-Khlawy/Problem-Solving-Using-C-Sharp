namespace J._Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            double first = double.Parse(elements[0]);
            double second = double.Parse(elements[1]);

            if (first % second != 0 && second % first != 0)
            {
                Console.WriteLine("No Multiples");
            }
            else
            {
                Console.WriteLine("Multiples");
            }
        }
    }
}