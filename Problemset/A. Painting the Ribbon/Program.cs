namespace A._Painting_the_Ribbon
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1954/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);

                int ribbonParts = input[0];
                int numberOfColors = input[1];
                int maxRepaintParts = input[2];

                int repaintedParts =
                    ribbonParts - (int)Math.Ceiling((decimal)ribbonParts / numberOfColors);

                //Console.Write("******************** ");

                Console.WriteLine(repaintedParts > maxRepaintParts ? "YES" : "NO");
            }
        }
    }
}
