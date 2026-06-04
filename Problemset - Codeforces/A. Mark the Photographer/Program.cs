namespace A._Mark_the_Photographer
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1705/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int peopleInRow = input[0];   /// n
                int minHeightDiff = input[1]; /// x

                int[] peopleHeights = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                Array.Sort(peopleHeights);

                bool MarkCanDoIt = true;

                for (int i = 0; i < peopleInRow; i++)
                {
                    if (peopleHeights[i + peopleInRow] - peopleHeights[i] < minHeightDiff)
                    {
                        MarkCanDoIt = false;
                        break;
                    }
                }

                //Console.Write("******************** ");

                Console.WriteLine(MarkCanDoIt ? "YES" : "NO");
            }
        }
    }
}
