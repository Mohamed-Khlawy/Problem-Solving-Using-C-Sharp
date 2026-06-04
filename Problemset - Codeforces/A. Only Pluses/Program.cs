namespace A._Only_Pluses
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1992/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> a_b_c = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                for (int i = 0; i < 5; i++)
                {
                    int min_value_index = a_b_c.IndexOf(a_b_c.Min());

                    a_b_c[min_value_index]++;
                }

                int max_mul = 1;

                for (int i = 0; i < a_b_c.Count; i++)
                {
                    max_mul *= a_b_c[i];
                }

                Console.WriteLine(max_mul);
            }
        }
    }
}
