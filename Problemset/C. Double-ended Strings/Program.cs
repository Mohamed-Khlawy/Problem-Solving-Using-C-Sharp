namespace C._Double_ended_Strings
{
    internal class Program
    {
        // Problem LinK : https://codeforces.com/problemset/problem/1506/C
        public static void MakeWord1Bigger(ref string word1, ref string word2)
        {
            if (word1.Length < word2.Length)
                (word1, word2) = (word2, word1);
        }
        public static int FindLongestCommonSubString
            (string word1, string word2, int word1Pointer, int word2Pointer)
        {
            word1Pointer++;
            word2Pointer++;

            int longestCommonTempSubString = 1;

            while (word1Pointer < word1.Length && word2Pointer < word2.Length)
            {
                if (word1[word1Pointer] == word2[word2Pointer])
                {
                    longestCommonTempSubString++;
                    word1Pointer++;
                    word2Pointer++;
                }

                else
                {
                    break;
                }
            }

            return longestCommonTempSubString;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                string word1 = Console.ReadLine()!;
                string word2 = Console.ReadLine()!;

                /// Always make word1 the bigger between them
                MakeWord1Bigger(ref word1, ref word2);

                int longestCommonSubString = 0;

                for (int i = 0; i < word1.Length; i++)
                {
                    for (int j = 0; j < word2.Length; j++)
                    {
                        if (word1[i] == word2[j])
                        {
                            int tempLCSS =
                                FindLongestCommonSubString(word1, word2, i, j);

                            longestCommonSubString = Math.Max(longestCommonSubString, tempLCSS);
                        }
                    }
                }

                int minOperations = word1.Length - longestCommonSubString +
                    (word2.Length - longestCommonSubString);

                //Console.Write("*********************** ");

                Console.WriteLine(minOperations);
            }
        }
    }
}
