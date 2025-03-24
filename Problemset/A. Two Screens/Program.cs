namespace A._Two_Screens
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/2025/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                char[] screen1Word = Console.ReadLine()!.ToCharArray();
                char[] screen2Word = Console.ReadLine()!.ToCharArray();

                int minWordLength = Math.Min(screen1Word.Length, screen2Word.Length);

                int screenPointer = 0;

                while (screenPointer < minWordLength)
                {
                    if (screen1Word[screenPointer] != screen2Word[screenPointer])
                        break;

                    screenPointer++;
                }

                int minSeconds =
                    screenPointer + (screen1Word.Length - screenPointer) +
                    (screen2Word.Length - screenPointer);

                minSeconds += screenPointer > 0 ? 1 : 0;

                //Console.Write("******************* ");

                Console.WriteLine(minSeconds);
            }
        }
    }
}
