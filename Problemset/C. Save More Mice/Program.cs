namespace C._Save_More_Mice
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1593/C
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int holePosition = input[0]; /// n
                int numberOfMice = input[1]; /// k

                int[] micePositions = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                Array.Sort(micePositions);

                int catPosition = 0;

                int numberOfHiddenMice = 0;

                for (int i = numberOfMice - 1; i >= 0; i--)
                {
                    if (micePositions[i] <= catPosition) break;

                    int currentMouseMoves = holePosition - micePositions[i];

                    catPosition += currentMouseMoves;

                    numberOfHiddenMice++;
                }

                //Console.Write("******************* ");

                Console.WriteLine(numberOfHiddenMice);
            }
        }
    }
}
