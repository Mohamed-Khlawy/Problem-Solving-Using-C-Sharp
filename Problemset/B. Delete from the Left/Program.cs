namespace B._Delete_from_the_Left
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1005/B
        static void Main(string[] args)
        {
            char[] word1 = Console.ReadLine()!.ToCharArray();
            char[] word2 = Console.ReadLine()!.ToCharArray();

            int minMoves;

            int word1Pointer = word1.Length - 1;
            int word2Pointer = word2.Length - 1;

            while (true)
            {
                if (word1Pointer >= 0 && word2Pointer >= 0)
                {
                    if (word1[word1Pointer] == word2[word2Pointer])
                    {
                        word1Pointer--;
                        word2Pointer--;
                    }

                    else break;
                }

                else break;
            }

            minMoves = word1Pointer + word2Pointer + 2;

            //Console.Write("********************************* ");

            Console.WriteLine(minMoves);
        }
    }
}
