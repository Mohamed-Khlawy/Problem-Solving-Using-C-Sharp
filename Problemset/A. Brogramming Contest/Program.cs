namespace A._Brogramming_Contest
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2064/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int stringLength = int.Parse(Console.ReadLine()!);

                char[] stringChars = Console.ReadLine()!.ToCharArray();

                char currentChar = '0';

                int minMoves = 0;

                for (int i = 0; i < stringLength; i++)
                {
                    if (stringChars[i] != currentChar)
                    {
                        currentChar = stringChars[i];
                        minMoves++;
                    }
                }

                //Console.Write("******************************** ");

                Console.WriteLine(minMoves);
            }
        }
    }
}
