namespace W._Encrypt___Decrypt_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = "PgEfTYaWGHjDAmxQqFLRpCJBownyUKZXkbvzIdshurMilNSVOtec#@_!=.+-*/";
            string original = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            int number = int.Parse(Console.ReadLine()!);
            string word = Console.ReadLine()!;

            if (number == 1)
            {
                string result = "";

                for (int i = 0; i < word.Length; i++)
                {
                    int index = original.IndexOf(word[i]);
                    result += key[index];
                }

                Console.WriteLine(result);
            }

            else
            {
                string result = "";

                for (int i = 0; i < word.Length; i++)
                {
                    int index = key.IndexOf(word[i]);
                    result += original[index];
                }

                Console.WriteLine(result);
            }
        }
    }
}