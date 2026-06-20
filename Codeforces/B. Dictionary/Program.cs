namespace B._Dictionary
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1674/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                string berlandWord = Console.ReadLine()!;

                string alphabet = "abcdefghijklmnopqrstuvwxyz";

                int wordIndex = 0;

                if (berlandWord[0] < berlandWord[1]) /// Like ab (a < b) OR bc (b < c)
                {
                    wordIndex = (alphabet.IndexOf(berlandWord[0]) * 25) +
                        alphabet.IndexOf(berlandWord[1]);
                }

                else /// Like ba (b > a) OR cb (c > b)
                {
                    wordIndex = (alphabet.IndexOf(berlandWord[0]) * 25) +
                        alphabet.IndexOf(berlandWord[1]) + 1;
                }

                //Console.Write("******************************** ");

                Console.WriteLine(wordIndex);
            }
        }
    }
}
