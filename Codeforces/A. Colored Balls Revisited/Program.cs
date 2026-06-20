namespace A._Colored_Balls_Revisited
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1728/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfColors = int.Parse(Console.ReadLine()!);

                int[] collorBalls = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int maxColorBallsIndex = 0;

                for (int i = 0; i < numberOfColors; i++)
                {
                    if (collorBalls[i] > collorBalls[maxColorBallsIndex])
                    {

                        maxColorBallsIndex = i;
                    }
                }

                //Console.Write("**************************** ");

                // +1 to convert from 0-based index to 1-based index
                Console.WriteLine(maxColorBallsIndex + 1);
            }
        }
    }
}
