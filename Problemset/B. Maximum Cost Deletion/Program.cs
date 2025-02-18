namespace B._Maximum_Cost_Deletion
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1550/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int size = input[0];
                int a = input[1];
                int b = input[2];

                string word = Console.ReadLine()!;

                int totalPoints = 0;

                if (b >= 0)
                {
                    totalPoints = (a + b) * size;
                }

                else
                {
                    int numberOfBlocks = 1;

                    for (int i = 0; i < size - 1; i++)
                    {
                        if (word[i] != word[i + 1]) numberOfBlocks++;
                    }

                    totalPoints = (size * a) + ((numberOfBlocks / 2 + 1) * b);
                }

                //Console.Write("************************ ");

                Console.WriteLine(totalPoints);
            }
        }
    }
}
