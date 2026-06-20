namespace A._The_Miracle_and_the_Sleeper
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1562/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] problemBounds = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int lowerBound = problemBounds[0]; /// l
                int upperBound = problemBounds[1]; /// r

                int largestModValue = 0;

                if (lowerBound != upperBound)
                {
                    int halfBound = (int)Math.Floor((decimal)upperBound / 2) + 1;

                    if (halfBound >= lowerBound)
                    {
                        largestModValue = upperBound % halfBound;
                    }

                    else
                    {
                        largestModValue = upperBound % lowerBound;
                    }
                }

                //Console.Write("******************** ");

                Console.WriteLine(largestModValue);
            }
        }
    }
}
