namespace A._Jzzhu_and_Children
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/450/A
        static void Main(string[] args)
        {
            int[] n_m = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int n = n_m[0];
            int m = n_m[1];

            List<int> childs = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            int last_child_index = childs.Count;
            double max_repeats = 0;

            for (int i = 0; i < n; i++)
            {
                if (childs[i] > m)
                {
                    double current_child_repeats = Math.Ceiling((double)childs[i] / m);

                    if (current_child_repeats >= max_repeats)
                    {
                        max_repeats = current_child_repeats;
                        last_child_index = i + 1;
                    }
                }
            }

            Console.WriteLine(last_child_index);
        }
    }
}
