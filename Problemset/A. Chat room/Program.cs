namespace A._Chat_room
{
    internal class Program
    {
        // Problem Link: https://codeforces.com/problemset/problem/58/A
        static void Main(string[] args)
        {
            string initialWord = Console.ReadLine()!;
            string hello = "hello";                   // h l e l o
            int j = 0;                                // h e l h c l u d o o
            for (int i = 0; i < hello.Length; i++)    // a h h e l l l l l o o u
            {
                bool found = false;
                while (j < initialWord.Length)
                {
                    if (initialWord[j] == hello[i])
                    {
                        found = true;
                        j++;
                        break;
                    }
                    j++;
                }
                if (!found)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}