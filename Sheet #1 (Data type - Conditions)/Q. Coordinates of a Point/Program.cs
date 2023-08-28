namespace Q._Coordinates_of_a_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            double first = double.Parse(elements[0]);
            double second = double.Parse(elements[1]);

            if (first > 0 && second > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (first < 0 && second > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (first < 0 && second < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (first > 0 && second < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (first == 0 && second == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (first == 0 && second != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (first != 0 && second == 0)
            {
                Console.WriteLine("Eixo X");
            }
        }
    }
}