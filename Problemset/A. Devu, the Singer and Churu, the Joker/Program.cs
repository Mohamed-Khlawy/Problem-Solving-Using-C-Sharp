namespace A._Devu__the_Singer_and_Churu__the_Joker
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/439/A
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int DevuSongs = input[0]; /// n
            int eventTime = input[1]; /// d

            int[] songs = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int totalSongsTime = songs.Sum() + ((DevuSongs - 1) * 10);

            int ChureJokes = -1;

            if (totalSongsTime <= eventTime)
            {
                int remainingTime = eventTime - songs.Sum();

                ChureJokes = remainingTime / 5;
            }

            //Console.Write("************************* ");

            Console.WriteLine(ChureJokes);
        }
    }
}
