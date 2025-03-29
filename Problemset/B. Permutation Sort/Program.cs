namespace B._Permutation_Sort
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1525/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int permutationSize = int.Parse(Console.ReadLine()!);

                int[] permutation = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);

                int[] correctPermutation = Enumerable.Range(1, permutationSize).ToArray();

                //Console.Write("********************** ");

                if (correctPermutation.SequenceEqual(permutation))
                {
                    Console.WriteLine(0);
                }

                else if (permutation[0] == 1 || permutation[^1] == permutationSize)
                {
                    Console.WriteLine(1);
                }

                else if (permutation[0] == permutationSize && permutation[^1] == 1)
                {
                    Console.WriteLine(3);
                }

                else Console.WriteLine(2);
            }
        }
    }
}
