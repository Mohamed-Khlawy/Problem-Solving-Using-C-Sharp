namespace A._Two_Vessels
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1872/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int[] a_b_c = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int a = a_b_c[0];
                int b = a_b_c[1];
                int c = a_b_c[2];

                int maxA_B = Math.Max(a, b);
                int minA_B = Math.Min(a, b);

                long numberOfMoves = 0;

                while (maxA_B > minA_B)
                {
                    maxA_B -= c;
                    minA_B += c;
                    numberOfMoves++;
                }

                Console.WriteLine("*" + numberOfMoves);
            }
        }
    }
}