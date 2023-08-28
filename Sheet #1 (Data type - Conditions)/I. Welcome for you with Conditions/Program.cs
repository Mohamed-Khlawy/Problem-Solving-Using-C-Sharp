namespace I._Welcome_for_you_with_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            double first = double.Parse(elements[0]);
            double second = double.Parse(elements[1]);

            if (first >= second)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}