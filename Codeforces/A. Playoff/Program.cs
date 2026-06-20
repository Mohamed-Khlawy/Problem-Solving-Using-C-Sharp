namespace A._Playoff
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1651/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int athletesPower = int.Parse(Console.ReadLine()!);

                //Console.Write("********************** ");

                Console.WriteLine(Math.Pow(2, athletesPower) - 1);
            }
        }
    }
}
