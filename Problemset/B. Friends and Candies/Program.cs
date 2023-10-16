namespace B._Friends_and_Candies
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/1538/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);
                int[] candiesArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                long totalCandies = candiesArray.Sum();

                if (totalCandies % size != 0)
                {
                    Console.WriteLine(-1);
                }

                else
                {
                    long maxNumberOfCandies = totalCandies / size;

                    int minNumberOfFriends = 0;

                    foreach (var cand in candiesArray)
                    {
                        if (cand > maxNumberOfCandies)
                        {
                            minNumberOfFriends++;
                        }
                    }

                    Console.WriteLine(minNumberOfFriends);
                }
            }
        }
    }
}