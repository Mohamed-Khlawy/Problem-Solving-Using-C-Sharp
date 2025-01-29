namespace A._Jellyfish_and_Undertale
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1875/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int maxTimerValue = input[0]; /// a
                int initialValue = input[1];  /// b
                int numberOfTools = input[2]; /// n

                List<int> tools = Console.ReadLine()!.Split().Select(int.Parse).ToList();
                
                #region Note1
                /// First we add the intial seconds minus one (the first second) 
                /// in the bomb to the total seconds before iterating on the tools
                #endregion
                
                long totalSeconds = initialValue;

                //int toolsIndex = 0;

                for (int i = 0; i < tools.Count; i++)
                {
                    #region Note2
                    /// If the seconds that this tool adds to the timer 
                    /// is greater than the maxTimerValue we then deal with it as
                    /// the maxTimerValue minus one.
                    /// Else we add the seconds of this tool with no change
                    #endregion

                    totalSeconds += tools[i] + 1 <= maxTimerValue ? tools[i] : maxTimerValue - 1;
                }

                //Console.Write("***************************** ");

                Console.WriteLine(totalSeconds);
            }
        }
    }
}
