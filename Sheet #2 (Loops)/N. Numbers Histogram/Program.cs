namespace N._Numbers_Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine()!);
            int lines = int.Parse(Console.ReadLine()!);
            string input = Console.ReadLine()!;
            string[] inputs = input.Split(' ');

            foreach (string s in inputs)
            {
                int numberOfSymbols = int.Parse(s);
                for (int i = 0; i < numberOfSymbols; i++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}