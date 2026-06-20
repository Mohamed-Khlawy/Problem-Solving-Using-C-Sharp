namespace B._Not_Dividing
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1794/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                numbers = numbers.Select(number => number == 1 ? 2 : number).ToArray();

                for (int i = 1; i < arraySize; i++)
                {
                    if (numbers[i] % numbers[i - 1] == 0) numbers[i]++;
                }

                //Console.Write("************************* ");

                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
