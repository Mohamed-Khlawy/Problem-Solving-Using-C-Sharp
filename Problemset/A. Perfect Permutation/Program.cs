namespace A._Perfect_Permutation
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1711/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int permutationSize = int.Parse(Console.ReadLine()!);

                int[] permutation = Enumerable.Range(1, permutationSize).ToArray();

                for (int i = 0; i < permutationSize - 1; i += 2)
                {
                    (permutation[i], permutation[i + 1]) =
                        (permutation[i + 1], permutation[i]);
                }

                if (permutationSize % 2 == 1)
                {
                    (permutation[0], permutation[^1]) =
                        (permutation[^1], permutation[0]);
                }

                //Console.Write("************************* ");

                Console.WriteLine(string.Join(" ", permutation));
            }
        }
    }
}
