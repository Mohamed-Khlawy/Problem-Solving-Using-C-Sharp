namespace A._Shape_Perimeter
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2056/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_m = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfOperatins = n_m[0]; // n
                int squareDimension = n_m[1];   // m

                int newShapePerimeter = 0;

                for (int i = 0; i < numberOfOperatins; i++)
                {
                    int[] operation = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                    int rightMoves = operation[0]; // x
                    int upMoves = operation[1];    // y

                    if (i != 0)
                    {
                        newShapePerimeter += (rightMoves * 2) + (upMoves * 2);
                    }
                }

                newShapePerimeter += 4 * squareDimension;

                //Console.Write("***************************** ");

                Console.WriteLine(newShapePerimeter);
            }
        }
    }
}
