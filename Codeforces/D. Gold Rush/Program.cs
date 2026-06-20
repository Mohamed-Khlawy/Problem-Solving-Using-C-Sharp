namespace D._Gold_Rush
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1829/D
        public static bool CanWeDoIt(int startingPileSize, int targetPileSize)
        {
            if (startingPileSize == targetPileSize) return true;

            else if (startingPileSize % 3 != 0) return false;

            else
            {
                return CanWeDoIt(startingPileSize / 3, targetPileSize) ||
                       CanWeDoIt(2 * startingPileSize / 3, targetPileSize);
            }
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int startingPileSize = input[0]; /// n
                int targetPileSize = input[1];   /// m

                //Console.Write("****************************** ");

                Console.WriteLine(CanWeDoIt(startingPileSize, targetPileSize) ? "YES" : "NO");
            }
        }
    }
}
