namespace C._Numbers_on_Whiteboard
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1430/C
        public static int CalculateTheHalf(int first, int second)
        {
            return (int)Math.Ceiling((decimal)(first + second) / 2);
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int permutationSize = int.Parse(Console.ReadLine()!);

                int previousHalf = CalculateTheHalf(permutationSize, permutationSize - 1);

                //Console.WriteLine("********************** ");

                Console.WriteLine(2);

                for (int i = permutationSize; i > 1; i--)
                {
                    if (i == permutationSize)
                    {
                        Console.WriteLine(i + " " + (i - 1));
                    }

                    else
                    {
                        Console.WriteLine(previousHalf + " " + (i - 1));

                        previousHalf = CalculateTheHalf(i - 1, previousHalf);
                    }
                }

                //Console.WriteLine("********************** ");
            }
        }
    }
}
