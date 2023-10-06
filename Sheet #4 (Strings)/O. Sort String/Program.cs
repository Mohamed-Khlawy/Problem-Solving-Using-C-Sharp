namespace O._Sort_String
{
    internal class Program
    {
        //This problem got Memory Limit Exceded with this code but got 
        //accepted with same code in C++
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine()!);
            string word = Console.ReadLine()!;

            int[] charsFrequency = new int[26];

            for (int i = 0; i < word.Length; i++)
            {
                charsFrequency[(int)word[i] - 97]++;
            }

            for (int i = 0; i < charsFrequency.Length; i++)
            {
                while (charsFrequency[i] != 0)
                {
                    Console.Write((char)(i + 97));
                    charsFrequency[i]--;
                }
            }
        }
    }
}