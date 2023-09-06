namespace A._Dreamoon_and_Stairs
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/476/A
        static void Main(string[] args)
        {
            int[] steps_number = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            double steps = steps_number[0];
            double number = steps_number[1];

            double minMoves = Math.Ceiling(steps / 2);

            while (minMoves % number != 0 && minMoves <= steps)
            {
                minMoves++;
            }

            if (minMoves > steps)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(minMoves);
            }
        }
    }
}