namespace B._Bogosort
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1312/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                numbers.Sort();

                numbers.Reverse();

                //Console.Write("******************** ");

                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
