namespace B._Kana_and_Dragon_Quest_game
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1337/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int[] h_n_m = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int h = h_n_m[0];
                int copy_h = h;
                int n = h_n_m[1];
                int m = h_n_m[2];

                while (h > 0 && n-- > 0)
                {
                    h = (h / 2) + 10;
                }

                if (h <= 0)
                {
                    Console.WriteLine("YES");
                }

                else if (copy_h < h)
                {
                    copy_h -= (10 * m);

                    if (copy_h <= 0)
                    {
                        Console.WriteLine("YES");
                    }

                    else
                    {
                        Console.WriteLine("NO");
                    }
                }

                else
                {
                    h -= (10 * m);

                    if (h <= 0)
                    {
                        Console.WriteLine("YES");
                    }

                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
        }
    }
}