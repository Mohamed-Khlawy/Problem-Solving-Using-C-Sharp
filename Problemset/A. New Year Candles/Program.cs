namespace A._New_Year_Candles
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/379/A
        static void Main(string[] args)
        {
            int[] numberOfCandles_wentToNew = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int numberOfCandles = numberOfCandles_wentToNew[0];
            int wentToNew = numberOfCandles_wentToNew[1];
            int copy_numberOfCandles = numberOfCandles;

            int newCandles = 0;
            while (copy_numberOfCandles / wentToNew != newCandles)
            {
                newCandles = copy_numberOfCandles / wentToNew;
                copy_numberOfCandles = numberOfCandles + newCandles;
            }

            Console.WriteLine(copy_numberOfCandles);
        }
    }
}