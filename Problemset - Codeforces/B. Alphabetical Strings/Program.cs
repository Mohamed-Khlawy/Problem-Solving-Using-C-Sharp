namespace B._Alphabetical_Strings
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1547/B
        public static bool AlphabeticalChecking1(string str)
        {
            /// Here we will check that each Character from 0 to the str length is existing
            char[] strCahrs = str.ToCharArray();

            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            Array.Sort(strCahrs);

            for (int i = 0; i < strCahrs.Length; i++)
            {
                if (strCahrs[i] != alphabet[i]) return false;
            }

            return true;
        }
        public static bool AlphabeticalChecking2(string str)
        {
            /// Here we will check for the alphabetically order of each char in the original str
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (str[i] != 'a' &&
                    ((str[i] > str[i - 1] && str[i] > str[i + 1]) ||
                    (str[i] < str[i - 1] && str[i] < str[i + 1]) ||
                    str[i] == str[i - 1] || str[i] == str[i + 1]))
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                string characters = Console.ReadLine()!;

                bool itIsAlphabetical =
                    AlphabeticalChecking1(characters) && AlphabeticalChecking2(characters);

                //Console.Write("******************************* ");

                Console.WriteLine(itIsAlphabetical ? "YES" : "NO");
            }
        }
    }
}
