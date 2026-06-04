namespace A._Domino_Disaster
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1567/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                string row1 = Console.ReadLine()!;

                string row2 = string.Empty;

                for (int i = 0; i < size; i++)
                {
                    if (row1[i] == 'L' || row1[i] == 'R')
                    {
                        row2 += row1[i];
                    }

                    else
                    {
                        if (row1[i] == 'U')
                        {
                            row2 += 'D';
                        }

                        else if (row1[i] == 'D')
                        {
                            row2 += 'U';
                        }
                    }
                }

                //Console.Write("************************************ ");

                Console.WriteLine(row2);
            }
        }
    }
}
