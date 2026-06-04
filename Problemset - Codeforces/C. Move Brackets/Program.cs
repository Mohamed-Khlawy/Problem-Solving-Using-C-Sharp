namespace C._Move_Brackets
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1374/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                string brackets = Console.ReadLine()!;

                int open = 0;

                int moves = 0;

                for (int i = 0; i < size; i++)
                {
                    if (brackets[i] == '(')
                    {
                        open++;
                    }

                    else if (brackets[i] == ')')
                    {
                        if (open > 0)
                        {
                            open--;
                        }

                        else
                        {
                            moves++;
                        }
                    }
                }

                //Console.Write("*** ");
                Console.WriteLine(moves);
            }
        }
    }
}
