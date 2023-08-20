namespace W._Shape3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine()!);
            int stars = 1;

            for(int i=1;i<=numberOfLines; i++)
            {
                for(int j=numberOfLines; j>i; j--)
                {
                    Console.Write(' ');
                }

                for(int x=1; x<= stars; x++)
                {
                    Console.Write('*');
                }

                stars += 2;
                Console.WriteLine();
            }

            stars -= 2;
            
            for (int i = numberOfLines; i >= 1; i--)
            {
                for (int j = numberOfLines; j > i; j--)
                {
                    Console.Write(' ');
                }

                for (int x = 1; x <= stars; x++)
                {
                    Console.Write('*');
                }

                stars -= 2;
                Console.WriteLine();
            }
        }
    }
}