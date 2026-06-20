namespace A._Entertainment_in_MAC
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1935/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfOperations = int.Parse(Console.ReadLine()!);

                string main = Console.ReadLine()!;

                char[] mainChars = main.ToCharArray();

                Array.Reverse(mainChars);

                string reversed = new string(mainChars);

                //Console.Write("*********************************** ");

                // main is smaller than or equal to reversed
                if (main.CompareTo(reversed) < 0 ||
                    main.CompareTo(reversed) == 0)
                {
                    if (numberOfOperations % 2 == 0) // Even Operations
                    {
                        Console.WriteLine(main);
                    }

                    else // Odd Operations
                    {
                        main += reversed;

                        Console.WriteLine(main);
                    }
                }

                else if (main.CompareTo(reversed) > 0) // main is bigger than reversed
                {
                    if (numberOfOperations % 2 == 0) // Even Operations
                    {
                        reversed += main;

                        Console.WriteLine(reversed);
                    }

                    else // Odd Operations
                    {
                        Console.WriteLine(reversed);
                    }
                }
            }
        }
    }
}
