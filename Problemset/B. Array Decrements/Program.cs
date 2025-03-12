namespace B._Array_Decrements
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1690/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraysSize = int.Parse(Console.ReadLine()!);

                int[] aNumbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                int[] bNumbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int minDiff = int.MaxValue;

                bool weCanDoIt = true;

                for (int i = 0; i < arraysSize; i++)
                {
                    if (bNumbers[i] != 0)
                        minDiff = Math.Min(minDiff, aNumbers[i] - bNumbers[i]);
                }

                if (minDiff < 0) weCanDoIt = false;

                else if (minDiff != int.MaxValue)
                {
                    for (int i = 0; i < arraysSize; i++)
                    {
                        int tempDiff = aNumbers[i] - bNumbers[i];

                        if (tempDiff > minDiff || (bNumbers[i] != 0 && tempDiff < minDiff))
                        {
                            weCanDoIt = false;
                            break;
                        }
                    }
                }

                //Console.Write("********************* ");

                Console.WriteLine(weCanDoIt ? "YES" : "NO");
            }
        }
    }
}
