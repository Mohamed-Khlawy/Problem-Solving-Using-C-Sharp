namespace A._ABC
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1632/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                string binary_str = Console.ReadLine()!;

                if (size == 1 || (size == 2 && binary_str[0] != binary_str[1]))
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
