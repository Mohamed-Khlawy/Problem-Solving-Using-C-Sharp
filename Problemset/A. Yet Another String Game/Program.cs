namespace A._Yet_Another_String_Game
{
    internal class Program
    {
        // Problem Link : https://codeforces.com/problemset/problem/1480/A
        public static char GameTurn(string playerName, char c)
        {
            return playerName switch
            {
                "Alice" => c == 97 ? 'b' : 'a',
                "Bob" => c == 122 ? 'y' : 'z',
                _ => c
            };
        }
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine()!);

            while (tests-- > 0)
            {
                char[] word = Console.ReadLine()!.ToCharArray();

                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        word[i] = GameTurn(playerName: "Alice", word[i]);
                    }

                    else
                    {
                        word[i] = GameTurn(playerName: "Bob", word[i]);
                    }
                }

                //Console.Write("************************* ");

                Console.WriteLine(string.Join("", word));
            }
        }
    }
}
