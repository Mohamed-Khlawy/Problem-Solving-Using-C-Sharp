namespace A._XOR_Mixup
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1698/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> integers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                integers.Sort();

                Console.WriteLine(integers[0]);
            }
        }
    }
}
