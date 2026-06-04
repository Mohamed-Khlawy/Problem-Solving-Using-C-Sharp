namespace A._Make_it_White
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1927/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                string strip = Console.ReadLine()!;

                int first_black_index = strip.IndexOf('B') - 1;

                int last_black_index = strip.LastIndexOf('B');

                int min_segment = last_black_index - first_black_index;

                //Console.Write("*** ");
                Console.WriteLine(min_segment);
            }
        }
    }
}
