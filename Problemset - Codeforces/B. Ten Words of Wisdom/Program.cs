namespace B._Ten_Words_of_Wisdom
{
    internal class Program
    {
        //Proplem Link: https://codeforces.com/problemset/problem/1850/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                int numberOfResponses = int.Parse(Console.ReadLine()!);

                int winnerResponse = 0;
                int index = 0;
                int higestQuality = 0;

                while (numberOfResponses-- > 0)
                {
                    int[] numberOfWords_quality = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                    if (numberOfWords_quality[0] <= 10)
                    {
                        if (winnerResponse == 0)
                        {
                            winnerResponse = index + 1;
                            higestQuality = numberOfWords_quality[1];
                        }
                        else if (winnerResponse != 0 && higestQuality < numberOfWords_quality[1])
                        {
                            winnerResponse = index + 1;
                            higestQuality = numberOfWords_quality[1];
                        }
                    }

                    index++;
                }

                Console.WriteLine(winnerResponse);
            }
        }
    }
}