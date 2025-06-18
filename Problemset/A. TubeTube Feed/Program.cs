namespace A._TubeTube_Feed
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1822/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                int[] n_t = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int numberOfVideos = n_t[0]; // n
                int timeForLunch = n_t[1];   // t

                int[] videosLengths =
                    Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                int[] videosEntertainments =
                    Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                int suitableVideo = -1;

                int maxEntertainment = 0;

                for (int i = 0; i < numberOfVideos; i++)
                {
                    int videoLength = videosLengths[i] + i;

                    if (videoLength <= timeForLunch &&
                        videosEntertainments[i] > maxEntertainment)
                    {
                        maxEntertainment = videosEntertainments[i];
                        suitableVideo = i + 1;
                    }
                }

                //Console.Write("********************************* ");

                Console.WriteLine(suitableVideo);
            }
        }
    }
}
