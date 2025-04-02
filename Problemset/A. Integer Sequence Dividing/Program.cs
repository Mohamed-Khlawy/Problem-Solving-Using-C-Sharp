namespace A._Integer_Sequence_Dividing
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1102/A
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine()!);

            long oneToNumberSum = number * (number + 1) / 2;

            //Console.Write("******************* ");

            Console.WriteLine(oneToNumberSum % 2 == 0 ? 0 : 1);
        }
    }
}
