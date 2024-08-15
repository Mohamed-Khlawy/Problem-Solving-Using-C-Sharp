namespace A._How_Much_Does_Daytona_Cost
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1878/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_k = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int size = n_k[0];
                int number = n_k[1];

                List<int> numbers = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                if (numbers.Contains(number))
                {
                    Console.WriteLine("YES");
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
