namespace C._Restoring_the_Duration_of_Tasks
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1690/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfTasks = int.Parse(Console.ReadLine()!);

                int[] startingTime = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                int[] finishingTime = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int[] durationTime = new int[numberOfTasks];

                durationTime[0] = finishingTime[0] - startingTime[0];

                for (int i = 1; i < numberOfTasks; i++)
                {
                    if (startingTime[i] < finishingTime[i - 1])
                    {
                        durationTime[i] = finishingTime[i] - finishingTime[i - 1];
                    }

                    else
                    {
                        durationTime[i] = finishingTime[i] - startingTime[i];
                    }
                }

                //Console.Write("**************************** ");

                Console.WriteLine(string.Join(" ", durationTime));
            }
        }
    }
}
