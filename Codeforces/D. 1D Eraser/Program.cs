namespace D._1D_Eraser
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1873/D
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int n = n_k[0];
                int k = n_k[1];

                List<char> cells = Console.ReadLine()!.ToList();

                int result = 0;

                for (int i = 0; i < cells.Count; i++)
                {
                    if (cells[i] == 'B')
                    {
                        result++;
                        i += k - 1;
                    }
                }

                Console.WriteLine(result);
            }
        }
    }
}
