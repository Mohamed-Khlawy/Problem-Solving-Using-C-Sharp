namespace C._Choose_the_Different_Ones_
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1927/C
        public static void FillDictionaryFromList
            (List<int> list, ref Dictionary<int, List<int>> myDict, int listNumber, int maxElement)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= maxElement)
                {
                    if (myDict.TryGetValue(list[i], out List<int>? value))
                    {
                        if (!value.Contains(listNumber))
                            value.Add(listNumber);
                    }

                    else
                    {
                        List<int> tempList = new List<int>();
                        myDict.Add(list[i], tempList);
                        myDict[list[i]].Add(listNumber);
                    }
                }

                else break;
            }
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int list1Size = input[0];     /// n
                int list2Size = input[1];     /// m
                int finalListSize = input[2]; /// k

                List<int> list1 = Console.ReadLine()!.Split().Select(int.Parse).ToList();
                List<int> list2 = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                Dictionary<int, List<int>> myDict = new Dictionary<int, List<int>>();

                bool weCanDoIt = false;

                list1.Sort();
                list2.Sort();

                FillDictionaryFromList(list1, ref myDict, 1, finalListSize);
                FillDictionaryFromList(list2, ref myDict, 2, finalListSize);

                if (myDict.Count == finalListSize)
                {
                    int onlyInFirst = 0;
                    //myDict.Count(kvb => kvb.Value.Count == 1 && kvb.Value[0] == 1);
                    int onlyInSecond = 0;
                    //myDict.Count(kvb => kvb.Value.Count == 1 && kvb.Value[0] == 2);

                    foreach (List<int> list in myDict.Values)
                    {
                        if (list.Count == 1 && list[0] == 1) onlyInFirst++;

                        else if (list.Count == 1 && list[0] == 2) onlyInSecond++;
                    }

                    if (onlyInFirst <= finalListSize / 2 && onlyInSecond <= finalListSize / 2)
                    {
                        weCanDoIt = true;
                    }
                }

                //Console.Write("*********************** ");

                Console.WriteLine(weCanDoIt ? "YES" : "NO");
            }
        }
    }
}
