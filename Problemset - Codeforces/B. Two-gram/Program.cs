namespace B._Two_gram
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/977/B
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            string word = Console.ReadLine()!;

            Dictionary<string, int> twoGram = new Dictionary<string, int>();

            for (int i = 0; i < size - 1; i++)
            {
                string subword = word[i].ToString();
                subword += word[i + 1];

                if (twoGram.ContainsKey(subword))
                {
                    twoGram[subword]++;
                }
                else
                {
                    twoGram.Add(subword, 1);
                }
            }

            int maxValue = 0;
            string maxKey = "";

            foreach (var kvp in twoGram)
            {
                if (kvp.Value > maxValue)
                {
                    maxValue = kvp.Value;
                    maxKey = kvp.Key;
                }
            }

            Console.WriteLine(maxKey);
        }
    }
}