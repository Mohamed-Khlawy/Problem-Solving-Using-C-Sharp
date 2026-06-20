namespace B._Maria_Breaks_the_Self_isolation
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1358/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfGrannies = int.Parse(Console.ReadLine()!);

                int[] grannies = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);

                Array.Sort(grannies);

                int lastAcceptedGrannyIndex = 0;

                for (int i = numberOfGrannies; i >= 1; i--)
                {
                    if (grannies[i - 1] <= i)
                    {
                        lastAcceptedGrannyIndex = i;
                        break;
                    }
                }

                //Console.Write("********************* ");

                Console.WriteLine(lastAcceptedGrannyIndex + 1);
            }
        }
    }
}
