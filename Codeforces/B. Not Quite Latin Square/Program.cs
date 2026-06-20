namespace B._Not_Quite_Latin_Square
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1915/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<string> square = new List<string>();

                for (int i = 0; i < 3; i++)
                {
                    square.Add(Console.ReadLine()!);
                }

                //Console.Write("*** ");

                for (int i = 0; i < 3; i++)
                {
                    if (square[i].Contains('?'))
                    {
                        if (square[i].Contains('A') && square[i].Contains('B'))
                        {
                            Console.WriteLine('C');
                        }

                        else if (square[i].Contains('A') && square[i].Contains('C'))
                        {
                            Console.WriteLine('B');
                        }

                        else
                        {
                            Console.WriteLine('A');
                        }
                    }
                }
            }
        }
    }
}
