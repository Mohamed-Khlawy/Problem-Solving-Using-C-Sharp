namespace A._Tricky_Template
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1922/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<char> strA = Console.ReadLine()!.Select(c => char.Parse(c.ToString())).ToList();
                List<char> strB = Console.ReadLine()!.Select(c => char.Parse(c.ToString())).ToList();
                List<char> strC = Console.ReadLine()!.Select(c => char.Parse(c.ToString())).ToList();

                bool weCanDoIt = false;

                for (int i = 0; i < size; i++)
                {
                    if (strA[i] != strC[i] && strB[i] != strC[i])
                    {
                        weCanDoIt = true;
                        break;
                    }
                }

                //Console.Write("***************** ");

                Console.WriteLine(weCanDoIt ? "YES" : "NO");
            }
        }
    }
}
