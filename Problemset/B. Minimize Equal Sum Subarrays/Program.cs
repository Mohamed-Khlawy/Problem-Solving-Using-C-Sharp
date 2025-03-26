namespace B._Minimize_Equal_Sum_Subarrays
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1998/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int permutationSize = int.Parse(Console.ReadLine()!);

                List<int> permutation = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                permutation.Add(permutation[0]);
                permutation.RemoveAt(0);

                /// Accepted Solution also
                //permutation.Insert(0, permutation[^1]);
                //permutation.RemoveAt(permutationSize);

                //Console.Write("******************* ");

                Console.WriteLine(string.Join(' ', permutation));
            }
        }
    }
}
