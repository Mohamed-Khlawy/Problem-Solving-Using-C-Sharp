namespace A._My_First_Sorting_Problem
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1971/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> integrs = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                Console.WriteLine(integrs.Min() + " " + integrs.Max());
            }
        }
    }
}
