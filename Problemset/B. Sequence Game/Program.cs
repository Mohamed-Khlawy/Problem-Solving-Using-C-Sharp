namespace B._Sequence_Game
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1862/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int size = int.Parse(Console.ReadLine()!);

                List<int> input = Console.ReadLine()!.Split().Select(int.Parse).ToList();

                List<int> output = new List<int>();

                output.Add(input[0]);

                for (int i = 1; i < input.Count; i++)
                {
                    if (input[i] >= input[i - 1])
                    {
                        output.Add(input[i]);
                    }

                    else
                    {
                        output.Add(1);
                        output.Add(input[i]);
                    }
                }

                Console.WriteLine(output.Count);

                for (int i = 0; i < output.Count; i++)
                {
                    if (i == output.Count - 1)
                        Console.WriteLine(output[i]);

                    else
                    {
                        Console.Write(output[i] + " ");
                    }
                }

                //Console.WriteLine("***");
            }
        }
    }
}
