namespace A._Maximize
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1968/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int a = int.Parse(Console.ReadLine()!);

                Console.WriteLine(a - 1);
            }
        }
    }
}
