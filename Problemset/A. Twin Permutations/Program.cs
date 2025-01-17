namespace A._Twin_Permutations
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1831/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> input_permutation = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                //Console.Write("************************************* ");

                int building_sum = 1 + size;

                for (int i = 0; i < input_permutation.Count; i++)
                {
                    if (i == input_permutation.Count - 1)
                    {
                        Console.WriteLine(building_sum - input_permutation[i]);
                    }

                    else
                    {
                        Console.Write(building_sum - input_permutation[i] + " ");
                    }
                }
            }
        }
    }
}
