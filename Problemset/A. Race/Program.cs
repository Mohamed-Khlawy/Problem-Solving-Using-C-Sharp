namespace A._Race
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2112/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                int AlicePoint = input[0];  /// a
                int prizePoint1 = input[1]; /// x
                int prizePoint2 = input[2]; /// y

                bool BobCanWin = (AlicePoint < prizePoint1 && AlicePoint < prizePoint2) ||
                                 (AlicePoint > prizePoint1 && AlicePoint > prizePoint2);

                //Console.Write("******************************* ");

                Console.WriteLine(BobCanWin ? "YES" : "NO");
            }
        }
    }
}
