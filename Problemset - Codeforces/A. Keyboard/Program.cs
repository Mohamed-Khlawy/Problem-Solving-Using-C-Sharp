namespace A._Keyboard
{
    internal class Program
    {
        //Problem Link: https://codeforces.com/problemset/problem/474/A
        static void Main(string[] args)
        {
            string direction = Console.ReadLine()!;
            string wrongWord = Console.ReadLine()!;
            string realWord = "";
            string keyboardChars = "qwertyuiopasdfghjkl;zxcvbnm,./";

            if (direction == "R") //His hands move Right, so we will get the (previous) char 
            {
                for (int i = 0; i < wrongWord.Length; i++)
                {
                    int realCharIndex = keyboardChars.IndexOf(wrongWord[i]) - 1;
                    realWord += keyboardChars[realCharIndex];
                }

                Console.WriteLine(realWord);
            }

            else if (direction == "L") //His hands move Left, so we will get the (next) char
            {
                for (int i = 0; i < wrongWord.Length; i++)
                {
                    int realCharIndex = keyboardChars.IndexOf(wrongWord[i]) + 1;
                    realWord += keyboardChars[realCharIndex];
                }

                Console.WriteLine(realWord);
            }
        }
    }
}