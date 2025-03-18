namespace A._Milya_and_Two_Arrays
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2059/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraysSize = int.Parse(Console.ReadLine()!);

                HashSet<int> numbers1 = Console.ReadLine()!.Split().Select(int.Parse).ToHashSet();
                HashSet<int> numbers2 = Console.ReadLine()!.Split().Select(int.Parse).ToHashSet().ToHashSet();

                //Console.Write("*********************** ");

                Console.WriteLine(
                    ((numbers1.Count > 1 && numbers2.Count > 1) ||
                    numbers1.Count > 2 || numbers2.Count > 2)
                    ? "YES"
                    : "NO");
            }
        }
    }
}
