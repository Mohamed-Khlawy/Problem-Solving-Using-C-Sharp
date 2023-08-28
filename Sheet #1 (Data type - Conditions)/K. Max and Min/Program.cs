namespace K._Max_and_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            double first = double.Parse(elements[0]);
            double second = double.Parse(elements[1]);
            double third = double.Parse(elements[2]);

            double max = Math.Max(Math.Max(first, second), third);
            double min = Math.Min(Math.Min(first, second), third);

            Console.WriteLine(min + " " + max);
        }
    }
}