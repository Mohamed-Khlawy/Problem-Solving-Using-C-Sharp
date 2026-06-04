namespace A._Two_Regular_Polygons
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1312/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] inputVertices = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int initialConvex = inputVertices[0]; /// n
                int resultConvex = inputVertices[1];  /// m

                int modResult = initialConvex % resultConvex;

                //Console.Write("**************************** ");

                Console.WriteLine(modResult == 0 ? "YES" : "NO");
            }
        }
    }
}
