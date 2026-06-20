namespace A._Ambitious_Kid
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1866/A
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine()!);

            int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int minAbsoluteNumber = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                minAbsoluteNumber = Math.Min(minAbsoluteNumber, Math.Abs(numbers[i]));

                if (minAbsoluteNumber == 0) break;
            }

            //Console.Write("******************************** ");

            Console.WriteLine(minAbsoluteNumber);
        }
    }
}
