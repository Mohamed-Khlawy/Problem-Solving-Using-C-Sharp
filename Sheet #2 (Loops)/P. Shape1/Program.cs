internal class Program
{
    private static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine()!);

        for (int i = number; i > 0; i--)
        {
            for (int j = i; j > 0; j--)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}