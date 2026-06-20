namespace B._Turtle_and_Piggy_Are_Playing_a_Game_2
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2003/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int sequenceSize = int.Parse(Console.ReadLine()!);

                int[] sequence = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                Array.Sort(sequence);

                int halfIndex = sequenceSize / 2;

                //Console.Write("*********************** ");

                Console.WriteLine(sequence[halfIndex]);
            }
        }
    }
}
