namespace A._Two_Rabbits
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1304/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int x = input[0];
                int y = input[1];
                int a = input[2];
                int b = input[3];

                int newY = y - x;
                long ab = a + b;

                //Console.Write("******************* ");

                Console.WriteLine(newY % ab == 0 ? newY / ab : -1);
            }
        }
    }
}
