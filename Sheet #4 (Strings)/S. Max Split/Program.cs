namespace S._Max_Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine()!;

            int L_counter = 0;
            int R_counter = 0;
            int balancedStringsCounter = 0;
            List<string> balancedStrings = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'L')
                {
                    L_counter++;
                }
                else
                {
                    R_counter++;
                }

                if (L_counter == R_counter)
                {
                    balancedStringsCounter++;
                    balancedStrings.Add(word.Substring(0, L_counter + R_counter));
                    word = word.Substring(L_counter + R_counter);
                    L_counter = 0;
                    R_counter = 0;
                    i = -1;
                }
            }

            Console.WriteLine(balancedStringsCounter);

            foreach (string s in balancedStrings)
            {
                Console.WriteLine(s);
            }
        }
    }
}