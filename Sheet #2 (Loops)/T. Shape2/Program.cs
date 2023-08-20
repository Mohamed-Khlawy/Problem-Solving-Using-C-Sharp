namespace T._Shape2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int stars = 1;
            for (int i = 1; i <= n; i++)
            {
                // Spaces Loop
                for (int j = n; j > i; j--)
                {
                    Console.Write(' ');
                }

                // Stars Loop
                for (int j = 1; j <= stars; j++)
                {
                    Console.Write('*');
                }
                // Increment stars with 2 each iteration
                stars += 2;
                Console.WriteLine();
            }
        }
    }
}