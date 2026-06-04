namespace A._Zhan_s_Blender
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2013/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int numberOfFruits = int.Parse(Console.ReadLine()!);

                int[] XYInput = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int X = XYInput[0];
                int Y = XYInput[1];

                int XYSmaller = Math.Min(X, Y);

                int minMinutes = (int)Math.Ceiling((double)numberOfFruits / XYSmaller);

                //Console.Write("*********************************** ");

                Console.WriteLine(minMinutes);
            }
        }
    }
}
