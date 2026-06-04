namespace A._k_String
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/219/A
        static void Main(string[] args)
        {
            int numberOfCopies = int.Parse(Console.ReadLine()!);

            string str = Console.ReadLine()!;

            if (numberOfCopies == 1)
            {
                Console.WriteLine(str);
            }

            else
            {
                string alphabet = "abcdefghijklmnopqrstuvwxyz";

                int[] frequency = new int[26];

                bool weCanDoIt = true;

                for (int i = 0; i < str.Length; i++)
                {
                    int char_index = alphabet.IndexOf(str[i]);

                    frequency[char_index]++;
                }

                for (int i = 0; i < 26; i++)
                {
                    if (frequency[i] % numberOfCopies != 0)
                    {
                        weCanDoIt = false;
                        break;
                    }

                    else
                    {
                        // Update the frequency for each char to the number of it needed each time
                        frequency[i] /= numberOfCopies;
                    }
                }

                if (weCanDoIt)
                {
                    List<char> result = new List<char>();

                    for (int i = 0; i < numberOfCopies; i++)
                    {
                        List<char> iCopy = new List<char>();

                        for (int j = 0; j < 26; j++)
                        {
                            if (frequency[j] != 0)
                            {
                                List<char> jCopy =
                                    Enumerable.Repeat(alphabet[j], frequency[j]).ToList();

                                iCopy.AddRange(jCopy);
                            }
                        }

                        result.AddRange(iCopy);
                    }

                    Console.WriteLine(string.Join("", result));
                }

                else
                {
                    //Console.Write("*********************************** ");

                    Console.WriteLine(-1);
                }
            }
        }
    }
}
