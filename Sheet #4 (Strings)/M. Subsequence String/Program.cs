namespace M._Subsequence_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine()!;
            string hello = "hello";
            string result = "";

            int indexForHello = 0;

            for (int i = 0; i < word.Length && indexForHello < hello.Length; i++)
            {
                if (word[i] == hello[indexForHello])
                {
                    result += word[i];
                    indexForHello++;
                }
            }

            if (result == hello)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}