namespace B._Substring_Removal_Game
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1398/B
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                char[] stringChars = Console.ReadLine()!.ToCharArray();

                List<int> frequencyOfOneBlocks = new List<int>();

                int AliceScore = 0;

                for (int i = 0; i < stringChars.Length; i++)
                {
                    if (stringChars[i] == '1')
                    {
                        int count = 0;

                        while (i < stringChars.Length && stringChars[i] == '1')
                        {
                            count++;
                            i++;
                        }

                        // Add the count of consecutive '1's to the list
                        frequencyOfOneBlocks.Add(count);
                    }
                }

                frequencyOfOneBlocks.Sort();
                frequencyOfOneBlocks.Reverse();

                // Alice turns is even, because she starts first.
                AliceScore = frequencyOfOneBlocks
                    .Where((value, index) => index % 2 == 0)
                    .Sum();

                //Console.Write("************************************** ");

                Console.WriteLine(AliceScore);
            }
        }
    }
}
