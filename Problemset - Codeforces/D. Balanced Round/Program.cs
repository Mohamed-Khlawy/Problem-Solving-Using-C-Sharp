namespace D._Balanced_Round
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1850/D
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int n = n_k[0];
                int k = n_k[1];

                List<int> diffs = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                diffs.Sort();

                int counter = 1;
                int min_result = 1;

                for (int i = 1; i < diffs.Count; i++)
                {
                    if (diffs[i] - diffs[i - 1] > k)
                    {
                        counter = 1;
                    }

                    else
                    {
                        counter++;
                    }

                    min_result = Math.Max(min_result, counter);
                }

                Console.WriteLine(n - min_result);
            }
        }
    }
}
