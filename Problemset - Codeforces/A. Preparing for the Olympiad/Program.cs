namespace A._Preparing_for_the_Olympiad
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2051/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfDays = int.Parse(Console.ReadLine()!);

                List<int> monoProblems = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                List<int> stereoProblems = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                int monoIndex = 0;
                int stereoIndex = 1; /// We will always skip first stereo problem

                long monoTotal = 0;
                long stereoTotal = 0;

                /// Because stereoIndex will finish before monoIndex
                while (stereoIndex < numberOfDays)
                {
                    if (monoProblems[monoIndex] >= stereoProblems[stereoIndex])
                    {
                        monoTotal += monoProblems[monoIndex];
                        stereoTotal += stereoProblems[stereoIndex];
                    }

                    monoIndex++;
                    stereoIndex++;
                }

                /// We will always take last problem from mono only
                monoTotal += monoProblems[^1];
                /// monoTotal += monoProblems[monoIndex];
                /// Both of these statements are equal,
                /// because when stereoIndex is equal to numberOfDays, 
                /// the monoIndex will be equal to the last day of his days,
                /// so they are equal statements

                //Console.Write("*********************************** ");

                Console.WriteLine(monoTotal - stereoTotal);
            }
        }
    }
}
