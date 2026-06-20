namespace B._Minimize_Inversions
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1918/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int permutationSize = int.Parse(Console.ReadLine()!);

                int[] permutation1 =
                    Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                int[] permutation2 =
                    Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                int[] oppositeNumber = new int[permutationSize + 1];

                for (int i = 0; i < permutationSize; i++)
                {
                    oppositeNumber[permutation1[i]] = permutation2[i];
                }

                Array.Sort(permutation1);

                for (int i = 0; i < permutationSize; i++)
                {
                    permutation2[i] = oppositeNumber[permutation1[i]];
                }

                //Console.WriteLine("************************************");

                Console.WriteLine($"{string.Join(" ", permutation1)} \n" +
                    $"{string.Join(" ", permutation2)}");

                //Console.WriteLine("************************************");
            }
        }
    }
}
