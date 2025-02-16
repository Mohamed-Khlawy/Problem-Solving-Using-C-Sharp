namespace A._Line_Breaks
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2050/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfWords = input[0];    /// n
                int maxNumberOfChars = input[1]; /// m

                int numberOfChars = 0;
                int maxNumberOfWords = 0; /// x

                bool addAgain = true;

                for (int i = 0; i < numberOfWords; i++)
                {
                    string iWord = Console.ReadLine()!;

                    if (numberOfChars + iWord.Length <= maxNumberOfChars && addAgain)
                    {
                        numberOfChars += iWord.Length;
                        maxNumberOfWords++;
                    }

                    else addAgain = false;
                }

                //Console.Write("************************ ");

                Console.WriteLine(maxNumberOfWords);
            }
        }
    }
}
