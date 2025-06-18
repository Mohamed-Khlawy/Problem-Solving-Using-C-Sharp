namespace A._The_Play_Never_Ends
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2071/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfMatches = int.Parse(Console.ReadLine()!);

                //Console.Write("**************************** ");

                Console.WriteLine
                    ((numberOfMatches - 1) % 3 == 0 ? "YES" : "NO");
            }
        }
    }
}
