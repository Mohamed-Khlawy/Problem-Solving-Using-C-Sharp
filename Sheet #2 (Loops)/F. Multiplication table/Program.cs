namespace F._Multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }
    }
}