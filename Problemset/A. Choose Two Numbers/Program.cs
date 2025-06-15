namespace A._Choose_Two_Numbers
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1206/A
        static void Main(string[] args)
        {
            int arrayOneSize = int.Parse(Console.ReadLine()!);

            int[] arrayOne = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            int arrayTwoSize = int.Parse(Console.ReadLine()!);

            int[] arrayTwo = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            //Console.Write("********************************* ");

            Console.WriteLine(arrayOne[arrayOneSize - 1] + " " + arrayTwo[arrayTwoSize - 1]);
        }
    }
}
