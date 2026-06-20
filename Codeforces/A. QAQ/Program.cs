namespace A._QAQ
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/894/A
        static void Main(string[] args)
        {
            string word = Console.ReadLine()!;

            long numberOfQAQ = 0;

            for (int i = 0; i < word.Length; i++)
            {

                if (word[i] == 'Q')
                {

                    for (int j = i + 1; j < word.Length; j++)
                    {

                        if (word[j] == 'A')
                        {

                            for (int k = j + 1; k < word.Length; k++)
                            {

                                if (word[k] == 'Q')
                                {

                                    numberOfQAQ++;

                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(numberOfQAQ);
        }
    }
}