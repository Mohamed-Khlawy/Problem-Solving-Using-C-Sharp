namespace B._Drawing__X_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfLines; j++)
                {
                    if (j == i && j != numberOfLines / 2)
                    {
                        Console.Write('\\');
                    }
                    else if (j == (numberOfLines - 1) - i && j != i)
                    {
                        Console.Write('/');
                    }
                    else if (j == i && j == numberOfLines / 2)
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write('*');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}