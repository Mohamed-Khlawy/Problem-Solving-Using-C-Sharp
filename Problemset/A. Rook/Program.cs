namespace A._Rook
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1907/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                string rook_now = Console.ReadLine()!;

                string[] cols = { "a", "b", "c", "d", "e", "f", "g", "h" };
                string[] rows = { "1", "2", "3", "4", "5", "6", "7", "8" };


                List<string> rook_squares = new List<string>();

                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        for (int j = 0; j < rows.Length; j++)
                        {
                            string rook_new = rook_now[i] + rows[j];

                            if (rook_new != rook_now)
                            {
                                rook_squares.Add(rook_new);
                            }
                        }
                    }

                    else
                    {
                        for (int j = 0; j < cols.Length; j++)
                        {
                            string rook_new = cols[j] + rook_now[i];

                            if (rook_new != rook_now)
                            {
                                rook_squares.Add(rook_new);
                            }
                        }
                    }
                }

                for (int i = 0; i < rook_squares.Count; i++)
                {
                    Console.WriteLine(rook_squares[i]);
                }
            }
        }
    }
}
