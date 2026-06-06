namespace LeetCode
{
    // Problem Link: https://leetcode.com/problems/roman-to-integer/description/
    internal class Program
    {
        public int RomanToInt(string input)
        {
            List<char> romanNumeral = input.ToList();

            Dictionary<char, int> romanToInt = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            int result = 0;

            for (int i = 0; i < romanNumeral.Count; i++)
            {
                if (i + 1 < romanNumeral.Count && romanToInt[romanNumeral[i]] < romanToInt[romanNumeral[i + 1]])
                {
                    result += romanToInt[romanNumeral[i + 1]] - romanToInt[romanNumeral[i]];
                    i++;
                }

                else
                {
                    result += romanToInt[romanNumeral[i]];
                }
            }

            return (result);
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;

            Program pr = new Program();

            Console.WriteLine(pr.RomanToInt(input));
        }
    }
}
