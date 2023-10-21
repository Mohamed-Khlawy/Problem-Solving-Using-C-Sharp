namespace U._New_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine()!;

            word = word.ToLower();

            Dictionary<char, int> egyptChars = new Dictionary<char, int>();

            string egypt = "egypt";

            for (int i = 0; i < egypt.Length; i++)
            {
                egyptChars.Add(egypt[i], 0);
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (egypt.Contains(word[i]))
                {
                    egyptChars[word[i]]++;
                }
            }

            int minValue = egyptChars['e'];

            foreach (var kvp in egyptChars)
            {
                if (kvp.Value < minValue)
                {
                    minValue = kvp.Value;
                }
            }

            Console.WriteLine(minValue);
        }
    }
}