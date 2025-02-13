namespace A._Walking_Master
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1806/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int startX = input[0];
                int startY = input[1];
                int finalX = input[2];
                int finalY = input[3];

                int minMoves = -1;

                if (startY <= finalY)
                {
                    int requiredMovesForY = finalY - startY;

                    int newX = startX + requiredMovesForY;

                    if (newX >= finalX)
                    {
                        int requiredMovesForX = newX - finalX;

                        minMoves = requiredMovesForX + requiredMovesForY;
                    }
                }

                //Console.Write("***************************** ");

                Console.WriteLine(minMoves);
            }
        }
    }
}
