namespace A._1_to_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine()!;
            string[] elements = s.Split(' ');

            int first = int.Parse(elements[0]);

            for (int i = 1; i <= first; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}