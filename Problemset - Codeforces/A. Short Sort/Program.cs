namespace A._Short_Sort
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1873/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                string abcOrder = Console.ReadLine()!;

                if (abcOrder[0] != 'a' && abcOrder[1] != 'b' && abcOrder[2] != 'c')
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}