namespace A._Increasing_Sequence
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1882/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int sequenceSize = int.Parse(Console.ReadLine()!);

                int[] sequence = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                sequence[0] = sequence[0] == 1 ? 2 : 1;

                for (int i = 1; i < sequenceSize; i++)
                {
                    sequence[i] = sequence[i] == sequence[i - 1] + 1
                        ? sequence[i - 1] + 2
                        : sequence[i - 1] + 1;
                }

                //Console.Write("********************** ");

                Console.WriteLine(sequence[^1]);
            }
        }
    }
}
