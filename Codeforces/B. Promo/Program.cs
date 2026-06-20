namespace B._Promo
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1697/B
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int numberOfItems = input1[0];   /// n
            int numberOfQueries = input1[1]; /// q

            long[] shopItems = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

            Array.Sort(shopItems); // Sort in-place to save memory

            // Precompute prefix sums to optimize range sum queries
            long[] prefixSum = new long[numberOfItems + 1];

            for (int i = 1; i <= numberOfItems; i++)
                prefixSum[i] = prefixSum[i - 1] + shopItems[i - 1];

            while (numberOfQueries-- > 0)
            {
                int[] input2 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int itemsToBuy = input2[0];   /// x
                int itemsForFree = input2[1]; /// y

                // Compute sum in O(1) using prefix sum array
                int startIdx = numberOfItems - itemsToBuy;
                int endIdx = startIdx + itemsForFree;

                long maxValueForFree = prefixSum[endIdx] - prefixSum[startIdx];

                //Console.Write("**************** ");

                Console.WriteLine(maxValueForFree);
            }
        }
    }
}
