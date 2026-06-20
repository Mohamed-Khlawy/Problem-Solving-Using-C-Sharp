namespace A._New_Palindrome
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1832/A
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                char[] palinWord = Console.ReadLine()!.ToCharArray();

                bool weCanDoIt = false;

                if (palinWord.Length > 3)
                {
                    int halfIndex = palinWord.Length / 2;

                    for (int i = 0; i < halfIndex; i++)
                    {
                        for (int j = i + 1; j < halfIndex; j++)
                        {
                            if (palinWord[i] != palinWord[j])
                            {
                                weCanDoIt = true;
                                break;
                            }
                        }
                    }
                }

                //Console.Write("************************** ");

                Console.WriteLine(weCanDoIt ? "YES" : "NO");
            }
        }
    }
}
