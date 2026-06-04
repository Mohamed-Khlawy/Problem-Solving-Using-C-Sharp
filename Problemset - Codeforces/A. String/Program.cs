namespace A._String
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2062/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                char[] bits = Console.ReadLine()!.ToCharArray();

                int numberOfOnes = bits.Count(bit => bit == '1');

                //Console.Write("********************************* ");

                Console.WriteLine(numberOfOnes);
            }
        }
    }
}
