namespace A._Red_and_Blue_Beans
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1519/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int redBeans = input[0];  /// r
                int blueBeans = input[1]; /// b
                int maxDiff = input[2];   /// d

                bool weCanDoIt = true;

                if (redBeans != blueBeans &&
                    (Math.Abs(redBeans - blueBeans) != maxDiff))
                {
                    int upperBound = (int)Math.Ceiling((double)Math.Max(redBeans, blueBeans) /
                                                       Math.Min(redBeans, blueBeans));

                    if (upperBound > maxDiff + 1) weCanDoIt = false;
                }

                //Console.Write("******************** ");

                Console.WriteLine(weCanDoIt ? "YES" : "NO");
            }
    }
}
