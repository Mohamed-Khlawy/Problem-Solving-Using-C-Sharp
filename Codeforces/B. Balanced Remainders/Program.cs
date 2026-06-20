namespace B._Balanced_Remainders
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1490/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int[] mod3Result = new int[3];

                int minMoves = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 3 == 0) mod3Result[0]++;

                    else if (numbers[i] % 3 == 1) mod3Result[1]++;

                    else if (numbers[i] % 3 == 2) mod3Result[2]++;
                }

                while (mod3Result[0] != mod3Result[1] || mod3Result[1] != mod3Result[2])
                {
                    if (mod3Result[0] > arraySize / 3)
                    {
                        mod3Result[1] += mod3Result[0] - (arraySize / 3);
                        minMoves += mod3Result[0] - (arraySize / 3);
                        mod3Result[0] = arraySize / 3;
                    }

                    else if (mod3Result[1] > arraySize / 3)
                    {
                        mod3Result[2] += mod3Result[1] - (arraySize / 3);
                        minMoves += mod3Result[1] - (arraySize / 3);
                        mod3Result[1] = arraySize / 3;
                    }

                    else if (mod3Result[2] > arraySize / 3)
                    {
                        mod3Result[0] += mod3Result[2] - (arraySize / 3);
                        minMoves += mod3Result[2] - (arraySize / 3);
                        mod3Result[2] = arraySize / 3;
                    }
                }

                //Console.Write("*************************** ");

                Console.WriteLine(minMoves);
            }
        }
    }
}
