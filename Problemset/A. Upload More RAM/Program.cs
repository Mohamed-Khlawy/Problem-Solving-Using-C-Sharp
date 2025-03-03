namespace A._Upload_More_RAM
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1987/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfGBs = input[0];  /// n
                int timeWindow = input[1];   /// k

                //Console.Write("************************** ");

                Console.WriteLine((numberOfGBs - 1) * timeWindow + 1);
            }
        }
    }
}
