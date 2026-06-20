namespace A._2023
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1916/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfExisting = input[0];  /// n
                int numberOfRemoved = input[1];   /// k

                long[] numbers = Console.ReadLine()!.Split().Select(long.Parse).ToArray();

                long product = 1;

                for (int i = 0; i < numbers.Length; i++)
                {
                    product *= numbers[i];
                }

                //Console.Write("*********************** ");

                if (2023 % product == 0)
                {
                    List<int> removedNumbers = Enumerable.Repeat(1, numberOfRemoved - 1).ToList();

                    removedNumbers.Insert(0, 2023 / (int)product);

                    Console.WriteLine("YES");

                    Console.WriteLine(string.Join(" ", removedNumbers));
                }

                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
