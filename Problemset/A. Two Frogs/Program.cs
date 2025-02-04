namespace A._Two_Frogs
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2055/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOFLilypads = input[0]; /// n
                int AlicePosition = input[1];    /// a
                int BobPosition = input[2];      /// b

                //Console.Write("******************** ");

                Console.WriteLine(Math.Abs(AlicePosition - BobPosition) % 2 == 0 ? "YES" : "NO");
            }
        }
    }
}
