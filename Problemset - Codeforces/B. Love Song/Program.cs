namespace B._Love_Song
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1539/B
        public static long[] GetPrefixSumOfSong(char[] song)
        {
            long[] prefixSum = new long[song.Length + 1];

            for (int i = 1; i <= song.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + song[i - 1] - 96;
            }

            return prefixSum;
        }
        static void Main(string[] args)
        {
            int[] songDescription = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int songLength = songDescription[0];        /// n
            int numberOfQuestions = songDescription[1]; /// q

            char[] song = Console.ReadLine()!.ToCharArray();

            long[] songPrefixSum = GetPrefixSumOfSong(song);

            while (numberOfQuestions-- > 0)
            {
                int[] questionBounds = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int leftIndex = questionBounds[0];  /// l
                int rightIndex = questionBounds[1]; /// r

                long lengthOfVasyaString =
                    songPrefixSum[rightIndex] - songPrefixSum[leftIndex - 1];

                //Console.Write("********************* ");

                Console.WriteLine(lengthOfVasyaString);
            }
        }
    }
}
