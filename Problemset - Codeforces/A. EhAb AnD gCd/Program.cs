namespace A._EhAb_AnD_gCd
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1325/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int number = int.Parse(Console.ReadLine()!);

                Console.WriteLine(1 + " " + (number - 1));
            }
        }
    }
}
