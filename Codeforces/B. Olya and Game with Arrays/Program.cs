namespace B._Olya_and_Game_with_Arrays
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1859/B
        public static void FindLowestMinimum(int minimum, ref int lowestMinimum)
        {
            lowestMinimum = minimum < lowestMinimum ? minimum : lowestMinimum;
        }
        public static void FindSecondLowestMinimum(int minimum, ref int secondLowestMinimum)
        {
            secondLowestMinimum = minimum < secondLowestMinimum ? minimum : secondLowestMinimum;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfLists = int.Parse(Console.ReadLine()!);

                int lowestMinimum = int.MaxValue;
                int secondLowestMinimum = int.MaxValue;

                long maxBeauty = 0;

                for (int i = 0; i < numberOfLists; i++)
                {
                    int listSize = int.Parse(Console.ReadLine()!);

                    List<int> iList = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                    iList.Sort();

                    maxBeauty += iList[1]; /// Second Lowest Element in this list

                    /// As we sort each list,
                    /// so the lowest minimum will always be one of the first elements in any list
                    FindLowestMinimum(iList[0], ref lowestMinimum);

                    /// Same description for the lowest minimum
                    FindSecondLowestMinimum(iList[1], ref secondLowestMinimum);
                }

                maxBeauty += lowestMinimum;
                maxBeauty -= secondLowestMinimum;

                //Console.Write("*********************** ");

                Console.WriteLine(maxBeauty);
            }
        }
    }
}
