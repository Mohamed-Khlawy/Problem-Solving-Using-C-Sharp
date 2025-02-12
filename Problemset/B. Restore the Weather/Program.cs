namespace B._Restore_the_Weather
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1833/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                #region Accepted Solution

                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfDays = input[0]; /// n
                int maxAbsDiff = input[1];   /// k

                int[] weatherForecast = Console.ReadLine()!.Split().Select(int.Parse).ToArray(); /// a
                int[] actualWeather = Console.ReadLine()!.Split().Select(int.Parse).ToArray();   /// b

                // Create a mapping of sorted weatherForecast values to their original indices
                var forecastIndices = weatherForecast
                    .Select((value, index) => new { Value = value, Index = index })
                    .OrderBy(x => x.Value)
                    .ToList(); // Sort by Value

                Array.Sort(actualWeather); // Sort the actualWeather array

                // Create result array
                int[] result = new int[numberOfDays];

                // Map sorted forecast indices to sorted actualWeather
                for (int i = 0; i < numberOfDays; i++)
                {
                    result[forecastIndices[i].Index] = actualWeather[i];
                }

                //Console.Write("************************* ");

                Console.WriteLine(string.Join(" ", result));

                #endregion

                #region Time Limit Exceed Solution

                //List<int> input = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                //int numberOfDays = input[0]; /// n
                //int maxAbsDiff = input[1];   /// k

                //List<int> weatherForecast = Console.ReadLine()!.Split().Select(int.Parse).ToList(); /// a
                //List<int> actualWeather = Console.ReadLine()!.Split().Select(int.Parse).ToList();   /// b

                //List<int> copyForecast = new List<int>(weatherForecast);

                //copyForecast.Sort();
                //actualWeather.Sort();

                //List<int> result = new List<int>();

                //for (int i = 0; i < numberOfDays; i++)
                //{
                //    int dayIndex = copyForecast.IndexOf(weatherForecast[i]);

                //    result.Add(actualWeather[dayIndex]);

                //    copyForecast.RemoveAt(dayIndex);
                //    actualWeather.RemoveAt(dayIndex);
                //}

                ////Console.Write("************************ ");

                //Console.WriteLine(string.Join(" ", result));

                #endregion
            }
        }
    }
}
