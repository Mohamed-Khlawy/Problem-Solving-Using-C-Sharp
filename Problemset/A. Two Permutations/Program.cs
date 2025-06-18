namespace A._Two_Permutations
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1761/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                int permutaionSize = input[0]; // n
                int LCP = input[1]; // a ==> Longest Common Prefix
                int LCS = input[2]; // b ==> Longest Common Suffix

                int availableRange = permutaionSize - 2;

                bool weCanDoIt =
                    (LCP == LCS && LCP == permutaionSize) || (LCP + LCS <= availableRange);

                //Console.Write("******************************* ");

                Console.WriteLine(weCanDoIt ? "Yes" : "No");
            }
        }
    }
}
