namespace K._I_Love_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);
            while (tests-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                string firstWord = input[0];
                string secondWord = input[1];

                int maxWordSize = Math.Max(firstWord.Length, secondWord.Length);
                string resultWord = "";

                for (int i = 0; i < maxWordSize; i++)
                {
                    if (i < firstWord.Length)
                    {
                        resultWord += firstWord[i];
                    }
                    if (i < secondWord.Length)
                    {
                        resultWord += secondWord[i];
                    }
                }

                Console.WriteLine(resultWord);
            }
        }
    }
}