namespace A._Gregor_and_Cryptography
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1549/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int fav_prime = int.Parse(Console.ReadLine()!);

                Console.WriteLine(2 + " " + (fav_prime - 1));
            }
        }
    }
}
