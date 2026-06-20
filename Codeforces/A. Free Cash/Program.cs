namespace A._Free_Cash
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/237/A
        static void Main(string[] args)
        {
            #region My Own Solution (ACCEPTED) ==> (218ms, 2800KB)

            int numberOfVisitors = int.Parse(Console.ReadLine()!);

            Dictionary<string, int> ArrivingTimes = new Dictionary<string, int>();

            int minNumberOfCaches = 1;

            for (int i = 0; i < numberOfVisitors; i++)
            {
                string key = Console.ReadLine()!; /// iPerson Arriving Time

                if (ArrivingTimes.TryGetValue(key, out int value))
                {
                    ArrivingTimes[key] = ++value;
                }

                else
                {
                    ArrivingTimes[key] = 1;
                }

                minNumberOfCaches = Math.Max(minNumberOfCaches, ArrivingTimes[key]);
            }

            #endregion

            #region ChatGPT Solution (ACCEPTED) ==> (280ms, 3300KB)

            //int numberOfVisitors = int.Parse(Console.ReadLine()!);

            //Dictionary<(int, int), int> ArrivingTimes = new Dictionary<(int, int), int>();

            //int minNumberOfCaches = 1;

            //for (int i = 0; i < numberOfVisitors; i++)
            //{
            //    int[] iPerson = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            //    var key = (iPerson[0], iPerson[1]);

            //    if (ArrivingTimes.TryGetValue(key, out int value))
            //    {
            //        ArrivingTimes[key] = ++value;
            //    }

            //    else
            //    {
            //        ArrivingTimes[key] = 1;
            //    }

            //    minNumberOfCaches = Math.Max(minNumberOfCaches, ArrivingTimes[key]);
            //}

            #endregion

            #region Time Limit Exceed Solution

            //List<List<int>> ArrivingTime = new List<List<int>>();

            //int minNumberOfCaches = 1;

            //for (int i = 0; i < numberOfVisitors; i++)
            //{
            //    List<int> iPerson = Console.ReadLine()!.Split().Select(int.Parse).ToList();

            //    ArrivingTime.Add(iPerson);
            //}

            //for (int i = 0; i < numberOfVisitors - 1; i++)
            //{
            //    int tempCaches = 1;

            //    for (int j = i + 1; j < numberOfVisitors; j++)
            //    {
            //        if (ArrivingTime[i][0] == ArrivingTime[j][0] &&
            //            ArrivingTime[i][1] == ArrivingTime[j][1])
            //        {
            //            tempCaches++;
            //        }

            //        else
            //        {
            //            i = j - 1;
            //            break;
            //        }
            //    }

            //    if (tempCaches > minNumberOfCaches) minNumberOfCaches = tempCaches;
            //}

            #endregion

            //Console.Write("*********************** ");

            Console.WriteLine(minNumberOfCaches);
        }
    }
}
