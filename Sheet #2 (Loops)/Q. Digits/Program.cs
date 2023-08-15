internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfTests = int.Parse(Console.ReadLine()!);

        while (numberOfTests-- > 0)
        {
            string number = Console.ReadLine()!;
            for (int i = number.Length-1; i >= 0; i--)
            {
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();
        }
    }
}