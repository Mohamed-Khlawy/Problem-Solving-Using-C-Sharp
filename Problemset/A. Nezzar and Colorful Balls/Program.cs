namespace A._Nezzar_and_Colorful_Balls
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1478/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int arraySize = int.Parse(Console.ReadLine()!);

                int[] balls = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int minColors = 0;

                int tempColors = 1;

                for (int i = 1; i < balls.Length; i++)
                {
                    if (balls[i] == balls[i - 1])
                    {
                        tempColors++;
                    }

                    else
                    {
                        minColors = Math.Max(minColors, tempColors);
                        tempColors = 1;
                    }
                }

                minColors = Math.Max(minColors, tempColors);

                //Console.Write("*************************** ");

                Console.WriteLine(minColors);
            }
        }
    }
}
