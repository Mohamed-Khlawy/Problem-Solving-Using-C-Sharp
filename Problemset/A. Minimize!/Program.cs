namespace A._Minimize_
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2009/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                List<int> input = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int first = input[0];
                int second = input[1];

                int result = second - first;

                //Console.Write("************************************** ");

                Console.WriteLine(result);
            }
        }
    }
}
